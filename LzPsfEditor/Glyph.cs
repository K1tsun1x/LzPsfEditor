using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LzPsfEditor
{
	public class Glyph
	{
		private uint _sizeInBytes;
		private uint _widthInBits;
		private uint _heightInBits;
		private uint _bytesPerRow;
		private List<byte> _cells;

		public Glyph(uint sizeInBytes, uint widthInBits, uint heightInBits)
		{
			_sizeInBytes = sizeInBytes;
			_widthInBits = widthInBits;
			_heightInBits = heightInBits;
			_bytesPerRow = (uint)Math.Ceiling(_widthInBits / 8.0);

			_cells = new List<byte>();
			for (uint i = 0; i < _widthInBits * _heightInBits; i++) _cells.Add(0);
		}

		public Glyph(uint sizeInBytes, uint widthInBits, uint heightInBits, BinaryReader binaryReaderAtThisGlyph)
		{
			_sizeInBytes = sizeInBytes;
			_widthInBits = widthInBits;
			_heightInBits = heightInBits;

			_cells = new List<byte>();
			_bytesPerRow = (uint)Math.Ceiling(_widthInBits / 8.0);

			for (int row = 0; row < _heightInBits; row++)
			{
				for (int b = 0; b < _bytesPerRow; b++)
				{
					byte value = binaryReaderAtThisGlyph.ReadByte();
					_cells.Add(value);
				}
			}
		}

		public bool GetBit(uint x, uint y)
		{
			if (x < 0 || x >= _widthInBits || y < 0 || y >= _heightInBits) throw new ArgumentOutOfRangeException();
			int index = (int)(y * _bytesPerRow + x / 8);
			int bit = (int)(7 - (x % 8));
			return (_cells[index] & (1 << bit)) != 0;
		}

		public void SetBit(uint x, uint y, bool value)
		{
			if (x < 0 || x >= _widthInBits || y < 0 || y >= _heightInBits) throw new ArgumentOutOfRangeException();
			int index = (int)(y * _bytesPerRow + x / 8);
			int bit = (int)(7 - (x % 8));
			if (value) _cells[index] |= (byte)(1 << bit);
			else _cells[index] &= (byte)~(1 << bit);
		}

		public byte[] ToByteArray()
		{
			return _cells.ToArray();
		}
	}
}
