namespace QuickGame
{
    partial class FormInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; othenamespace QuickGame
    }
    partial class FormInput
        {
            private System.ComponentModel.IContainer components = null;

            // Controls used in the form
            private System.Windows.Forms.Label lblEnterName;
            private System.Windows.Forms.TextBox txtPlayerName;
            private System.Windows.Forms.Button btnStartGame;

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
                this.lblEnterName = new System.Windows.Forms.Label();
                this.txtPlayerName = new System.Windows.Forms.TextBox();
                this.btnStartGame = new System.Windows.Forms.Button();
                this.SuspendLayout();

                // 
                // lblEnterName
                // 
                this.lblEnterName.AutoSize = true;
                this.lblEnterName.Location = new System.Drawing.Point(30, 30);
                this.lblEnterName.Name = "lblEnterName";
                this.lblEnterName.Size = new System.Drawing.Size(158, 20);
                this.lblEnterName.TabIndex = 0;
                this.lblEnterName.Text = "Enter Player's Name:";

                // 
                // txtPlayerName
                // 
                this.txtPlayerName.Location = new System.Drawing.Point(30, 60);
                this.txtPlayerName.Name = "txtPlayerName";
                this.txtPlayerName.Size = new System.Drawing.Size(200, 26);
                this.txtPlayerName.TabIndex = 1;

                // 
                // btnStartGame
                // 
                this.btnStartGame.Location = new System.Drawing.Point(30, 100);
                this.btnStartGame.Name = "btnStartGame";
                this.btnStartGame.Size = new System.Drawing.Size(100, 30);
                this.btnStartGame.TabIndex = 2;
                this.btnStartGame.Text = "Start Game";
                this.btnStartGame.UseVisualStyleBackColor = true;
                this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);

                // 
                // FormInput
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(300, 150);
                this.Controls.Add(this.btnStartGame);
                this.Controls.Add(this.txtPlayerName);
                this.Controls.Add(this.lblEnterName);
                this.Name = "FormInput";
                this.Text = "Enter Name";
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }
    wise, false.</param>
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
        this.SuspendLayout();
        // 
        // FormInput
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Name = "FormInput";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.FormInput_Load);
        this.ResumeLayout(false);

    }

    #endregion
}
}

