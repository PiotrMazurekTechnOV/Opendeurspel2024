
namespace OpendeurspelAPI
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
            this.Questions = new System.Windows.Forms.ListBox();
            this.Answers = new System.Windows.Forms.ListBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.GETquestions = new System.Windows.Forms.Button();
            this.GETanswers = new System.Windows.Forms.Button();
            this.GETlocations = new System.Windows.Forms.Button();
            this.GETusers = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.ListBox();
            this.Scorelistbx = new System.Windows.Forms.ListBox();
            this.GETscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Questions
            // 
            this.Questions.FormattingEnabled = true;
            this.Questions.Location = new System.Drawing.Point(62, 37);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(120, 95);
            this.Questions.TabIndex = 0;
            this.Questions.SelectedIndexChanged += new System.EventHandler(this.Questions_SelectedIndexChanged);
            // 
            // Answers
            // 
            this.Answers.FormattingEnabled = true;
            this.Answers.Location = new System.Drawing.Point(254, 37);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(120, 95);
            this.Answers.TabIndex = 1;
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.Location = new System.Drawing.Point(578, 37);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(210, 95);
            this.Users.TabIndex = 3;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // GETquestions
            // 
            this.GETquestions.Location = new System.Drawing.Point(62, 178);
            this.GETquestions.Name = "GETquestions";
            this.GETquestions.Size = new System.Drawing.Size(120, 23);
            this.GETquestions.TabIndex = 4;
            this.GETquestions.Text = "GETquestions";
            this.GETquestions.UseVisualStyleBackColor = true;
            this.GETquestions.Click += new System.EventHandler(this.GETquestions_Click);
            // 
            // GETanswers
            // 
            this.GETanswers.Location = new System.Drawing.Point(254, 178);
            this.GETanswers.Name = "GETanswers";
            this.GETanswers.Size = new System.Drawing.Size(120, 23);
            this.GETanswers.TabIndex = 5;
            this.GETanswers.Text = "GETanswers";
            this.GETanswers.UseVisualStyleBackColor = true;
            // 
            // GETlocations
            // 
            this.GETlocations.Location = new System.Drawing.Point(426, 178);
            this.GETlocations.Name = "GETlocations";
            this.GETlocations.Size = new System.Drawing.Size(120, 23);
            this.GETlocations.TabIndex = 6;
            this.GETlocations.Text = "GETlocations";
            this.GETlocations.UseVisualStyleBackColor = true;
            this.GETlocations.Click += new System.EventHandler(this.GETlocations_Click);
            // 
            // GETusers
            // 
            this.GETusers.Location = new System.Drawing.Point(578, 178);
            this.GETusers.Name = "GETusers";
            this.GETusers.Size = new System.Drawing.Size(210, 23);
            this.GETusers.TabIndex = 7;
            this.GETusers.Text = "GETusers";
            this.GETusers.UseVisualStyleBackColor = true;
            this.GETusers.Click += new System.EventHandler(this.GETusers_Click);
            // 
            // Location
            // 
            this.Location.FormattingEnabled = true;
            this.Location.Location = new System.Drawing.Point(426, 37);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(120, 95);
            this.Location.TabIndex = 8;
            // 
            // Scorelistbx
            // 
            this.Scorelistbx.FormattingEnabled = true;
            this.Scorelistbx.Location = new System.Drawing.Point(62, 229);
            this.Scorelistbx.Name = "Scorelistbx";
            this.Scorelistbx.Size = new System.Drawing.Size(292, 95);
            this.Scorelistbx.TabIndex = 9;
            // 
            // GETscore
            // 
            this.GETscore.Location = new System.Drawing.Point(62, 359);
            this.GETscore.Name = "GETscore";
            this.GETscore.Size = new System.Drawing.Size(292, 23);
            this.GETscore.TabIndex = 10;
            this.GETscore.Text = "GETscore";
            this.GETscore.UseVisualStyleBackColor = true;
            this.GETscore.Click += new System.EventHandler(this.GETscore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 828);
            this.Controls.Add(this.GETscore);
            this.Controls.Add(this.Scorelistbx);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.GETusers);
            this.Controls.Add(this.GETlocations);
            this.Controls.Add(this.GETanswers);
            this.Controls.Add(this.GETquestions);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.Questions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Questions;
        private System.Windows.Forms.ListBox Answers;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.Button GETquestions;
        private System.Windows.Forms.Button GETanswers;
        private System.Windows.Forms.Button GETlocations;
        private System.Windows.Forms.Button GETusers;
        private System.Windows.Forms.ListBox Location;
        private System.Windows.Forms.ListBox Scorelistbx;
        private System.Windows.Forms.Button GETscore;
    }
}

