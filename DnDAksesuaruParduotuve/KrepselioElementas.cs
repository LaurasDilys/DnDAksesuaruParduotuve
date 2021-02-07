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
        public KrepselioElementas(Preke preke, KrepselioLangas krepselioLangas)
        {
            InitializeComponent();
            this.preke = preke;
            this.krepselioLangas = krepselioLangas;
        }

        private Preke preke;
        private KrepselioLangas krepselioLangas;

        public void Elementas_Update()
        {
            if (preke.PasirinktasKiekis == 0)
            {
                KrepselioLangas.krepselioElementai.Remove(this);
                Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                int i = Krepselis.IndexKrepselyje(preke);
                nuotrauka.AtvaizduotiNuotraukaViduryje(Duomenys.Krepselis.Prekes[i].PrekeId);
                pavadinimas.Text = Duomenys.Krepselis.Prekes[i].Pavadinimas;
                kiekis.Text = String.Format("{0}x", Duomenys.Krepselis.Prekes[i].PasirinktasKiekis.ToString());
                kaina.Text = String.Format("{0:0.00} €", Duomenys.Krepselis.Prekes[i].Kaina);
            }
        }

        public void minusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = Duomenys.Prekes.IndexOf(preke);
            Duomenys.Prekes[i].PasirinktasKiekis--;
            krepselioLangas.SiuntosInfo_Update();
        }

        public void plusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = Duomenys.Prekes.IndexOf(preke);
            Duomenys.Prekes[i].PasirinktasKiekis++;
            krepselioLangas.SiuntosInfo_Update();
        }
    }
}
