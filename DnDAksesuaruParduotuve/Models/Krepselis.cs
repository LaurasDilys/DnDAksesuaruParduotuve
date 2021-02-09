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
            Langai.KrepselioLangas.KrepselioPanel_Update(preke);
            if (preke.PasirinktasKiekis == 0) { Prekes.Remove(preke); }
            KrepselioLogo_Update();
            Langai.KrepselioLangas.SiuntosInfo_Update();
        }

        public void Prideti(Preke preke)
        {
            PrekiuKiekis++;
            PrekiuKaina += preke.Kaina;
            PrekiuSvoris += preke.Svoris;
            //Svarbu, kad prekė pirmiuasia būtų įtraukta į "krepselis.Prekes",
            //kadangi toliua bus atliekamas palyginimas (Duomenys.krepselis.Prekes.Count > krepselioElementai.Count)
            if (!Prekes.Contains(preke)) { Prekes.Add(preke); }
            Langai.KrepselioLangas.KrepselioPanel_Update(preke);
            KrepselioLogo_Update();
            Langai.KrepselioLangas.SiuntosInfo_Update();
        }

        public void KrepselioLogo_Update()
        {
            Langai.PrekiuLangas.PasirinktuPrekiuKiekis.Text = PrekiuKiekis.ToString();
            Langai.PrekiuLangas.PasirinktuPrekiuKaina.Text = string.Format("{0:0.00} €", PrekiuKaina);

            Langai.KrepselioLangas.PasirinktuPrekiuKiekis.Text = PrekiuKiekis.ToString();
            Langai.KrepselioLangas.PasirinktuPrekiuKaina.Text = string.Format("{0:0.00} €", PrekiuKaina);
        }
    }
}
