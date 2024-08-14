using System;
using System.Windows.Forms;

namespace QuickGame
{
    public partial class FormInput : Form
    {
        public string PlayerName { get; private set; }

        public FormInput()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            PlayerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrEmpty(PlayerName))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void FormInput_Load(object sender, EventArgs e)
        {
        }

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnStartGame;
    }
}
