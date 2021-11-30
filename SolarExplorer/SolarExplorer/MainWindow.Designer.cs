namespace SolarExplorer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuDragControl mainWindowDrag;
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainWindowElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.leftPanel = new System.Windows.Forms.Panel();
            this.sunBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainWindowPages = new Bunifu.UI.WinForms.BunifuPages();
            this.SunPage = new System.Windows.Forms.TabPage();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            mainWindowDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.leftPanel.SuspendLayout();
            this.mainWindowPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowDrag
            // 
            mainWindowDrag.Fixed = true;
            mainWindowDrag.Horizontal = true;
            mainWindowDrag.TargetControl = this;
            mainWindowDrag.Vertical = true;
            // 
            // mainWindowElipse
            // 
            this.mainWindowElipse.ElipseRadius = 25;
            this.mainWindowElipse.TargetControl = this;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftPanel.Controls.Add(this.minimizeBtn);
            this.leftPanel.Controls.Add(this.closeBtn);
            this.leftPanel.Controls.Add(this.sunBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(138, 1080);
            this.leftPanel.TabIndex = 0;
            // 
            // sunBtn
            // 
            this.sunBtn.Animated = true;
            this.sunBtn.BorderRadius = 15;
            this.sunBtn.CheckedState.Parent = this.sunBtn;
            this.sunBtn.CustomImages.Parent = this.sunBtn;
            this.sunBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sunBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sunBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sunBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sunBtn.DisabledState.Parent = this.sunBtn;
            this.sunBtn.FillColor = System.Drawing.Color.Empty;
            this.sunBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sunBtn.ForeColor = System.Drawing.Color.White;
            this.sunBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.sunBtn.HoverState.Parent = this.sunBtn;
            this.sunBtn.Image = ((System.Drawing.Image)(resources.GetObject("sunBtn.Image")));
            this.sunBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.sunBtn.Location = new System.Drawing.Point(26, 148);
            this.sunBtn.Name = "sunBtn";
            this.sunBtn.ShadowDecoration.Parent = this.sunBtn;
            this.sunBtn.Size = new System.Drawing.Size(76, 62);
            this.sunBtn.TabIndex = 1;
            this.sunBtn.Click += new System.EventHandler(this.sunBtn_Click);
            // 
            // mainWindowPages
            // 
            this.mainWindowPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.mainWindowPages.AllowTransitions = false;
            this.mainWindowPages.Controls.Add(this.SunPage);
            this.mainWindowPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowPages.Location = new System.Drawing.Point(138, 0);
            this.mainWindowPages.Multiline = true;
            this.mainWindowPages.Name = "mainWindowPages";
            this.mainWindowPages.Page = this.SunPage;
            this.mainWindowPages.PageIndex = 0;
            this.mainWindowPages.PageName = "SunPage";
            this.mainWindowPages.PageTitle = "SunPage";
            this.mainWindowPages.SelectedIndex = 0;
            this.mainWindowPages.Size = new System.Drawing.Size(1804, 1080);
            this.mainWindowPages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.mainWindowPages.Transition = animation1;
            this.mainWindowPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // SunPage
            // 
            this.SunPage.Location = new System.Drawing.Point(4, 4);
            this.SunPage.Name = "SunPage";
            this.SunPage.Padding = new System.Windows.Forms.Padding(3);
            this.SunPage.Size = new System.Drawing.Size(1796, 1051);
            this.SunPage.TabIndex = 0;
            this.SunPage.Text = "SunPage";
            this.SunPage.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Animated = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BorderRadius = 5;
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.ForeColor = System.Drawing.Color.Thistle;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.closeBtn.Location = new System.Drawing.Point(12, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(45, 29);
            this.closeBtn.TabIndex = 2;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.Animated = true;
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BorderRadius = 5;
            this.minimizeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeBtn.FillColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Thistle;
            this.minimizeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.minimizeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.minimizeBtn.HoverState.Parent = this.minimizeBtn;
            this.minimizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.minimizeBtn.Location = new System.Drawing.Point(87, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.ShadowDecoration.Parent = this.minimizeBtn;
            this.minimizeBtn.Size = new System.Drawing.Size(45, 29);
            this.minimizeBtn.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.mainWindowPages);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Solar Explorer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.mainWindowPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse mainWindowElipse;
        private System.Windows.Forms.Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Button sunBtn;
        private Bunifu.UI.WinForms.BunifuPages mainWindowPages;
        private System.Windows.Forms.TabPage SunPage;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBtn;
    }
}

