
using System;
using System.Windows.Forms;

namespace Tsp
{
    /// <summary>
    /// Main 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// entry point 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TspForm());
        }
    }
}
