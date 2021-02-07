using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public partial class PardavimoLangas : Form
    {
        public PardavimoLangas(string adresas)
        {
            InitializeComponent();
            pardavimoInfo.Text = $"Dėkojame, kad apsipirkote mūsų parduotuvėje!\n\nSiunta bus prisatyta adresu: {adresas}\n\nAr norite grįžti į parduotuvę?";
        }

        private void Grizti(object sender, EventArgs e)
        {
            Duomenys.NuskaitytiPrekes();
            Duomenys.Krepselis = new Krepselis();
            Langai.KrepselioLangas = new KrepselioLangas();
            Langai.PrekiuLangas = new PrekiuLangas();
            Langai.PrekiuLangas.Show();
            this.Hide();
        }

        private void Iseiti(object sender, EventArgs e)
        {
            Langai.Exit();
        }

        private void PardavimoLangas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Langai.Exit();
        }
    }
}
