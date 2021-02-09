using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public partial class PardavimoLangas : Form
    {
        public PardavimoLangas(string adresas)
        {
            InitializeComponent();
            infoTekstas = new List<string>()
            {
                "Dėkojame, kad apsipirkote mūsų parduotuvėje!",
                Environment.NewLine, Environment.NewLine,
                $"Siunta bus prisatyta adresu: {adresas}",
                Environment.NewLine, Environment.NewLine,
                "Ar norite grįžti į parduotuvę?"
            };
            infoLabel.Text = string.Join("", infoTekstas);
        }

        private List<string> infoTekstas;

        private void DndLogo_MouseEnter(object sender, EventArgs e)
        {
            AksesuaraiLogo.ForeColor = SystemColors.Highlight;
        }

        private void DndLogo_MouseLeave(object sender, EventArgs e)
        {
            AksesuaraiLogo.ForeColor = SystemColors.ControlText;
        }

        private void Grizti(object sender, EventArgs e)
        {
            infoTekstas[^1] = "Prašome palaukti...";
            infoLabel.Text = string.Join("", infoTekstas);
            Duomenys.Prekes = ManageDb.NuskaitytiPrekes();
            Duomenys.Krepselis = new Krepselis();
            Langai.KrepselioLangas = new KrepselioLangas();
            Langai.PrekiuLangas = new PrekiuLangas();
            Langai.PrekiuLangas.Show();
            this.Dispose();
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
