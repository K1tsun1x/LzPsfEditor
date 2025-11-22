namespace LzPsfEditor
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.DropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
			this.DropDownButtonFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.reopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.DropDownButtonFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.DropDownButtonFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.DropDownButtonFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.SplitContainer = new System.Windows.Forms.SplitContainer();
			this.ListViewGlyphs = new System.Windows.Forms.ListView();
			this.GlyphBoxMain = new LzPsfEditor.GlyphBox();
			this.PanelGlyphPreview = new System.Windows.Forms.Panel();
			this.GBGlyphPreview = new System.Windows.Forms.GroupBox();
			this.GBGlyphPreviewHeight = new System.Windows.Forms.GroupBox();
			this.NUDGlyphPreviewHeight = new System.Windows.Forms.NumericUpDown();
			this.GBGlyphPreviewWidth = new System.Windows.Forms.GroupBox();
			this.NUDGlyphPreviewWidth = new System.Windows.Forms.NumericUpDown();
			this.GlyphBoxGlyphPreview = new LzPsfEditor.GlyphBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.toolStrip1.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
			this.SplitContainer.Panel1.SuspendLayout();
			this.SplitContainer.Panel2.SuspendLayout();
			this.SplitContainer.SuspendLayout();
			this.PanelGlyphPreview.SuspendLayout();
			this.GBGlyphPreview.SuspendLayout();
			this.GBGlyphPreviewHeight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NUDGlyphPreviewHeight)).BeginInit();
			this.GBGlyphPreviewWidth.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NUDGlyphPreviewWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownButtonFile});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1128, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "ts1";
			// 
			// DropDownButtonFile
			// 
			this.DropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.DropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownButtonFileOpen,
            this.reopenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.DropDownButtonFileNew,
            this.toolStripMenuItem2,
            this.DropDownButtonFileSave,
            this.DropDownButtonFileSaveAs,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem});
			this.DropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButtonFile.Image")));
			this.DropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DropDownButtonFile.Name = "DropDownButtonFile";
			this.DropDownButtonFile.Size = new System.Drawing.Size(46, 24);
			this.DropDownButtonFile.Text = "File";
			// 
			// DropDownButtonFileOpen
			// 
			this.DropDownButtonFileOpen.Name = "DropDownButtonFileOpen";
			this.DropDownButtonFileOpen.Size = new System.Drawing.Size(143, 26);
			this.DropDownButtonFileOpen.Text = "Open";
			this.DropDownButtonFileOpen.Click += new System.EventHandler(this.DropDownButtonFileOpen_Click);
			// 
			// reopenToolStripMenuItem
			// 
			this.reopenToolStripMenuItem.Name = "reopenToolStripMenuItem";
			this.reopenToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.reopenToolStripMenuItem.Text = "Reopen";
			this.reopenToolStripMenuItem.Click += new System.EventHandler(this.reopenToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
			// 
			// DropDownButtonFileNew
			// 
			this.DropDownButtonFileNew.Name = "DropDownButtonFileNew";
			this.DropDownButtonFileNew.Size = new System.Drawing.Size(143, 26);
			this.DropDownButtonFileNew.Text = "New";
			this.DropDownButtonFileNew.Click += new System.EventHandler(this.DropDownButtonFileNew_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 6);
			// 
			// DropDownButtonFileSave
			// 
			this.DropDownButtonFileSave.Name = "DropDownButtonFileSave";
			this.DropDownButtonFileSave.Size = new System.Drawing.Size(143, 26);
			this.DropDownButtonFileSave.Text = "Save";
			this.DropDownButtonFileSave.Click += new System.EventHandler(this.DropDownButtonFileSave_Click);
			// 
			// DropDownButtonFileSaveAs
			// 
			this.DropDownButtonFileSaveAs.Name = "DropDownButtonFileSaveAs";
			this.DropDownButtonFileSaveAs.Size = new System.Drawing.Size(143, 26);
			this.DropDownButtonFileSaveAs.Text = "Save as";
			this.DropDownButtonFileSaveAs.Click += new System.EventHandler(this.DropDownButtonFileSaveAs_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 644);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(1128, 22);
			this.StatusStrip.TabIndex = 3;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(0, 16);
			// 
			// SplitContainer
			// 
			this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Left;
			this.SplitContainer.Location = new System.Drawing.Point(0, 27);
			this.SplitContainer.Name = "SplitContainer";
			// 
			// SplitContainer.Panel1
			// 
			this.SplitContainer.Panel1.AutoScroll = true;
			this.SplitContainer.Panel1.Controls.Add(this.ListViewGlyphs);
			// 
			// SplitContainer.Panel2
			// 
			this.SplitContainer.Panel2.AutoScroll = true;
			this.SplitContainer.Panel2.Controls.Add(this.GlyphBoxMain);
			this.SplitContainer.Size = new System.Drawing.Size(962, 617);
			this.SplitContainer.SplitterDistance = 320;
			this.SplitContainer.TabIndex = 4;
			// 
			// ListViewGlyphs
			// 
			this.ListViewGlyphs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListViewGlyphs.FullRowSelect = true;
			this.ListViewGlyphs.HideSelection = false;
			this.ListViewGlyphs.Location = new System.Drawing.Point(0, 0);
			this.ListViewGlyphs.MultiSelect = false;
			this.ListViewGlyphs.Name = "ListViewGlyphs";
			this.ListViewGlyphs.Size = new System.Drawing.Size(320, 617);
			this.ListViewGlyphs.TabIndex = 0;
			this.ListViewGlyphs.UseCompatibleStateImageBehavior = false;
			this.ListViewGlyphs.View = System.Windows.Forms.View.Tile;
			this.ListViewGlyphs.SelectedIndexChanged += new System.EventHandler(this.ListViewGlyphs_SelectedIndexChanged);
			// 
			// GlyphBoxMain
			// 
			this.GlyphBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GlyphBoxMain.DrawGrid = true;
			this.GlyphBoxMain.Editable = true;
			this.GlyphBoxMain.Location = new System.Drawing.Point(0, 0);
			this.GlyphBoxMain.Name = "GlyphBoxMain";
			this.GlyphBoxMain.Size = new System.Drawing.Size(638, 617);
			this.GlyphBoxMain.TabIndex = 1;
			// 
			// PanelGlyphPreview
			// 
			this.PanelGlyphPreview.Controls.Add(this.GBGlyphPreview);
			this.PanelGlyphPreview.Controls.Add(this.splitter1);
			this.PanelGlyphPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelGlyphPreview.Location = new System.Drawing.Point(962, 27);
			this.PanelGlyphPreview.Name = "PanelGlyphPreview";
			this.PanelGlyphPreview.Size = new System.Drawing.Size(166, 617);
			this.PanelGlyphPreview.TabIndex = 6;
			// 
			// GBGlyphPreview
			// 
			this.GBGlyphPreview.Controls.Add(this.GBGlyphPreviewHeight);
			this.GBGlyphPreview.Controls.Add(this.GBGlyphPreviewWidth);
			this.GBGlyphPreview.Controls.Add(this.GlyphBoxGlyphPreview);
			this.GBGlyphPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GBGlyphPreview.Location = new System.Drawing.Point(3, 0);
			this.GBGlyphPreview.Name = "GBGlyphPreview";
			this.GBGlyphPreview.Size = new System.Drawing.Size(163, 617);
			this.GBGlyphPreview.TabIndex = 1;
			this.GBGlyphPreview.TabStop = false;
			this.GBGlyphPreview.Text = "Glyph Preview";
			// 
			// GBGlyphPreviewHeight
			// 
			this.GBGlyphPreviewHeight.Controls.Add(this.NUDGlyphPreviewHeight);
			this.GBGlyphPreviewHeight.Dock = System.Windows.Forms.DockStyle.Top;
			this.GBGlyphPreviewHeight.Location = new System.Drawing.Point(3, 218);
			this.GBGlyphPreviewHeight.Name = "GBGlyphPreviewHeight";
			this.GBGlyphPreviewHeight.Size = new System.Drawing.Size(157, 50);
			this.GBGlyphPreviewHeight.TabIndex = 5;
			this.GBGlyphPreviewHeight.TabStop = false;
			this.GBGlyphPreviewHeight.Text = "Height (in bits) (N/A)";
			// 
			// NUDGlyphPreviewHeight
			// 
			this.NUDGlyphPreviewHeight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NUDGlyphPreviewHeight.Enabled = false;
			this.NUDGlyphPreviewHeight.Location = new System.Drawing.Point(3, 18);
			this.NUDGlyphPreviewHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.NUDGlyphPreviewHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NUDGlyphPreviewHeight.Name = "NUDGlyphPreviewHeight";
			this.NUDGlyphPreviewHeight.Size = new System.Drawing.Size(151, 22);
			this.NUDGlyphPreviewHeight.TabIndex = 0;
			this.NUDGlyphPreviewHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.NUDGlyphPreviewHeight.ValueChanged += new System.EventHandler(this.NUDGlyphPreviewHeight_ValueChanged);
			// 
			// GBGlyphPreviewWidth
			// 
			this.GBGlyphPreviewWidth.Controls.Add(this.NUDGlyphPreviewWidth);
			this.GBGlyphPreviewWidth.Dock = System.Windows.Forms.DockStyle.Top;
			this.GBGlyphPreviewWidth.Location = new System.Drawing.Point(3, 168);
			this.GBGlyphPreviewWidth.Name = "GBGlyphPreviewWidth";
			this.GBGlyphPreviewWidth.Size = new System.Drawing.Size(157, 50);
			this.GBGlyphPreviewWidth.TabIndex = 4;
			this.GBGlyphPreviewWidth.TabStop = false;
			this.GBGlyphPreviewWidth.Text = "Width (in bits) (N/A)";
			// 
			// NUDGlyphPreviewWidth
			// 
			this.NUDGlyphPreviewWidth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NUDGlyphPreviewWidth.Enabled = false;
			this.NUDGlyphPreviewWidth.Location = new System.Drawing.Point(3, 18);
			this.NUDGlyphPreviewWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.NUDGlyphPreviewWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NUDGlyphPreviewWidth.Name = "NUDGlyphPreviewWidth";
			this.NUDGlyphPreviewWidth.Size = new System.Drawing.Size(151, 22);
			this.NUDGlyphPreviewWidth.TabIndex = 0;
			this.NUDGlyphPreviewWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.NUDGlyphPreviewWidth.ValueChanged += new System.EventHandler(this.NUDGlyphPreviewWidth_ValueChanged);
			// 
			// GlyphBoxGlyphPreview
			// 
			this.GlyphBoxGlyphPreview.Dock = System.Windows.Forms.DockStyle.Top;
			this.GlyphBoxGlyphPreview.DrawGrid = false;
			this.GlyphBoxGlyphPreview.Editable = false;
			this.GlyphBoxGlyphPreview.Location = new System.Drawing.Point(3, 18);
			this.GlyphBoxGlyphPreview.Name = "GlyphBoxGlyphPreview";
			this.GlyphBoxGlyphPreview.Size = new System.Drawing.Size(157, 150);
			this.GlyphBoxGlyphPreview.TabIndex = 3;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 617);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 666);
			this.Controls.Add(this.PanelGlyphPreview);
			this.Controls.Add(this.SplitContainer);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.toolStrip1);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Laziest PSF Editor v0.5 by V8086";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.SplitContainer.Panel1.ResumeLayout(false);
			this.SplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
			this.SplitContainer.ResumeLayout(false);
			this.PanelGlyphPreview.ResumeLayout(false);
			this.GBGlyphPreview.ResumeLayout(false);
			this.GBGlyphPreviewHeight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NUDGlyphPreviewHeight)).EndInit();
			this.GBGlyphPreviewWidth.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NUDGlyphPreviewWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton DropDownButtonFile;
		private System.Windows.Forms.ToolStripMenuItem DropDownButtonFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem DropDownButtonFileNew;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem DropDownButtonFileSave;
		private System.Windows.Forms.ToolStripMenuItem DropDownButtonFileSaveAs;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.SplitContainer SplitContainer;
		private System.Windows.Forms.ListView ListViewGlyphs;
		private GlyphBox GlyphBoxMain;
		private System.Windows.Forms.ToolStripMenuItem reopenToolStripMenuItem;
		private System.Windows.Forms.Panel PanelGlyphPreview;
		private System.Windows.Forms.GroupBox GBGlyphPreview;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.GroupBox GBGlyphPreviewHeight;
		private System.Windows.Forms.NumericUpDown NUDGlyphPreviewHeight;
		private System.Windows.Forms.GroupBox GBGlyphPreviewWidth;
		private System.Windows.Forms.NumericUpDown NUDGlyphPreviewWidth;
		private GlyphBox GlyphBoxGlyphPreview;
	}
}

