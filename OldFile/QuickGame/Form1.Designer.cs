namespace QuickGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.Label();
            this.resume = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(30, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(60, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Location = new System.Drawing.Point(75, 70);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(79, 20);
            this.rbtnAnswer1.TabIndex = 1;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.Text = "Answer1";
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Location = new System.Drawing.Point(75, 100);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(79, 20);
            this.rbtnAnswer2.TabIndex = 2;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.Text = "Answer2";
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Location = new System.Drawing.Point(75, 130);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(79, 20);
            this.rbtnAnswer3.TabIndex = 3;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.Text = "Answer3";
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Location = new System.Drawing.Point(75, 160);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(79, 20);
            this.rbtnAnswer4.TabIndex = 4;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.Text = "Answer4";
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(287, 210);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(304, 258);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(284, 290);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(97, 16);
            this.lblCorrectAnswer.TabIndex = 7;
            this.lblCorrectAnswer.Text = "Correct Answer";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(15, 15);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(53, 16);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level: 1";
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.Location = new System.Drawing.Point(287, 157);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(75, 23);
            this.btnNextLevel.TabIndex = 9;
            this.btnNextLevel.Text = "Next Level";
            this.btnNextLevel.UseVisualStyleBackColor = true;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // messages
            // 
            this.messages.AutoSize = true;
            this.messages.Location = new System.Drawing.Point(291, 210);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(71, 16);
            this.messages.TabIndex = 6;
            this.messages.Text = "messages";
            //
            //resume
            //
            this.resume.Location = new System.Drawing.Point(287, 157);
            this.resume.Name = "btnresume";
            this.resume.Size = new System.Drawing.Size(75, 23);
            this.resume.TabIndex = 9;
            this.resume.Text = "resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.btnNextLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnAnswer4);
            this.Controls.Add(this.rbtnAnswer3);
            this.Controls.Add(this.rbtnAnswer2);
            this.Controls.Add(this.rbtnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.score);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Label score;
    }
}
