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
                nuotrauka.AtvaizduotiNuotraukaCentre(preke.PrekeId);
                pavadinimas.Text = preke.Pavadinimas;
                kiekis.Text = String.Format("{0}x", preke.PasirinktasKiekis.ToString());
                kaina.Text = String.Format("{0:0.00} €", preke.Kaina);
            }
        }

        public void minusButton_Click(object sender, EventArgs e)
        {
            preke.PasirinktasKiekis--;
            krepselioLangas.SiuntosInfo_Update();
        }

        public void plusButton_Click(object sender, EventArgs e)
        {
            preke.PasirinktasKiekis++;
            krepselioLangas.SiuntosInfo_Update();
        }
    }
}
