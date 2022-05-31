using System;
using System.Windows.Forms;

namespace Kpsboard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run from Intercept method
            InterceptKeys.Intercept();
        }
    }
}