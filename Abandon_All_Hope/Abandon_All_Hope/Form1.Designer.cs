namespace Abandon_All_Hope
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.bGroupTagging = new System.Windows.Forms.GroupBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.rbtnNSFW = new System.Windows.Forms.RadioButton();
            this.rbtnSFW = new System.Windows.Forms.RadioButton();
            this.lblSafe = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.bGroupTagging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabContainer.SuspendLayout();
            this.ViewTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 41);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // bGroupTagging
            // 
            this.bGroupTagging.Controls.Add(this.lblTags);
            this.bGroupTagging.Controls.Add(this.rbtnNSFW);
            this.bGroupTagging.Controls.Add(this.btnOpen);
            this.bGroupTagging.Controls.Add(this.rbtnSFW);
            this.bGroupTagging.Controls.Add(this.lblSafe);
            this.bGroupTagging.Location = new System.Drawing.Point(574, 5);
            this.bGroupTagging.Name = "bGroupTagging";
            this.bGroupTagging.Size = new System.Drawing.Size(205, 553);
            this.bGroupTagging.TabIndex = 2;
            this.bGroupTagging.TabStop = false;
            this.bGroupTagging.Text = "Tagging:";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(5, 153);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 3;
            this.lblTags.Text = "Tags:";
            // 
            // rbtnNSFW
            // 
            this.rbtnNSFW.AutoSize = true;
            this.rbtnNSFW.Location = new System.Drawing.Point(114, 18);
            this.rbtnNSFW.Name = "rbtnNSFW";
            this.rbtnNSFW.Size = new System.Drawing.Size(57, 17);
            this.rbtnNSFW.TabIndex = 2;
            this.rbtnNSFW.TabStop = true;
            this.rbtnNSFW.Text = "NSFW";
            this.rbtnNSFW.UseVisualStyleBackColor = true;
            // 
            // rbtnSFW
            // 
            this.rbtnSFW.AutoSize = true;
            this.rbtnSFW.Location = new System.Drawing.Point(59, 18);
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
            this.lblSafe.Location = new System.Drawing.Point(7, 20);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(32, 13);
            this.lblSafe.TabIndex = 0;
            this.lblSafe.Text = "Safe:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(5, 544);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(64, 13);
            this.lblDir.TabIndex = 3;
            this.lblDir.Text = "(Directory...)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Open File";
            // 
            // TabContainer
            // 
            this.TabContainer.Controls.Add(this.ViewTab);
            this.TabContainer.Controls.Add(this.SearchTab);
            this.TabContainer.Location = new System.Drawing.Point(8, 12);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(551, 546);
            this.TabContainer.TabIndex = 5;
            // 
            // ViewTab
            // 
            this.ViewTab.Controls.Add(this.pictureBox1);
            this.ViewTab.Location = new System.Drawing.Point(4, 22);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTab.Size = new System.Drawing.Size(543, 520);
            this.ViewTab.TabIndex = 0;
            this.ViewTab.Text = "View";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // SearchTab
            // 
            this.SearchTab.Location = new System.Drawing.Point(4, 22);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(543, 520);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Search";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.TabContainer);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.bGroupTagging);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bGroupTagging.ResumeLayout(false);
            this.bGroupTagging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabContainer.ResumeLayout(false);
            this.ViewTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox bGroupTagging;
        private System.Windows.Forms.RadioButton rbtnNSFW;
        private System.Windows.Forms.RadioButton rbtnSFW;
        private System.Windows.Forms.Label lblSafe;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TabControl TabContainer;
        private System.Windows.Forms.TabPage ViewTab;
        private System.Windows.Forms.TabPage SearchTab;
    }
}

