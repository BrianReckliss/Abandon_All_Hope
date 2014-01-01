namespace Abandon_All_Hope
{
    partial class ViewerForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.bGroupTagging = new System.Windows.Forms.GroupBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.rbtnNSFW = new System.Windows.Forms.RadioButton();
            this.rbtnSFW = new System.Windows.Forms.RadioButton();
            this.lblSafe = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnPrevImg = new System.Windows.Forms.Button();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.timerScroll = new System.Windows.Forms.Timer(this.components);
            this.panel1Tagging = new System.Windows.Forms.Panel();
            this.panel2Viewer = new System.Windows.Forms.Panel();
            this.bGroupTagging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.TabContainer.SuspendLayout();
            this.ViewTab.SuspendLayout();
            this.panel1Tagging.SuspendLayout();
            this.panel2Viewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(188, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // bGroupTagging
            // 
            this.bGroupTagging.Controls.Add(this.lblTags);
            this.bGroupTagging.Controls.Add(this.lblDir);
            this.bGroupTagging.Controls.Add(this.rbtnNSFW);
            this.bGroupTagging.Controls.Add(this.btnOpen);
            this.bGroupTagging.Controls.Add(this.rbtnSFW);
            this.bGroupTagging.Controls.Add(this.lblSafe);
            this.bGroupTagging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGroupTagging.Location = new System.Drawing.Point(0, 0);
            this.bGroupTagging.Name = "bGroupTagging";
            this.bGroupTagging.Size = new System.Drawing.Size(200, 468);
            this.bGroupTagging.TabIndex = 2;
            this.bGroupTagging.TabStop = false;
            this.bGroupTagging.Text = "Tagging:";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(11, 100);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 3;
            this.lblTags.Text = "Tags:";
            // 
            // lblDir
            // 
            this.lblDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(6, 446);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(64, 13);
            this.lblDir.TabIndex = 3;
            this.lblDir.Text = "(Directory...)";
            // 
            // rbtnNSFW
            // 
            this.rbtnNSFW.AutoSize = true;
            this.rbtnNSFW.Location = new System.Drawing.Point(104, 68);
            this.rbtnNSFW.Name = "rbtnNSFW";
            this.rbtnNSFW.Size = new System.Drawing.Size(57, 17);
            this.rbtnNSFW.TabIndex = 2;
            this.rbtnNSFW.Text = "NSFW";
            this.rbtnNSFW.UseVisualStyleBackColor = true;
            // 
            // rbtnSFW
            // 
            this.rbtnSFW.AutoSize = true;
            this.rbtnSFW.Checked = true;
            this.rbtnSFW.Location = new System.Drawing.Point(49, 68);
            this.rbtnSFW.Name = "rbtnSFW";
            this.rbtnSFW.Size = new System.Drawing.Size(49, 17);
            this.rbtnSFW.TabIndex = 1;
            this.rbtnSFW.TabStop = true;
            this.rbtnSFW.Text = "SFW";
            this.rbtnSFW.UseVisualStyleBackColor = true;
            // 
            // lblSafe
            // 
            this.lblSafe.AutoSize = true;
            this.lblSafe.Location = new System.Drawing.Point(11, 70);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(32, 13);
            this.lblSafe.TabIndex = 0;
            this.lblSafe.Text = "Safe:";
            // 
            // picBox1
            // 
            this.picBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox1.Location = new System.Drawing.Point(1, 3);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(682, 405);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 4;
            this.picBox1.TabStop = false;
            // 
            // TabContainer
            // 
            this.TabContainer.Controls.Add(this.ViewTab);
            this.TabContainer.Controls.Add(this.SearchTab);
            this.TabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabContainer.Location = new System.Drawing.Point(0, 0);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(690, 468);
            this.TabContainer.TabIndex = 5;
            // 
            // ViewTab
            // 
            this.ViewTab.Controls.Add(this.btnNextImg);
            this.ViewTab.Controls.Add(this.btnScale);
            this.ViewTab.Controls.Add(this.btnPrevImg);
            this.ViewTab.Controls.Add(this.picBox1);
            this.ViewTab.Location = new System.Drawing.Point(4, 22);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTab.Size = new System.Drawing.Size(682, 442);
            this.ViewTab.TabIndex = 0;
            this.ViewTab.Text = "View";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // btnNextImg
            // 
            this.btnNextImg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextImg.Location = new System.Drawing.Point(385, 411);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(75, 23);
            this.btnNextImg.TabIndex = 7;
            this.btnNextImg.Text = "Next >";
            this.btnNextImg.UseVisualStyleBackColor = true;
            this.btnNextImg.Click += new System.EventHandler(this.btnNextImg_Click);
            // 
            // btnScale
            // 
            this.btnScale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnScale.Location = new System.Drawing.Point(304, 411);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(75, 23);
            this.btnScale.TabIndex = 6;
            this.btnScale.Text = "Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnPrevImg
            // 
            this.btnPrevImg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevImg.Location = new System.Drawing.Point(223, 411);
            this.btnPrevImg.Name = "btnPrevImg";
            this.btnPrevImg.Size = new System.Drawing.Size(75, 23);
            this.btnPrevImg.TabIndex = 5;
            this.btnPrevImg.Text = "< Prev";
            this.btnPrevImg.UseVisualStyleBackColor = true;
            this.btnPrevImg.Click += new System.EventHandler(this.btnPrevImg_Click);
            // 
            // SearchTab
            // 
            this.SearchTab.Location = new System.Drawing.Point(4, 22);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(682, 442);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Search";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // timerScroll
            // 
            this.timerScroll.Interval = 200;
            this.timerScroll.Tick += new System.EventHandler(this.timerScroll_Tick);
            // 
            // panel1Tagging
            // 
            this.panel1Tagging.Controls.Add(this.bGroupTagging);
            this.panel1Tagging.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1Tagging.Location = new System.Drawing.Point(0, 0);
            this.panel1Tagging.Name = "panel1Tagging";
            this.panel1Tagging.Size = new System.Drawing.Size(200, 468);
            this.panel1Tagging.TabIndex = 6;
            // 
            // panel2Viewer
            // 
            this.panel2Viewer.Controls.Add(this.TabContainer);
            this.panel2Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2Viewer.Location = new System.Drawing.Point(200, 0);
            this.panel2Viewer.Name = "panel2Viewer";
            this.panel2Viewer.Size = new System.Drawing.Size(690, 468);
            this.panel2Viewer.TabIndex = 7;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 468);
            this.Controls.Add(this.panel2Viewer);
            this.Controls.Add(this.panel1Tagging);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ViewerForm";
            this.Text = "Image Viewer";
            this.bGroupTagging.ResumeLayout(false);
            this.bGroupTagging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.TabContainer.ResumeLayout(false);
            this.ViewTab.ResumeLayout(false);
            this.panel1Tagging.ResumeLayout(false);
            this.panel2Viewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.GroupBox bGroupTagging;
        public System.Windows.Forms.RadioButton rbtnNSFW;
        public System.Windows.Forms.RadioButton rbtnSFW;
        public System.Windows.Forms.Label lblSafe;
        public System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.PictureBox picBox1;
        public System.Windows.Forms.Label lblTags;
        public System.Windows.Forms.TabControl TabContainer;
        public System.Windows.Forms.TabPage ViewTab;
        public System.Windows.Forms.TabPage SearchTab;
        public System.Windows.Forms.Button btnNextImg;
        public System.Windows.Forms.Button btnScale;
        public System.Windows.Forms.Button btnPrevImg;
        public System.Windows.Forms.Timer timerScroll;
        public System.Windows.Forms.Panel panel1Tagging;
        public System.Windows.Forms.Panel panel2Viewer;
    }
}

