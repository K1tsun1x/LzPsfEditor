using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LzPsfEditor
{
	public partial class FormMain : Form
	{
		private string _Path = string.Empty;
		private uint _CharSize = 0;
		private uint _GlyphWidth = 0;
		private uint _GlyphHeight = 0;
		private bool _Opened = false;
		private int _NewSavedFileType = 0;
		private string _NewSavedFileExt = string.Empty;
		private List<Glyph> _Glyphs = new List<Glyph>();
		public FormMain()
		{
			InitializeComponent();
		}

		public bool OpenPSF(string path)
		{
			bool res = false;
			FormSelectEncoding formSelectEncoding = new FormSelectEncoding();
			formSelectEncoding.Show();
			formSelectEncoding.ButtonOK.Click += (s, e) =>
			{
				string selectedText = formSelectEncoding.ListBoxEncoding.Text;
				Encoding enc = Encoding.GetEncoding(selectedText);
				formSelectEncoding.Close();
				try
				{
					using (var tmpFileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
					using (var tmpBinaryReader = new BinaryReader(tmpFileStream))
					{
						UInt16 magic = tmpBinaryReader.ReadUInt16();
						uint version = 0;
						if (magic == 0x0436) version = 1;
						else if (magic == 0xb572)
						{
							magic = tmpBinaryReader.ReadUInt16();
							if (magic == 0x864a) version = 2;
							else version = 0;
						}

						uint numGlyphs;
						bool hasUnicode;
						uint charSizeInBytes;
						uint glyphWidth;
						uint glyphHeight;
						if (version == 1)
						{
							byte fontMode = tmpBinaryReader.ReadByte();
							numGlyphs = (fontMode & 1) != 0 ? 512u : 256u;
							hasUnicode = (fontMode & 2) != 0;
							charSizeInBytes = tmpBinaryReader.ReadByte();
							glyphWidth = 8;
							glyphHeight = charSizeInBytes;
						}
						else if (version == 2)
						{
							if (tmpBinaryReader.ReadUInt32() != 0)
							{
								MessageBox.Show("Unknown PSF font version!", "Error", MessageBoxButtons.OK);
								res = false;
								return;
							}
							else
							{
								uint headerSize = tmpBinaryReader.ReadUInt32();
								hasUnicode = (tmpBinaryReader.ReadUInt32() & 1) != 0;
								numGlyphs = tmpBinaryReader.ReadUInt32();
								charSizeInBytes = tmpBinaryReader.ReadUInt32();
								glyphHeight = tmpBinaryReader.ReadUInt32();
								glyphWidth = tmpBinaryReader.ReadUInt32();
								tmpFileStream.Seek(headerSize, SeekOrigin.Begin);
							}
						}
						else
						{
							MessageBox.Show("This version of PSF is not supported!", "Error", MessageBoxButtons.OK);
							return;
						}

						_Path = path;
						_CharSize = charSizeInBytes;
						_GlyphWidth = glyphWidth;
						_GlyphHeight = glyphHeight;
						GlyphBoxMain.SetDimensions((int)_GlyphWidth, (int)_GlyphHeight);

						if (_Glyphs.Count > 0) _Glyphs.Clear();
						ListViewGlyphs.Items.Clear();
						for (uint i = 0; i < numGlyphs; i++)
						{
							Glyph tmp = new Glyph(charSizeInBytes, glyphWidth, glyphHeight, tmpBinaryReader);
							_Glyphs.Add(tmp);

							var item = new ListViewItem($"{i}) '{enc.GetString(new byte[] { (byte)i })}'");
							ListViewGlyphs.Items.Add(item);

							StatusLabel.Text = $"Loaded glyph with index = {i}";
							StatusStrip.Refresh();
						}

						StatusLabel.Text = "";
						_Opened = true;
						res = true;
					}
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
					return;
				}
			};

			return res;
		}

		public string ConvertIntToCharIfPossible(int value)
		{
			if (value == 0x08) return "'\\b'";
			else if (value == 0x09) return "'\\t'";
			else if (value == 0x0a) return "'\\n'";
			else if (value == 0x0b) return "'\\v'";
			else if (value == 0x0d) return "'\\r'";
			else if (
				value == 0x27 ||        // \
				value == 0x22 ||        // "
				value == 0x5c           // '
			) return "'\\" + ((char)value) + "'";
			else if (value >= 32 && value < 127) return "'" + ((char)value) + "'";
			else return Convert.ToString(value);
		}

		/*
			indexPos = -1 -> array with index before glyph data
		*/
		public bool SaveCArray(
			string path,

			/**
			 * -1 -> array with index before data
			 * 0 -> array
			 * 1 -> array with index after data
			 */
			int indexPos
		)
		{
			int bytesPerLine = (int)(_GlyphWidth / 8);
			string res = "typedef struct _glyph_t {\n";
			string rowType = "";
			if (bytesPerLine == 1) rowType = "unsigned char";
			else if (bytesPerLine == 2) rowType = "unsigned short";
			else if (bytesPerLine == 4) rowType = "unsigned int";
			else if (bytesPerLine == 8) rowType = "unsigned long long";
			else
			{
				string s = "Unfortunately, saving fonts with a width and/or height not a power of 2 (in bits) is not implemented.";
				MessageBox.Show(s, "Sorry... :(");
				return false;
			}

			if (indexPos == -1)
			{
				res += "\tint\tindex;\n\t" + rowType + "\tdata[" + $"{_GlyphHeight}" + "];\n} glyph_t;\n\n";
				res += "glyph_t GLYPHS[" + $"{_Glyphs.Count}" + "] = {\n";
				for (uint i = 0; i < (uint)_Glyphs.Count; i++)
				{
					res += "\t{ " + ConvertIntToCharIfPossible((int)i) + ", {\n";
					for (uint y = 0; y < _GlyphHeight; y++)
					{
						string strLineBits = "";
						for (uint x = 0; x < _GlyphWidth; x++)
						{
							if (_Glyphs[(int)i].GetBit(x, y) == true) strLineBits += '1';
							else strLineBits += '0';
						}

						res += "\t\t0b" + strLineBits + ",\n";
					}

					res += "\t}},\n";
				}
			}
			else if (indexPos == 1)
			{
				res += "\t" + rowType + "\tdata[" + $"{_GlyphHeight}" + "];\n\tint\tindex;\n} glyph_t;\n\n";
				res += "glyph_t GLYPHS[" + $"{_Glyphs.Count}" + "] = {\n";
				for (uint i = 0; i < (uint)_Glyphs.Count; i++)
				{
					res += "\t{{\n";
					for (uint y = 0; y < _GlyphHeight; y++)
					{
						string strLineBits = "";
						for (uint x = 0; x < _GlyphWidth; x++)
						{
							if (_Glyphs[(int)i].GetBit(x, y) == true) strLineBits += '1';
							else strLineBits += '0';
						}

						res += "\t\t0b" + strLineBits + ",\n";
					}

					res += "\t}, " + ConvertIntToCharIfPossible((int)i) + "},\n";
				}
			}
			else
			{
				res += "\t" + rowType + "\tdata[" + $"{_GlyphHeight}" + "];\n} glyph_t;\n\n";
				res += "glyph_t GLYPHS[" + $"{_Glyphs.Count}" + "] = {\n";
				for (uint i = 0; i < (uint)_Glyphs.Count; i++)
				{
					res += "\t{\n";
					for (uint y = 0; y < _GlyphHeight; y++)
					{
						string strLineBits = "";
						for (uint x = 0; x < _GlyphWidth; x++)
						{
							if (_Glyphs[(int)i].GetBit(x, y) == true) strLineBits += '1';
							else strLineBits += '0';
						}

						res += "\t\t0b" + strLineBits + ",\n";
					}

					res += "\t},\n";
				}
			}

			res += "};";
			File.WriteAllText(path, res);
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <param name="version">PSF1: 1, PSF2: 2</param>
		/// <returns></returns>
		public bool SavePSF(string path, int version)
		{
			if (_Opened == false || (version != 1 && version != 2)) return false;

			try
			{

				using (var tmpFileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
				using (var tmpBinaryWriter = new BinaryWriter(tmpFileStream))
				{
					if (version == 1)
					{
						tmpBinaryWriter.Write((byte)0x36);
						tmpBinaryWriter.Write((byte)0x04);

						if (_Glyphs.Count == 256) tmpBinaryWriter.Write((byte)0);
						else if (_Glyphs.Count == 512) tmpBinaryWriter.Write((byte)1);
						else if (_Glyphs.Count > 512)
						{
							MessageBox.Show("Number of glyphs != 256 and 512, some glyphs may be lost!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
							_Glyphs.RemoveRange(512, _Glyphs.Count - 512);
							tmpBinaryWriter.Write((byte)1);
						}
						else
						{
							Glyph tmp = new Glyph(_CharSize, _GlyphWidth, _GlyphHeight);
							for (uint i = 0; i < 512u; i++) _Glyphs.Add(tmp);
							tmpBinaryWriter.Write((byte)1);
						}

						tmpBinaryWriter.Write((byte)_CharSize);
					}
					else if (version == 2)
					{
						tmpBinaryWriter.Write((byte)0x72);
						tmpBinaryWriter.Write((byte)0xb5);
						tmpBinaryWriter.Write((byte)0x4a);
						tmpBinaryWriter.Write((byte)0x86);

						tmpBinaryWriter.Write((uint)0);					// version
						tmpBinaryWriter.Write((uint)32);				// header size
						tmpBinaryWriter.Write((uint)0);                 // flags
						tmpBinaryWriter.Write((uint)_Glyphs.Count);     // number of glyphs
						tmpBinaryWriter.Write((uint)_CharSize);         // glyph size in bytes
						tmpBinaryWriter.Write((uint)_GlyphHeight);
						tmpBinaryWriter.Write((uint)_GlyphWidth);
					}
					else
					{
						MessageBox.Show("Unsupported version!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

					byte b = 0;
					uint k = 0;
					for (uint i = 0; i < (uint)_Glyphs.Count; i++)
					{
						for (uint y = 0; y < _GlyphHeight; y++)
						{
							for (uint x = 0; x < _GlyphWidth; x++)
							{
								if (_Glyphs[(int)i].GetBit(x, y) == true) b |= (byte)(1 << (int)k);

								++k;
								if (k == 8)
								{
									tmpBinaryWriter.Write(b);
									b = 0;
									k = 0;
								}
							}
						}
					}
				}

				return true;
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void DropDownButtonFileOpen_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog
			{
				Filter = "PC Screen Font (*.psf)|*.psf|All files (*.*)|*.*",
				Multiselect = false,
				RestoreDirectory = true,
				FilterIndex = 1
			};

			if (dlg.ShowDialog() != DialogResult.OK) return;
			OpenPSF(dlg.FileName);
		}

		private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_Path == string.Empty || _Opened == false) return;
			OpenPSF(_Path);
			GlyphBoxMain.DeselectGlyph();
			GlyphBoxGlyphPreview.DeselectGlyph();
		}

		private void ListViewGlyphs_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ListViewGlyphs.SelectedItems.Count > 0)
			{
				string text = ListViewGlyphs.SelectedItems[0].Text;
				int index = (int)Convert.ToUInt32(text.Split(')')[0]);
				GlyphBoxMain.SelectGlyph(_Glyphs[index]);
				SelectPreviewGlyph(_Glyphs[index], (uint)NUDGlyphPreviewWidth.Value, (uint)NUDGlyphPreviewHeight.Value);
				GlyphBoxMain.SetOnCellClick((x, y) =>
				{
					SelectPreviewGlyph(_Glyphs[index], (uint)NUDGlyphPreviewWidth.Value, (uint)NUDGlyphPreviewHeight.Value);
				});
			}
		}

		private void SelectPreviewGlyph(Glyph glyph, uint x, uint y)
		{
			GlyphBoxGlyphPreview.SelectGlyph(glyph);
		}

		private void DropDownButtonFileNew_Click(object sender, EventArgs e)
		{
			FormCreate form = new FormCreate();
			form.Show();
			form.ButtonOK.Click += (s, _) =>
			{
				ListViewGlyphs.Items.Clear();
				if (_Glyphs.Count > 0) _Glyphs.Clear();
				_GlyphWidth = Convert.ToUInt32(form.CBGlyphWidth.SelectedItem.ToString());
				_GlyphHeight = Convert.ToUInt32(form.CBGlyphHeight.SelectedItem.ToString());
				_CharSize = ((_GlyphWidth + 7) / 8) * _GlyphHeight;
				uint numGlyphs = Convert.ToUInt32(form.CBGlyphs.SelectedItem.ToString());
				Encoding enc = Encoding.GetEncoding(form.CBEncoding.SelectedItem.ToString());
				form.Close();

				for (uint i = 0; i < numGlyphs; i++)
				{
					Glyph tmp = new Glyph(_CharSize, _GlyphWidth, _GlyphHeight);
					_Glyphs.Add(tmp);

					var item = new ListViewItem($"{i}) '{enc.GetString(new byte[] { (byte)i })}'");
					ListViewGlyphs.Items.Add(item);
				}

				_Opened = true;
			};
		}

		private void DropDownButtonFileSave_Click(object sender, EventArgs e)
		{
			if (_Opened == true)
			{
				if (_Path == string.Empty) DropDownButtonFileSaveAs_Click(sender, e);
				else
				{
					if (_NewSavedFileExt == ".c") SaveCArray(_Path, _NewSavedFileType);
					else if (_NewSavedFileExt == ".psf") SavePSF(_Path, _NewSavedFileType);
				}
			}
		}

		private void DropDownButtonFileSaveAs_Click(object sender, EventArgs e)
		{
			if (_Opened == true)
			{
				string filter = "";
				if (_GlyphWidth % 8 == 0 && _GlyphHeight % 8 == 0)
				{
					filter += "C array (*.c)|*.c|";
					filter += "C array with index at the beginning of elements (*.c)|*.c|";
					filter += "C array with index at the end of elements (*.c)|*.c|";
					filter += "PC Screen Font 1 (*.psf)|*.psf|";
					filter += "PC Screen Font 2 (*.psf)|*.psf";
				}
				else
				{
					string s = "Unfortunately, saving fonts with a width and/or height not a multiple of 8 (in bits) is not implemented.";
					MessageBox.Show(s, "Sorry... :(");
					return;
				}

				var dlg = new SaveFileDialog()
				{
					Filter = filter,
					RestoreDirectory = true,
					FilterIndex = 1
				};

				if (dlg.ShowDialog() != DialogResult.OK) return;

				if (dlg.FilterIndex == 1)
				{
					if (SaveCArray(dlg.FileName, 0))
					{
						_Path = dlg.FileName;
						_NewSavedFileType = 0;
						_NewSavedFileExt = ".c";
					}
				}
				else if (dlg.FilterIndex == 2)
				{
					if (SaveCArray(dlg.FileName, -1))
					{
						_Path = dlg.FileName;
						_NewSavedFileType = -1;
						_NewSavedFileExt = ".c";
					}
				}
				else if (dlg.FilterIndex == 3)
				{
					if (SaveCArray(dlg.FileName, 1))
					{
						_Path = dlg.FileName;
						_NewSavedFileType = 1;
						_NewSavedFileExt = ".c";
					}
				}
				else if (dlg.FilterIndex == 4)
				{
					if (SavePSF(dlg.FileName, 1))
					{
						_Path = dlg.FileName;
						_NewSavedFileType = 1;
						_NewSavedFileExt = ".psf";
					}
				}
				else if (dlg.FilterIndex == 5)
				{
					if (SavePSF(dlg.FileName, 2))
					{
						_Path = dlg.FileName;
						_NewSavedFileType = 2;
						_NewSavedFileExt = ".psf";
					}
				}
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_Opened = false;
			_Glyphs.Clear();
			ListViewGlyphs.Items.Clear();
			_Path = string.Empty;
			GlyphBoxMain.DeselectGlyph();
		}

		private void NUDGlyphPreviewWidth_ValueChanged(object sender, EventArgs e)
		{
			SelectPreviewGlyph(
				GlyphBoxMain.Glyph,
				(uint)NUDGlyphPreviewWidth.Value,
				(uint)NUDGlyphPreviewHeight.Value
			);
		}

		private void NUDGlyphPreviewHeight_ValueChanged(object sender, EventArgs e)
		{
			SelectPreviewGlyph(
				GlyphBoxMain.Glyph,
				(uint)NUDGlyphPreviewWidth.Value,
				(uint)NUDGlyphPreviewHeight.Value
			);
		}
	}
}
