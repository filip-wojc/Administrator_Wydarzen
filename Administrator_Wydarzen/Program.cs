using Administrator_Wydarzen.Views;
using Administrator_Wydarzen.Models;
using Administrator_Wydarzen.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator_Wydarzen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IWydarzenieView view = new Form1();
            IWydarzenieRepository repository = new WydarzenieRepository();
            new WydarzeniePresenter(view, repository);
            Application.Run((Form) view);
        }
    }
}
