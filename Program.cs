using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace aspect_ratio_calculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            Controller controller = new Controller(model);
            View view = new View(controller);

            Application.Run(view);
        }
    }
}
