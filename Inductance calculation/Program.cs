using System;
using System.Windows.Forms;

namespace Inductance_calculation
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inductance_calculation_form());
            //Application.Run(new Graphs_inductanc_form());
        }
    }
}
