namespace Server
{
    partial class ServerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstScores;

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
            this.lstScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 16;
            this.lstScores.Location = new System.Drawing.Point(12, 12);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(260, 212);
            this.lstScores.TabIndex = 0;
            this.lstScores.SelectedIndexChanged += new System.EventHandler(this.lstScores_SelectedIndexChanged);
            // 
            // ServerForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstScores);
            this.Name = "ServerForm";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.FormServer_Load); // Đổi thành phương thức hợp lệ
            this.ResumeLayout(false);
        }

    }
}
