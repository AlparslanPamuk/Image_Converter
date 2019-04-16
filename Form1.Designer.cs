namespace Image_Converter
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
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btngreyscale = new System.Windows.Forms.Button();
            this.btnblur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btninvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblBlur = new System.Windows.Forms.Label();
            this.LblBrightness = new System.Windows.Forms.Label();
            this.btnEmboss = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.lblContrast = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.lblGamma = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(12, 12);
            this.btnopen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(91, 34);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(108, 12);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 34);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(732, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif";
            // 
            // btngreyscale
            // 
            this.btngreyscale.Location = new System.Drawing.Point(204, 14);
            this.btngreyscale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngreyscale.Name = "btngreyscale";
            this.btngreyscale.Size = new System.Drawing.Size(91, 34);
            this.btngreyscale.TabIndex = 3;
            this.btngreyscale.Text = "Grey Scale";
            this.btngreyscale.UseVisualStyleBackColor = true;
            this.btngreyscale.Click += new System.EventHandler(this.btngreyscale_Click);
            // 
            // btnblur
            // 
            this.btnblur.Location = new System.Drawing.Point(301, 14);
            this.btnblur.Name = "btnblur";
            this.btnblur.Size = new System.Drawing.Size(86, 34);
            this.btnblur.TabIndex = 4;
            this.btnblur.Text = "Blur";
            this.btnblur.UseVisualStyleBackColor = true;
            this.btnblur.Click += new System.EventHandler(this.btnblur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Blur Level";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(89, 520);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(655, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btninvert
            // 
            this.btninvert.Location = new System.Drawing.Point(393, 14);
            this.btninvert.Name = "btninvert";
            this.btninvert.Size = new System.Drawing.Size(75, 34);
            this.btninvert.TabIndex = 7;
            this.btninvert.Text = "Invert";
            this.btninvert.UseVisualStyleBackColor = true;
            this.btninvert.Click += new System.EventHandler(this.btninvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Brightness";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(89, 559);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(655, 56);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.MouseCaptureChanged += new System.EventHandler(this.trackBar2_MouseCaptureChanged);
            // 
            // lblBlur
            // 
            this.lblBlur.AutoSize = true;
            this.lblBlur.Location = new System.Drawing.Point(750, 520);
            this.lblBlur.Name = "lblBlur";
            this.lblBlur.Size = new System.Drawing.Size(16, 17);
            this.lblBlur.TabIndex = 10;
            this.lblBlur.Text = "0";
            // 
            // LblBrightness
            // 
            this.LblBrightness.AutoSize = true;
            this.LblBrightness.Location = new System.Drawing.Point(750, 568);
            this.LblBrightness.Name = "LblBrightness";
            this.LblBrightness.Size = new System.Drawing.Size(16, 17);
            this.LblBrightness.TabIndex = 11;
            this.LblBrightness.Text = "0";
            // 
            // btnEmboss
            // 
            this.btnEmboss.Location = new System.Drawing.Point(474, 14);
            this.btnEmboss.Name = "btnEmboss";
            this.btnEmboss.Size = new System.Drawing.Size(75, 34);
            this.btnEmboss.TabIndex = 12;
            this.btnEmboss.Text = "Emboss";
            this.btnEmboss.UseVisualStyleBackColor = true;
            this.btnEmboss.Click += new System.EventHandler(this.btnEmboss_Click);
            // 
            // btnContrast
            // 
            this.btnContrast.AutoSize = true;
            this.btnContrast.Location = new System.Drawing.Point(12, 598);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(61, 17);
            this.btnContrast.TabIndex = 13;
            this.btnContrast.Text = "Contrast";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(93, 598);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(655, 56);
            this.trackBar3.TabIndex = 14;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Location = new System.Drawing.Point(750, 598);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(16, 17);
            this.lblContrast.TabIndex = 15;
            this.lblContrast.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 637);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gamma";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(93, 637);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(655, 56);
            this.trackBar4.TabIndex = 17;
            this.trackBar4.Value = 1;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(750, 637);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(16, 17);
            this.lblGamma.TabIndex = 18;
            this.lblGamma.Text = "0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 684);
            this.Controls.Add(this.lblGamma);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContrast);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.btnContrast);
            this.Controls.Add(this.btnEmboss);
            this.Controls.Add(this.LblBrightness);
            this.Controls.Add(this.lblBlur);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninvert);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnblur);
            this.Controls.Add(this.btngreyscale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btngreyscale;
        private System.Windows.Forms.Button btnblur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btninvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblBlur;
        private System.Windows.Forms.Label LblBrightness;
        private System.Windows.Forms.Button btnEmboss;
        private System.Windows.Forms.Label btnContrast;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label lblGamma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

