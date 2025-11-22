namespace LzPsfEditor
{
	partial class FormCreate
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
			this.GBGlyphWidth = new System.Windows.Forms.GroupBox();
			this.CBGlyphWidth = new System.Windows.Forms.ComboBox();
			this.GBGlyphHeight = new System.Windows.Forms.GroupBox();
			this.CBGlyphHeight = new System.Windows.Forms.ComboBox();
			this.GBGlyphs = new System.Windows.Forms.GroupBox();
			this.CBGlyphs = new System.Windows.Forms.ComboBox();
			this.GBEncoding = new System.Windows.Forms.GroupBox();
			this.CBEncoding = new System.Windows.Forms.ComboBox();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.GBGlyphWidth.SuspendLayout();
			this.GBGlyphHeight.SuspendLayout();
			this.GBGlyphs.SuspendLayout();
			this.GBEncoding.SuspendLayout();
			this.SuspendLayout();
			// 
			// GBGlyphWidth
			// 
			this.GBGlyphWidth.Controls.Add(this.CBGlyphWidth);
			this.GBGlyphWidth.Dock = System.Windows.Forms.DockStyle.Top;
			this.GBGlyphWidth.Location = new System.Drawing.Point(0, 0);
			this.GBGlyphWidth.Name = "GBGlyphWidth";
			this.GBGlyphWidth.Size = new System.Drawing.Size(266, 47);
			this.GBGlyphWidth.TabIndex = 0;
			this.GBGlyphWidth.TabStop = false;
			this.GBGlyphWidth.Text = "Glyph Width";
			// 
			// CBGlyphWidth
			// 
			this.CBGlyphWidth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CBGlyphWidth.FormattingEnabled = true;
			this.CBGlyphWidth.Items.AddRange(new object[] {
            "8",
            "16"});
			this.CBGlyphWidth.Location = new System.Drawing.Point(3, 18);
			this.CBGlyphWidth.Name = "CBGlyphWidth";
			this.CBGlyphWidth.Size = new System.Drawing.Size(260, 24);
			this.CBGlyphWidth.TabIndex = 0;
			this.CBGlyphWidth.Text = "8";
			// 
			// GBGlyphHeight
			// 
			this.GBGlyphHeight.Controls.Add(this.CBGlyphHeight);
			this.GBGlyphHeight.Dock = System.Windows.Forms.DockStyle.Top;
			this.GBGlyphHeight.Location = new System.Drawing.Point(0, 47);
			this.GBGlyphHeight.Name = "GBGlyphHeight";
			this.GBGlyphHeight.Size = new System.Drawing.Size(266, 50);
			this.GBGlyphHeight.TabIndex = 1;
			this.GBGlyphHeight.TabStop = false;
			this.GBGlyphHeight.Text = "Glyph Height";
			// 
			// CBGlyphHeight
			// 
			this.CBGlyphHeight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CBGlyphHeight.FormattingEnabled = true;
			this.CBGlyphHeight.Items.AddRange(new object[] {
            "8",
            "16"});
			this.CBGlyphHeight.Location = new System.Drawing.Point(3, 18);
			this.CBGlyphHeight.Name = "CBGlyphHeight";
			this.CBGlyphHeight.Size = new System.Drawing.Size(260, 24);
			this.CBGlyphHeight.TabIndex = 0;
			this.CBGlyphHeight.Text = "8";
			// 
			// GBGlyphs
			// 
			this.GBGlyphs.Controls.Add(this.CBGlyphs);
			this.GBGlyphs.Dock = System.Windows.Forms.DockStyle.Top;
			this.GBGlyphs.Location = new System.Drawing.Point(0, 97);
			this.GBGlyphs.Name = "GBGlyphs";
			this.GBGlyphs.Size = new System.Drawing.Size(266, 47);
			this.GBGlyphs.TabIndex = 2;
			this.GBGlyphs.TabStop = false;
			this.GBGlyphs.Text = "Glyphs";
			// 
			// CBGlyphs
			// 
			this.CBGlyphs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CBGlyphs.FormattingEnabled = true;
			this.CBGlyphs.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
			this.CBGlyphs.Location = new System.Drawing.Point(3, 18);
			this.CBGlyphs.Name = "CBGlyphs";
			this.CBGlyphs.Size = new System.Drawing.Size(260, 24);
			this.CBGlyphs.TabIndex = 0;
			this.CBGlyphs.Text = "256";
			// 
			// GBEncoding
			// 
			this.GBEncoding.Controls.Add(this.CBEncoding);
			this.GBEncoding.Dock = System.Windows.Forms.DockStyle.Top;
			this.GBEncoding.Location = new System.Drawing.Point(0, 144);
			this.GBEncoding.Name = "GBEncoding";
			this.GBEncoding.Size = new System.Drawing.Size(266, 47);
			this.GBEncoding.TabIndex = 3;
			this.GBEncoding.TabStop = false;
			this.GBEncoding.Text = "Encoding (visible only)";
			// 
			// CBEncoding
			// 
			this.CBEncoding.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CBEncoding.FormattingEnabled = true;
			this.CBEncoding.Items.AddRange(new object[] {
            "ASCII",
            "CP437",
            "CP866",
            "KOI8-R",
            "Windows-1251"});
			this.CBEncoding.Location = new System.Drawing.Point(3, 18);
			this.CBEncoding.Name = "CBEncoding";
			this.CBEncoding.Size = new System.Drawing.Size(260, 24);
			this.CBEncoding.Sorted = true;
			this.CBEncoding.TabIndex = 0;
			this.CBEncoding.Text = "ASCII";
			// 
			// ButtonOK
			// 
			this.ButtonOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonOK.Location = new System.Drawing.Point(0, 191);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(266, 80);
			this.ButtonOK.TabIndex = 4;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			// 
			// FormCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 271);
			this.ControlBox = false;
			this.Controls.Add(this.ButtonOK);
			this.Controls.Add(this.GBEncoding);
			this.Controls.Add(this.GBGlyphs);
			this.Controls.Add(this.GBGlyphHeight);
			this.Controls.Add(this.GBGlyphWidth);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormCreate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create";
			this.Load += new System.EventHandler(this.FormCreate_Load);
			this.GBGlyphWidth.ResumeLayout(false);
			this.GBGlyphHeight.ResumeLayout(false);
			this.GBGlyphs.ResumeLayout(false);
			this.GBEncoding.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GBGlyphWidth;
		public System.Windows.Forms.ComboBox CBGlyphWidth;
		private System.Windows.Forms.GroupBox GBGlyphHeight;
		public System.Windows.Forms.ComboBox CBGlyphHeight;
		private System.Windows.Forms.GroupBox GBGlyphs;
		public System.Windows.Forms.ComboBox CBGlyphs;
		private System.Windows.Forms.GroupBox GBEncoding;
		public System.Windows.Forms.ComboBox CBEncoding;
		public System.Windows.Forms.Button ButtonOK;
	}
}