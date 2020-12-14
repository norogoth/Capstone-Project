using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.InitializePitchers();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            double[] testList = new double[] { 9, 2, 5, 4, 12, 7, 8, 11, 9, 3, 7, 4, 12, 5, 4, 10, 9, 6, 9, 4 };
            Console.WriteLine("test");
            Pitcher.StdDev(testList);
            Application.Run(new SearchForm());
            

        }

    }
}
