namespace LzPsfEditor
{
	partial class FormSelectEncoding
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelEncoding = new System.Windows.Forms.Label();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.ListBoxEncoding = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.LabelEncoding, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ButtonOK, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ListBoxEncoding, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 124);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// LabelEncoding
			// 
			this.LabelEncoding.AutoSize = true;
			this.LabelEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelEncoding.Location = new System.Drawing.Point(3, 0);
			this.LabelEncoding.Name = "LabelEncoding";
			this.LabelEncoding.Size = new System.Drawing.Size(283, 41);
			this.LabelEncoding.TabIndex = 0;
			this.LabelEncoding.Text = "Encoding:";
			this.LabelEncoding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonOK
			// 
			this.ButtonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonOK.Location = new System.Drawing.Point(3, 85);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(283, 36);
			this.ButtonOK.TabIndex = 2;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			// 
			// ListBoxEncoding
			// 
			this.ListBoxEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListBoxEncoding.FormattingEnabled = true;
			this.ListBoxEncoding.Items.AddRange(new object[] {
            "ASCII",
            "CP437",
            "CP866",
            "Windows-1251",
            "KOI8-R"});
			this.ListBoxEncoding.Location = new System.Drawing.Point(3, 44);
			this.ListBoxEncoding.Name = "ListBoxEncoding";
			this.ListBoxEncoding.Size = new System.Drawing.Size(283, 24);
			this.ListBoxEncoding.TabIndex = 3;
			this.ListBoxEncoding.Text = "ASCII";
			// 
			// FormSelectEncoding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 124);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSelectEncoding";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select encoding";
			this.Load += new System.EventHandler(this.FormSelectEncoding_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelEncoding;
		public System.Windows.Forms.Button ButtonOK;
		public System.Windows.Forms.ComboBox ListBoxEncoding;
	}
}