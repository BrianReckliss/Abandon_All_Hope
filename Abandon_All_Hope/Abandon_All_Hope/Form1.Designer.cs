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
            this.btnSearch = new System.Windows.Forms.Button();
            this.bGroupTagging = new System.Windows.Forms.GroupBox();
            this.lblSafe = new System.Windows.Forms.Label();
            this.rbtnSFW = new System.Windows.Forms.RadioButton();
            this.rbtnNSFW = new System.Windows.Forms.RadioButton();
            this.lblDir = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTags = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bGroupTagging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(5, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(86, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // bGroupTagging
            // 
            this.bGroupTagging.Controls.Add(this.button3);
            this.bGroupTagging.Controls.Add(this.button2);
            this.bGroupTagging.Controls.Add(this.button1);
            this.bGroupTagging.Controls.Add(this.lblTags);
            this.bGroupTagging.Controls.Add(this.rbtnNSFW);
            this.bGroupTagging.Controls.Add(this.rbtnSFW);
            this.bGroupTagging.Controls.Add(this.lblSafe);
            this.bGroupTagging.Location = new System.Drawing.Point(574, 5);
            this.bGroupTagging.Name = "bGroupTagging";
            this.bGroupTagging.Size = new System.Drawing.Size(205, 553);
            this.bGroupTagging.TabIndex = 2;
            this.bGroupTagging.TabStop = false;
            this.bGroupTagging.Text = "Tagging:";
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
            this.pictureBox1.Location = new System.Drawing.Point(5, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Open File";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(10, 62);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 3;
            this.lblTags.Text = "Tags:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.bGroupTagging);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bGroupTagging.ResumeLayout(false);
            this.bGroupTagging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox bGroupTagging;
        private System.Windows.Forms.RadioButton rbtnNSFW;
        private System.Windows.Forms.RadioButton rbtnSFW;
        private System.Windows.Forms.Label lblSafe;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTags;
    }
}

