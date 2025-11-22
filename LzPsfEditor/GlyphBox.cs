using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LzPsfEditor
{
	public partial class GlyphBox : UserControl
	{
		private int _GlyphWidth = 8;
		private int _GlyphHeight = 8;
		private Glyph _Glyph = null;
		private bool _DrawGrid = true;
		private bool _Editable = true;
		private Action<int, int> _OnCellClick = null;

		public bool DrawGrid
		{
			get => _DrawGrid;
			set => _DrawGrid = value;
		}

		public bool Editable
		{
			get => _Editable;
			set => _Editable = value;
		}

		public Glyph Glyph
		{
			get => _Glyph;
		}

		public GlyphBox()
		{
			InitializeComponent();
		}

		public GlyphBox(int glyphWidth, int glyphHeight, Action<int, int> onCellClick = null)
		{
			InitializeComponent();
			_GlyphWidth = glyphWidth;
			_GlyphHeight = glyphHeight;
			_OnCellClick = onCellClick;
		}

		public GlyphBox(int glyphWidth, int glyphHeight, Glyph glyph, Action<int, int> onCellClick = null)
		{
			InitializeComponent();
			_GlyphWidth = glyphWidth;
			_GlyphHeight = glyphHeight;
			_Glyph = glyph;
			_OnCellClick = onCellClick;
		}

		public void SetDimensions(int glyphWidth, int glyphHeight)
		{
			_GlyphWidth = glyphWidth;
			_GlyphHeight = glyphHeight;
		}

		public void SelectGlyph(Glyph glyph)
		{
			_Glyph = glyph;
			Refresh();
			Cursor = Cursors.Hand;
		}

		public void DeselectGlyph()
		{
			_Glyph = null;
			Refresh();
			Cursor = Cursors.No;
		}

		public void SetOnCellClick(Action<int, int> onCellClick = null)
		{
			_OnCellClick = onCellClick;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			int width = Width;
			int height = Height;
			int cellWidth = width / _GlyphWidth;
			int cellHeight = height / _GlyphHeight;
			using (Brush bkg = new SolidBrush(Color.FromArgb(0, 0, 0)))
			using (Pen grid = new Pen(new SolidBrush(Color.FromArgb(0xff, 0xff, 0xff))))
			using (Brush frg = new SolidBrush(Color.FromArgb(0xff, 0x7f, 0)))
			{
				e.Graphics.FillRectangle(bkg, new Rectangle(0, 0, width, height));

				if (_Glyph != null)
				{
					for (int y = 0; y < _GlyphHeight; y++)
					{
						for (int x = 0; x < _GlyphWidth; x++)
						{
							if (_Glyph.GetBit((uint)x, (uint)y) != false)
							{
								e.Graphics.FillRectangle(
									frg,
									new Rectangle(
										x * cellWidth,
										y * cellHeight,
										cellWidth,
										cellHeight
									)
								);
							}
						}
					}
				}

				if (_DrawGrid)
				{
					for (int i = 0; i < _GlyphWidth; i++)
					{
						e.Graphics.DrawLine(grid, new Point(cellWidth * i, 0), new Point(cellWidth * i, height - 1));
					}

					for (int i = 0; i < _GlyphHeight; i++)
					{
						e.Graphics.DrawLine(grid, new Point(0, cellHeight * i), new Point(width - 1, cellHeight * i));
					}
				}
			}
		}

		private void GlyphBox_MouseHover(object sender, EventArgs e)
		{
			if (_Glyph != null) Cursor = Cursors.Hand;
			else Cursor = Cursors.No;
		}

		private void GlyphBox_MouseClick(object sender, MouseEventArgs e)
		{
			if (_Glyph != null && _Editable == true)
			{
				int x = e.Location.X;
				int y = e.Location.Y;

				int width = Width;
				int height = Height;
				int cellWidth = width / _GlyphWidth;
				int cellHeight = height / _GlyphHeight;

				int glyph_x = x / cellWidth;
				int glyph_y = y / cellHeight;
				_Glyph.SetBit((uint)glyph_x, (uint)glyph_y, !_Glyph.GetBit((uint)glyph_x, (uint)glyph_y));
				if (_OnCellClick != null) _OnCellClick(glyph_x, glyph_y);
				Refresh();
			}
		}
	}
}
