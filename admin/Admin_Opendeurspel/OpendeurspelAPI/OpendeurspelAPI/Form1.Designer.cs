
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
            this.components = new System.ComponentModel.Container();
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
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.Adduser = new System.Windows.Forms.Button();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.interest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Consentbx = new System.Windows.Forms.CheckBox();
            this.Vraagbx = new System.Windows.Forms.TextBox();
            this.location_idbx = new System.Windows.Forms.TextBox();
            this.Addquestionbttn = new System.Windows.Forms.Button();
            this.answertxtbx = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.questionidtxtbx = new System.Windows.Forms.TextBox();
            this.correcttxtbx = new System.Windows.Forms.TextBox();
            this.AddanswerBtn = new System.Windows.Forms.Button();
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
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(62, 601);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(100, 20);
            this.firstNametxt.TabIndex = 11;
            // 
            // lastNametxt
            // 
            this.lastNametxt.Location = new System.Drawing.Point(206, 601);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(100, 20);
            this.lastNametxt.TabIndex = 12;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(778, 601);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 13;
            // 
            // Adduser
            // 
            this.Adduser.Location = new System.Drawing.Point(177, 697);
            this.Adduser.Name = "Adduser";
            this.Adduser.Size = new System.Drawing.Size(146, 23);
            this.Adduser.TabIndex = 14;
            this.Adduser.Text = "Add an user";
            this.Adduser.UseVisualStyleBackColor = true;
            this.Adduser.Click += new System.EventHandler(this.Adduser_Click);
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(446, 601);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 20);
            this.agetxt.TabIndex = 15;
            // 
            // interest
            // 
            this.interest.Location = new System.Drawing.Point(626, 601);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(100, 20);
            this.interest.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-mail";
            // 
            // Consentbx
            // 
            this.Consentbx.AutoSize = true;
            this.Consentbx.Location = new System.Drawing.Point(331, 604);
            this.Consentbx.Name = "Consentbx";
            this.Consentbx.Size = new System.Drawing.Size(65, 17);
            this.Consentbx.TabIndex = 24;
            this.Consentbx.Text = "Consent";
            this.Consentbx.UseVisualStyleBackColor = true;
            // 
            // Vraagbx
            // 
            this.Vraagbx.Location = new System.Drawing.Point(861, 37);
            this.Vraagbx.Name = "Vraagbx";
            this.Vraagbx.Size = new System.Drawing.Size(100, 20);
            this.Vraagbx.TabIndex = 25;
            // 
            // location_idbx
            // 
            this.location_idbx.Location = new System.Drawing.Point(991, 37);
            this.location_idbx.Name = "location_idbx";
            this.location_idbx.Size = new System.Drawing.Size(100, 20);
            this.location_idbx.TabIndex = 26;
            // 
            // Addquestionbttn
            // 
            this.Addquestionbttn.Location = new System.Drawing.Point(861, 109);
            this.Addquestionbttn.Name = "Addquestionbttn";
            this.Addquestionbttn.Size = new System.Drawing.Size(230, 23);
            this.Addquestionbttn.TabIndex = 27;
            this.Addquestionbttn.Text = "Add question";
            this.Addquestionbttn.UseVisualStyleBackColor = true;
            this.Addquestionbttn.Click += new System.EventHandler(this.Addquestionbttn_Click);
            // 
            // answertxtbx
            // 
            this.answertxtbx.Location = new System.Drawing.Point(726, 362);
            this.answertxtbx.Name = "answertxtbx";
            this.answertxtbx.Size = new System.Drawing.Size(100, 20);
            this.answertxtbx.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // questionidtxtbx
            // 
            this.questionidtxtbx.Location = new System.Drawing.Point(861, 359);
            this.questionidtxtbx.Name = "questionidtxtbx";
            this.questionidtxtbx.Size = new System.Drawing.Size(100, 20);
            this.questionidtxtbx.TabIndex = 29;
            // 
            // correcttxtbx
            // 
            this.correcttxtbx.Location = new System.Drawing.Point(991, 362);
            this.correcttxtbx.Name = "correcttxtbx";
            this.correcttxtbx.Size = new System.Drawing.Size(100, 20);
            this.correcttxtbx.TabIndex = 30;
            // 
            // AddanswerBtn
            // 
            this.AddanswerBtn.Location = new System.Drawing.Point(877, 444);
            this.AddanswerBtn.Name = "AddanswerBtn";
            this.AddanswerBtn.Size = new System.Drawing.Size(75, 23);
            this.AddanswerBtn.TabIndex = 31;
            this.AddanswerBtn.Text = "Add answer";
            this.AddanswerBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 828);
            this.Controls.Add(this.AddanswerBtn);
            this.Controls.Add(this.correcttxtbx);
            this.Controls.Add(this.questionidtxtbx);
            this.Controls.Add(this.answertxtbx);
            this.Controls.Add(this.Addquestionbttn);
            this.Controls.Add(this.location_idbx);
            this.Controls.Add(this.Vraagbx);
            this.Controls.Add(this.Consentbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.Adduser);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.firstNametxt);
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button Adduser;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox interest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Consentbx;
        private System.Windows.Forms.TextBox Vraagbx;
        private System.Windows.Forms.TextBox location_idbx;
        private System.Windows.Forms.Button Addquestionbttn;
        private System.Windows.Forms.TextBox answertxtbx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox questionidtxtbx;
        private System.Windows.Forms.TextBox correcttxtbx;
        private System.Windows.Forms.Button AddanswerBtn;
    }
}

