using System;
using System.Windows.Forms;
using QuickGameMain;
using Server;

namespace QuickGameStart
{
    public partial class FormStart : Form
    {
        private Server.ServerForm formServer; // Tham chiếu tới FormServer

        public FormStart()
        {
            InitializeComponent();
            formServer = new Server.ServerForm(); // Khởi tạo FormServer
            formServer.Show(); // Hiển thị FormServer
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }
            QuickGameMain.Form1 mainForm = new QuickGameMain.Form1(playerName, formServer); // Truyền FormServer vào Form1
            mainForm.Show();
            this.Hide();
        }
    }
}
