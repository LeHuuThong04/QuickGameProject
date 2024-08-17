using System;
using System.Windows.Forms;

namespace QuickGameMain
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Server.ServerForm formServer = new Server.ServerForm();
            formServer.Show();

            Application.Run(new Form1("Player1", formServer)); // Thay "Player1" bằng tên người chơi thật sự
        }
    }
}
