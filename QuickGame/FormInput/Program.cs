using System;
using System.Windows.Forms;

namespace QuickGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the FormInput to get the player's name
            Application.Run(new FormInput());
        }
    }
}
