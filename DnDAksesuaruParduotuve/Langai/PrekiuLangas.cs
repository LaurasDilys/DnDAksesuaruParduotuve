using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public partial class PrekiuLangas : Form
    {
        public PrekiuLangas()
        {
            InitializeComponent();
            AtvaizduotiKontroles();
            AtvaizduotiPrekes();
        }

        private List<PictureBox> nuotraukos = new List<PictureBox>();
        private List<Label> kategorijos = new List<Label>();
        private List<Label> pavadinimai = new List<Label>();
        private List<Button> minusButtons = new List<Button>();
        private List<Button> plusButtons = new List<Button>();
        private List<Label> kainos = new List<Label>();
        private List<Label> infoApieKiekius = new List<Label>();
        public List<Label> PasirinktiKiekiai { get; set; } = new List<Label>();

        public void AtvaizduotiKontroles()
        {
            for (int i = 0; i < Duomenys.Prekes.Count; i++)
            {
                nuotraukos.Add(Nuotrauka(i));
                PrekiuPanel.Controls.Add(nuotraukos[i]);

                kategorijos.Add(Kategorija(i));
                PrekiuPanel.Controls.Add(kategorijos[i]);

                pavadinimai.Add(Pavadinimas(i));
                PrekiuPanel.Controls.Add(pavadinimai[i]);

                minusButtons.Add(MinusButton(i));
                PrekiuPanel.Controls.Add(minusButtons[i]);

                PasirinktiKiekiai.Add(PasirinktasKiekis(i));
                PrekiuPanel.Controls.Add(PasirinktiKiekiai[i]);

                plusButtons.Add(PlusButton(i));
                PrekiuPanel.Controls.Add(plusButtons[i]);

                kainos.Add(Kaina(i));
                PrekiuPanel.Controls.Add(kainos[i]);

                infoApieKiekius.Add(InfoApieKieki(i));
                PrekiuPanel.Controls.Add(infoApieKiekius[i]);
            }
        }

        public void AtvaizduotiPrekes()
        {
            for (int i = 0; i < Duomenys.Prekes.Count; i++)
            {
                nuotraukos[i].AtvaizduotiNuotrauka(Duomenys.Prekes[i].PrekeId);
                pavadinimai[i].Text = Duomenys.Prekes[i].Pavadinimas;
                kategorijos[i].Text = Duomenys.Prekes[i].Kategorija.ToUpper();
                kainos[i].Text = Duomenys.Prekes[i].Kaina.ToString("N") + " €";
                PasirinktiKiekiai[i].Text = Duomenys.Prekes[i].PasirinktasKiekis.ToString();

                int turimasKiekis = Duomenys.Prekes[i].TurimasKiekis;
                switch (turimasKiekis)
                {
                    case 0:
                        infoApieKiekius[i].Text = "Šiuo metu neturime";
                        infoApieKiekius[i].ForeColor = Color.Red;
                        break;
                    case 1:
                        infoApieKiekius[i].Text = "Liko tik 1 vnt.";
                        infoApieKiekius[i].ForeColor = Color.Lime;
                        break;
                    default:
                        infoApieKiekius[i].Text = "Turime parduotuvėje";
                        infoApieKiekius[i].ForeColor = Color.Green;
                        break;
                }
            }
        }






        private void minusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = minusButtons.IndexOf(mygtukas);
            Duomenys.Prekes[i].PasirinktasKiekis--;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = plusButtons.IndexOf(mygtukas);
            Duomenys.Prekes[i].PasirinktasKiekis++;
        }

        private void KrepselioLangas_Show(object sender, EventArgs e)
        {
            Hide();
            Langai.KrepselioLangas.Location = this.Location;
            Langai.KrepselioLangas.Show();
        }
    }
}
