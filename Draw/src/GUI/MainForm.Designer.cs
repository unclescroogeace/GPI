namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawElipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.AddTriangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.GroupShapesButton = new System.Windows.Forms.ToolStripButton();
            this.UnGroupShapesButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PickBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.PickBorderColor = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.pickUpSpeedButton,
            this.DrawElipseSpeedButton,
            this.AddTriangleSpeedButton,
            this.GroupShapesButton,
            this.UnGroupShapesButton,
            this.PickBackgroundColor,
            this.PickBorderColor});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(693, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // DrawElipseSpeedButton
            // 
            this.DrawElipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawElipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawElipseSpeedButton.Image")));
            this.DrawElipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawElipseSpeedButton.Name = "DrawElipseSpeedButton";
            this.DrawElipseSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.DrawElipseSpeedButton.Text = "DrawElipseButton";
            this.DrawElipseSpeedButton.Click += new System.EventHandler(this.DrawElipseSpeedButton_Click);
            // 
            // AddTriangleSpeedButton
            // 
            this.AddTriangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTriangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTriangleSpeedButton.Image")));
            this.AddTriangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTriangleSpeedButton.Name = "AddTriangleSpeedButton";
            this.AddTriangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.AddTriangleSpeedButton.Text = "AddTriangleButton";
            this.AddTriangleSpeedButton.Click += new System.EventHandler(this.AddTriangleSpeedButton_Click);
            // 
            // GroupShapesButton
            // 
            this.GroupShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupShapesButton.Image")));
            this.GroupShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupShapesButton.Name = "GroupShapesButton";
            this.GroupShapesButton.Size = new System.Drawing.Size(23, 22);
            this.GroupShapesButton.Text = "GroupShapesButton";
            this.GroupShapesButton.Click += new System.EventHandler(this.GroupShapesButton_Click);
            // 
            // UnGroupShapesButton
            // 
            this.UnGroupShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnGroupShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("UnGroupShapesButton.Image")));
            this.UnGroupShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnGroupShapesButton.Name = "UnGroupShapesButton";
            this.UnGroupShapesButton.Size = new System.Drawing.Size(23, 22);
            this.UnGroupShapesButton.Text = "UnGroupShapesButton";
            this.UnGroupShapesButton.Click += new System.EventHandler(this.UnGroupShapesButton_Click);
            // 
            // PickBackgroundColor
            // 
            this.PickBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PickBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("PickBackgroundColor.Image")));
            this.PickBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PickBackgroundColor.Name = "PickBackgroundColor";
            this.PickBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this.PickBackgroundColor.Text = "toolStripButton1";
            this.PickBackgroundColor.ToolTipText = "PickBackgroundColor";
            this.PickBackgroundColor.Click += new System.EventHandler(this.PickBackgroundColor_Click);
            // 
            // PickBorderColor
            // 
            this.PickBorderColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PickBorderColor.Image = ((System.Drawing.Image)(resources.GetObject("PickBorderColor.Image")));
            this.PickBorderColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PickBorderColor.Name = "PickBorderColor";
            this.PickBorderColor.Size = new System.Drawing.Size(23, 22);
            this.PickBorderColor.Text = "PickBorderColor";
            this.PickBorderColor.Click += new System.EventHandler(this.PickBorderColor_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(693, 352);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(201, 0);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 255;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton DrawElipseSpeedButton;
        private System.Windows.Forms.ToolStripButton AddTriangleSpeedButton;
        private System.Windows.Forms.ToolStripButton GroupShapesButton;
        private System.Windows.Forms.ToolStripButton UnGroupShapesButton;
        private System.Windows.Forms.ToolStripButton PickBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton PickBorderColor;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
