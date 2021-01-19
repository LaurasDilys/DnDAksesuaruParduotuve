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

            
            AtvaizduotiPrekes();
        }

        List<PictureBox> nuotraukos = new List<PictureBox>();
        List<Label> kategorijos = new List<Label>();
        List<Label> pavadinimai = new List<Label>();
        List<Button> minusButtons = new List<Button>();
        public List<Label> pasirinktiKiekiai = new List<Label>();
        List<Button> plusButtons = new List<Button>();
        List<Label> kainos = new List<Label>();
        List<Label> infoApieKiekius = new List<Label>();

        public void AtvaizduotiPrekes()
        {
            for (int i = 0; i < Duomenys.prekes.Count; i++)
            {
                nuotraukos.Add(Nuotrauka(i));
                PrekiuPanel.Controls.Add(nuotraukos[i]);
                nuotraukos[i].ImageLocation = @"C:\Users\laura\Desktop\testas.jpg";

                kategorijos.Add(Kategorija(i));
                PrekiuPanel.Controls.Add(kategorijos[i]);

                pavadinimai.Add(Pavadinimas(i));
                PrekiuPanel.Controls.Add(pavadinimai[i]);

                minusButtons.Add(MinusButton(i));
                PrekiuPanel.Controls.Add(minusButtons[i]);

                pasirinktiKiekiai.Add(PasirinktasKiekis(i));
                PrekiuPanel.Controls.Add(pasirinktiKiekiai[i]);

                plusButtons.Add(PlusButton(i));
                PrekiuPanel.Controls.Add(plusButtons[i]);

                kainos.Add(Kaina(i));
                PrekiuPanel.Controls.Add(kainos[i]);

                infoApieKiekius.Add(InfoApieKieki(i));
                PrekiuPanel.Controls.Add(infoApieKiekius[i]);
            }

            for (int i = 0; i < Duomenys.prekes.Count; i++)
            {
                pavadinimai[i].Text = Duomenys.prekes[i].Pavadinimas;
                kategorijos[i].Text = Duomenys.prekes[i].Kategorija.ToUpper();
                kainos[i].Text = Duomenys.prekes[i].Kaina.ToString("N") + " €";
                pasirinktiKiekiai[i].Text = Duomenys.prekes[i].PasirinktasKiekis.ToString();
                
                int turimasKiekis = Duomenys.prekes[i].TurimasKiekis;
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
            Duomenys.prekes[i].PasirinktasKiekis--;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = plusButtons.IndexOf(mygtukas);
            Duomenys.prekes[i].PasirinktasKiekis++;
        }

        private void KrepselioLangas_Show(object sender, EventArgs e)
        {
            Hide();
            Langai.krepselioLangas.Show();
        }
    }
}
