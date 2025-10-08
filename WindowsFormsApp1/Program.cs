using System;
using System.Windows.Forms;
using WindowsFormsApp1.UI; // 👈 IMPORTANTE

namespace WindowsFormsApp1
{       
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LangileForm()); // 👈 El form que quieras abrir
        }
    }
}

