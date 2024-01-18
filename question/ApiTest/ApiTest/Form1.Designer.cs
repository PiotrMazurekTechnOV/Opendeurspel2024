namespace ApiTest
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
            this.testBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.locationTestBtn = new System.Windows.Forms.Button();
            this.questionsLstBx = new System.Windows.Forms.ListBox();
            this.answersLstBx = new System.Windows.Forms.ListBox();
            this.answerBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(38, 157);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(120, 23);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "Get Questions";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(578, 37);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(153, 23);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add test user";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // locationTestBtn
            // 
            this.locationTestBtn.Location = new System.Drawing.Point(618, 361);
            this.locationTestBtn.Name = "locationTestBtn";
            this.locationTestBtn.Size = new System.Drawing.Size(75, 23);
            this.locationTestBtn.TabIndex = 2;
            this.locationTestBtn.Text = "button1";
            this.locationTestBtn.UseVisualStyleBackColor = true;
            this.locationTestBtn.Click += new System.EventHandler(this.locationTestBtn_Click);
            // 
            // questionsLstBx
            // 
            this.questionsLstBx.FormattingEnabled = true;
            this.questionsLstBx.ItemHeight = 16;
            this.questionsLstBx.Location = new System.Drawing.Point(38, 67);
            this.questionsLstBx.Name = "questionsLstBx";
            this.questionsLstBx.Size = new System.Drawing.Size(120, 84);
            this.questionsLstBx.TabIndex = 3;
            this.questionsLstBx.SelectedIndexChanged += new System.EventHandler(this.questionsLstBx_SelectedIndexChanged);
            // 
            // answersLstBx
            // 
            this.answersLstBx.FormattingEnabled = true;
            this.answersLstBx.ItemHeight = 16;
            this.answersLstBx.Location = new System.Drawing.Point(215, 67);
            this.answersLstBx.Name = "answersLstBx";
            this.answersLstBx.Size = new System.Drawing.Size(120, 84);
            this.answersLstBx.TabIndex = 5;
            this.answersLstBx.SelectedIndexChanged += new System.EventHandler(this.answersLstBx_SelectedIndexChanged);
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(215, 157);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(120, 23);
            this.answerBtn.TabIndex = 4;
            this.answerBtn.Text = "Get answers";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.answersLstBx);
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.questionsLstBx);
            this.Controls.Add(this.locationTestBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.testBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button locationTestBtn;
        private System.Windows.Forms.ListBox questionsLstBx;
        private System.Windows.Forms.ListBox answersLstBx;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

