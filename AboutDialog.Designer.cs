namespace _3DPatternMaker
{
    partial class AboutDialog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3DPatternMaker.Properties.Resources.selfie;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Location = new System.Drawing.Point(163, 9);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(35, 13);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "label1";
            // 
            // VendorLabel
            // 
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Location = new System.Drawing.Point(163, 35);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(35, 13);
            this.VendorLabel.TabIndex = 2;
            this.VendorLabel.Text = "label2";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(163, 22);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(35, 13);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "label3";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(163, 280);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(159, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "Thanks Cutie!";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(163, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 225);
            this.listBox1.TabIndex = 5;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 306);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.VendorLabel);
            this.Controls.Add(this.AppNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AboutDialog";
            this.Text = "AboutDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}