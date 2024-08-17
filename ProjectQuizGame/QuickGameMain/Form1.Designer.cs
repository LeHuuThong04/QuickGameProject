namespace QuickGameMain
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnPlayAgain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPlayerName.Location = new System.Drawing.Point(12, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(52, 16);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player: ";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.PaleGreen;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(72, 16);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question:";
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Location = new System.Drawing.Point(15, 70);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(82, 20);
            this.rbtnAnswer1.TabIndex = 2;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.Text = "Answer 1";
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Location = new System.Drawing.Point(15, 97);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(82, 20);
            this.rbtnAnswer2.TabIndex = 3;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.Text = "Answer 2";
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Location = new System.Drawing.Point(15, 124);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(82, 20);
            this.rbtnAnswer3.TabIndex = 4;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.Text = "Answer 3";
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Location = new System.Drawing.Point(15, 151);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(82, 20);
            this.rbtnAnswer4.TabIndex = 5;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.Text = "Answer 4";
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSubmit.Location = new System.Drawing.Point(15, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.MintCream;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(127, 153);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.LightCoral;
            this.lblScore.Location = new System.Drawing.Point(11, 250);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 16);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Scores:";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Pink;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.Location = new System.Drawing.Point(181, 179);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(110, 32);
            this.btnPlayAgain.TabIndex = 9;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(482, 321);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnAnswer4);
            this.Controls.Add(this.rbtnAnswer3);
            this.Controls.Add(this.rbtnAnswer2);
            this.Controls.Add(this.rbtnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnPlayAgain);
            this.Name = "Form1";
            this.Text = "QuizGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
