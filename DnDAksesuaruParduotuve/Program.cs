using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
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
            new Langai();
            new Duomenys();
        }
    }

    public class Langai
    {
        public static PrekiuLangas prekiuLangas = new PrekiuLangas();
        public static KrepselioLangas krepselioLangas = new KrepselioLangas();

        public Langai()
        {
            Application.Run(prekiuLangas);
            Application.Run(krepselioLangas);
        }
    }
}
