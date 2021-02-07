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

        public static PrekiuLangas PrekiuLangas { get; set; } = new PrekiuLangas();
        public static KrepselioLangas KrepselioLangas { get; set; } = new KrepselioLangas();

        public static void Exit()
        {
            Application.Exit();
        }
    }
}
