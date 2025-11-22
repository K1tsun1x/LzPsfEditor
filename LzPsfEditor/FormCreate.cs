using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LzPsfEditor
{
	public partial class FormCreate : Form
	{
		public FormCreate()
		{
			InitializeComponent();
		}

		private void FormCreate_Load(object sender, EventArgs e)
		{
			CBGlyphWidth.SelectedIndex = 0;
			CBGlyphHeight.SelectedIndex = 0;
			CBGlyphs.SelectedIndex = 0;
			CBEncoding.SelectedIndex = 0;
		}
	}
}
