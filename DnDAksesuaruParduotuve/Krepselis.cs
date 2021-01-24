using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Krepselis
    {
        public Krepselis()
        {
            Prekes = new List<Preke>();
            PrekiuKiekis = 0;
            PrekiuKaina = 0;
            PrekiuSvoris = 0;
        }

        public List<Preke> Prekes { get; set; }
        public int PrekiuKiekis { get; private set; }
        public double PrekiuKaina { get; private set; }
        public double PrekiuSvoris { get; private set; }

        public void Atimti(Preke preke)
        {
            PrekiuKiekis--;
            PrekiuKaina -= preke.Kaina;
            PrekiuSvoris -= preke.Svoris;
            Langai.krepselioLangas.KrepselioPanel_Update(preke);
            if (preke.PasirinktasKiekis == 0) { Prekes.Remove(preke); }
            KrepselioLogo_Update();
        }

        public void Prideti(Preke preke)
        {
            PrekiuKiekis++;
            PrekiuKaina += preke.Kaina;
            PrekiuSvoris += preke.Svoris;
            //Svarbu, kad prekė pirmiuasia būtų įtraukta į "krepselis.Prekes",
            //kadangi toliua bus atliekamas palyginimas (Duomenys.krepselis.Prekes.Count > krepselioElementai.Count)
            if (!Prekes.Contains(preke)) { Prekes.Add(preke); }
            Langai.krepselioLangas.KrepselioPanel_Update(preke);
            KrepselioLogo_Update();
        }

        public void KrepselioLogo_Update()
        {
            Langai.prekiuLangas.PasirinktuPrekiuKiekis.Text = PrekiuKiekis.ToString();
            Langai.prekiuLangas.PasirinktuPrekiuKaina.Text = string.Format("{0:0.00} €", PrekiuKaina);

            Langai.krepselioLangas.PasirinktuPrekiuKiekis.Text = PrekiuKiekis.ToString();
            Langai.krepselioLangas.PasirinktuPrekiuKaina.Text = string.Format("{0:0.00} €", PrekiuKaina);
        }

        public static int IndexKrepselyje(Preke preke)
        {
            int i = Duomenys.krepselis.Prekes.IndexOf(preke);
            return i;
        }
    }
}
