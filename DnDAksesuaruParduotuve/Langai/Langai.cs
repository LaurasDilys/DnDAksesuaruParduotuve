using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public class Langai
    {
        public Langai()
        {
            Application.Run(PrekiuLangas);
        }

        public static PrekiuLangas PrekiuLangas = new PrekiuLangas();
        public static KrepselioLangas KrepselioLangas = new KrepselioLangas();

        public static void FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
