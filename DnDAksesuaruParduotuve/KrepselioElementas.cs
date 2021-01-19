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
                KrepselioLangas.krepselioElementai.Remove(this);
                Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                int i = Krepselis.IndexKrepselyje(preke);
                pavadinimas.Text = Duomenys.krepselis.Prekes[i].Pavadinimas;
                kiekis.Text = String.Format("{0}x", Duomenys.krepselis.Prekes[i].PasirinktasKiekis.ToString());
                kaina.Text = String.Format("{0:0.00} €", Duomenys.krepselis.Prekes[i].Kaina);
            }
        }

        public void minusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = Duomenys.prekes.IndexOf(preke);
            Duomenys.prekes[i].PasirinktasKiekis--;
        }

        public void plusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = Duomenys.prekes.IndexOf(preke);
            Duomenys.prekes[i].PasirinktasKiekis++;
        }
    }
}
