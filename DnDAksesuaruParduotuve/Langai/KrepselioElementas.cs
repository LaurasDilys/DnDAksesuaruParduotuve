using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public partial class KrepselioElementas : UserControl
    {
        public KrepselioElementas(Preke preke)
        {
            InitializeComponent();
            this.preke = preke;
        }

        private Preke preke;

        public void Elementas_Update()
        {
            if (preke.PasirinktasKiekis == 0)
            {
                Langai.KrepselioLangas.KrepselioElementai.Remove(this);
                Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                if (nuotrauka.Image == null)
                {
                    int i = Duomenys.Prekes.IndexOf(preke);
                    Image image = Langai.PrekiuLangas.Nuotraukos[i].Image;
                    nuotrauka.AtvaizduotiNuotraukaKrepselyje(image);
                }
                pavadinimas.Text = preke.Pavadinimas;
                kiekis.Text = String.Format("{0}x", preke.PasirinktasKiekis.ToString());
                kaina.Text = String.Format("{0:0.00} €", preke.Kaina);
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            preke.PasirinktasKiekis--;
            Langai.KrepselioLangas.SiuntosInfo_Update();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (preke.PasirinktasKiekis < preke.TurimasKiekis)
            {
                preke.PasirinktasKiekis++;
                Langai.KrepselioLangas.SiuntosInfo_Update();
            }
            else daugiauNeturime.Show("Šiuo metu daugiau neturime", (Button)sender);
        }
    }
}
