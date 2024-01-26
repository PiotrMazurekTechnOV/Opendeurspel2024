namespace Question_Opendeurspel
{
    partial class Form2
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
            this.cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            this.EnterBtn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Question_Opendeurspel.Properties.Resources.Purple_and_Green_Modern_ICT_Computer_Parts_Classroom_Quiz__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cyberTextBox1
            // 
            this.cyberTextBox1.Alpha = 20;
            this.cyberTextBox1.AutoScroll = true;
            this.cyberTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.cyberTextBox1.Background_WidthPen = 3F;
            this.cyberTextBox1.BackgroundPen = true;
            this.cyberTextBox1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberTextBox1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberTextBox1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberTextBox1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberTextBox1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberTextBox1.Font = new System.Drawing.Font("Arial", 8F);
            this.cyberTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberTextBox1.Lighting = false;
            this.cyberTextBox1.LinearGradientPen = false;
            this.cyberTextBox1.Location = new System.Drawing.Point(355, 221);
            this.cyberTextBox1.Name = "cyberTextBox1";
            this.cyberTextBox1.PenWidth = 15;
            this.cyberTextBox1.RGB = true;
            this.cyberTextBox1.Rounding = true;
            this.cyberTextBox1.RoundingInt = 60;
            this.cyberTextBox1.Size = new System.Drawing.Size(96, 34);
            this.cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberTextBox1.TabIndex = 3;
            this.cyberTextBox1.Tag = "Cyber";
            this.cyberTextBox1.TextButton = "";
            this.cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberTextBox1.Timer_RGB = 300;
            this.cyberTextBox1.Load += new System.EventHandler(this.cyberTextBox1_Load);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.Transparent;
            this.EnterBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EnterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterBtn.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.EnterBtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnterBtn.Image = null;
            this.EnterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnterBtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.EnterBtn.Location = new System.Drawing.Point(355, 274);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.EnterBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.EnterBtn.Size = new System.Drawing.Size(107, 37);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.cyberTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.Button EnterBtn;
    }
}