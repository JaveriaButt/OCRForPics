namespace ocr_video
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
            this.result_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.extracttext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result_text
            // 
            this.result_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_text.Location = new System.Drawing.Point(493, 12);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(347, 449);
            this.result_text.TabIndex = 0;
            this.result_text.Text = "Extracted Text will appear here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ocr_video.Properties.Resources.demo_picture1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SelectFile
            // 
            this.SelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFile.Location = new System.Drawing.Point(38, 12);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(149, 35);
            this.SelectFile.TabIndex = 2;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.selectfiles);
            // 
            // extracttext
            // 
            this.extracttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extracttext.Location = new System.Drawing.Point(226, 12);
            this.extracttext.Name = "extracttext";
            this.extracttext.Size = new System.Drawing.Size(142, 35);
            this.extracttext.TabIndex = 3;
            this.extracttext.Text = "Extract Text";
            this.extracttext.UseVisualStyleBackColor = true;
            this.extracttext.Click += new System.EventHandler(this.extractText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 473);
            this.Controls.Add(this.extracttext);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result_text);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Button extracttext;

    }
}

