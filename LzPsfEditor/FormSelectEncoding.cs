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
	public partial class FormSelectEncoding : Form
	{
		public FormSelectEncoding()
		{
			InitializeComponent();
		}

		private void FormSelectEncoding_Load(object sender, EventArgs e)
		{
			ListBoxEncoding.SelectedIndex = 0;
		}
	}
}
