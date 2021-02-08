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

        private void AtvaizduotiKontroles()
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

        private void AtvaizduotiPrekes()
        {
            for (int i = 0; i < Duomenys.Prekes.Count; i++)
            {
                nuotraukos[i].AtvaizduotiNuotrauka(Duomenys.Prekes[i].PrekeId);
                kategorijos[i].Text = Duomenys.Prekes[i].Kategorija.ToUpper();
                pavadinimai[i].Text = Duomenys.Prekes[i].Pavadinimas;
                //Pavadinimui yra skiriamos max dvi eilutės
                //Jeigu pavadinimui užtenka vienos eilutės:
                if (TextRenderer.MeasureText(pavadinimai[i].Text, pavadinimai[i].Font).Width <= pavadinimai[i].Width)
                {
                    int vienosEilutesAukstis = pavadinimai[i].Height;
                    minusButtons[i].Top -= vienosEilutesAukstis;
                    plusButtons[i].Top -= vienosEilutesAukstis;
                    kainos[i].Top -= vienosEilutesAukstis;
                    infoApieKiekius[i].Top -= vienosEilutesAukstis;
                    PasirinktiKiekiai[i].Top -= vienosEilutesAukstis;
                }
                kainos[i].Text = Duomenys.Prekes[i].Kaina.ToString("N") + " €";
                PasirinktiKiekiai[i].Text = Duomenys.Prekes[i].PasirinktasKiekis.ToString();

                int turimasKiekis = Duomenys.Prekes[i].TurimasKiekis;
                if (turimasKiekis < 1)
                {
                    infoApieKiekius[i].Text = "Šiuo metu neturime";
                    infoApieKiekius[i].ForeColor = Color.Red;
                    //Deaktyvuojamos prekės kontrolės:
                    pavadinimai[i].ForeColor = SystemColors.GrayText;
                    kategorijos[i].ForeColor = SystemColors.GrayText;
                    kainos[i].ForeColor = SystemColors.GrayText;
                    PasirinktiKiekiai[i].ForeColor = SystemColors.GrayText;
                    PasirinktiKiekiai[i].Text = "";
                    minusButtons[i].Enabled = false;
                    plusButtons[i].Enabled = false;
                    plusButtons[i].MouseUp -= plusButton_MouseUp;
                }
                else if (turimasKiekis == 1)
                {
                    infoApieKiekius[i].Text = "Liko tik 1 vnt.";
                    infoApieKiekius[i].ForeColor = Color.Lime;
                }
                else
                {
                    infoApieKiekius[i].Text = "Turime parduotuvėje";
                    infoApieKiekius[i].ForeColor = Color.Green;
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

        private void plusButton_MouseUp(object sender, MouseEventArgs e)
        {
            Button mygtukas = (Button)sender;
            int i = plusButtons.IndexOf(mygtukas);
            Preke preke = Duomenys.Prekes[i];
            if (preke.PasirinktasKiekis == preke.TurimasKiekis) daugiauNeturime.Show("Šiuo metu daugiau neturime", mygtukas);
        }

        private void KrepselioLangas_Show(object sender, EventArgs e)
        {
            Hide();
            Langai.KrepselioLangas.Location = this.Location;
            Langai.KrepselioLangas.Show();
        }

        private void PrekiuLangas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Langai.Exit();
        }

        private void KrepselioLogo_MouseEnter(object sender, EventArgs e)
        {
            KrepselisLogo.ForeColor = SystemColors.Highlight;
            KrepselisLogo.Font = new Font(KrepselisLogo.Font, FontStyle.Bold);
            PasirinktuPrekiuKiekis.ForeColor = SystemColors.Highlight;
        }

        private void KrepselioLogo_MouseLeave(object sender, EventArgs e)
        {
            KrepselisLogo.ForeColor = SystemColors.ControlText;
            KrepselisLogo.Font = new Font(KrepselisLogo.Font, FontStyle.Regular);
            PasirinktuPrekiuKiekis.ForeColor = SystemColors.ControlText;
        }
    }
}
