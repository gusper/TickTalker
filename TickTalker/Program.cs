using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TickTalker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var mf = new MainForm();
            Application.Run();
        }
    }
}
