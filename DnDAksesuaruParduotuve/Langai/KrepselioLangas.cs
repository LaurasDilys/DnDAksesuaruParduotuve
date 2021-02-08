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
    public partial class KrepselioLangas : Form
    {
        public KrepselioLangas()
        {
            InitializeComponent();
            Visible = false;
            pristatymoLabels = new List<Label>();
            pristatymoLabels.Add(pastuLabel);
            pristatymoLabels.Add(kurjeriuLabel);
            pristatymoLabels.Add(iPastomataLabel);
            pristatymoLabels.Add(tarptautinisLabel);
            siunta = new Siunta(Duomenys.Krepselis);
        }

        private List<Label> pristatymoLabels;
        public static List<KrepselioElementas> krepselioElementai = new List<KrepselioElementas>();

        private Siunta siunta;


        public void KrepselioPanel_Update(Preke preke)
        {
            if (Duomenys.Krepselis.Prekes.Count > krepselioElementai.Count)
            {
                krepselioElementai.Add(new KrepselioElementas(preke, this));
                KrepselioPanel.Controls.Add(krepselioElementai.Last());
            }
            for (int i = 0; i < krepselioElementai.Count; i++)
            {
                krepselioElementai[i].Elementas_Update();
            }
        }

        public void SiuntosInfo_Update()
        {
            siuntosInfoLabel.Text = string.Join("\n", siunta.SiuntosInfo());
            bendraKaina.Text = string.Format("{0:0.00} €", siunta.BendraKaina);
        }


        private void PristatymoLabel_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font, FontStyle.Bold);
            label.BackColor = SystemColors.GradientActiveCaption;
            siunta.PasirinktasPristatymoBudas = pristatymoLabels.IndexOf(label);
            for (int i = 0; i < pristatymoLabels.Count; i++)
            {
                if (i != siunta.PasirinktasPristatymoBudas)
                {
                    pristatymoLabels[i].Font = new Font(label.Font, FontStyle.Regular);
                    pristatymoLabels[i].BackColor = SystemColors.ControlLight;
                }
            }
            pristatymoBudasLabel.ForeColor = Color.Black;
            SiuntosInfo_Update();
        }

        private void adresasBox_Enter(object sender, EventArgs e)
        {
            if (adresasBox.Text == "Pristatyti adresu...")
            {
                adresasBox.Text = "";
                adresasBox.ForeColor = Color.Black;
            }
        }

        private void adresasBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            adresasBoxBorder.BackColor = SystemColors.Control;
        }

        private void adresasBox_Leave(object sender, EventArgs e)
        {
            if (adresasBox.Text == "")
            {
                adresasBox.Text = "Pristatyti adresu...";
                adresasBox.ForeColor = Color.DimGray;
                adresasBoxBorder.BackColor = Color.Red;
            }
            else { adresasBoxBorder.BackColor = SystemColors.Control; }
        }

        private void PrekiuLangas_Show(object sender, EventArgs e)
        {
            Hide();
            Langai.PrekiuLangas.Location = this.Location;
            Langai.PrekiuLangas.Show();
        }

        private void DndLogo_MouseEnter(object sender, EventArgs e)
        {
            AksesuaraiLogo.ForeColor = SystemColors.Highlight;
        }

        private void DndLogo_MouseLeave(object sender, EventArgs e)
        {
            AksesuaraiLogo.ForeColor = SystemColors.ControlText;
        }



        private void apmoketiButton_Click(object sender, EventArgs e)
        {
            string zinute = "";
            if (Duomenys.Krepselis.Prekes.Count == 0)
            {
                zinute = "Krepšelis yra tuščias! Išsirinkite norimas prekes.";
                MessageBox.Show(zinute);
            }
            else
            {
                int nepasirinkti = 0;
                if (siunta.PasirinktasPristatymoBudas == -1)
                {
                    nepasirinkti++;
                    zinute = "Nepasirinktas pristatymo būdas!";
                    pristatymoBudasLabel.ForeColor = Color.Red;
                }
                if (adresasBox.ForeColor == Color.DimGray)
                {
                    nepasirinkti++;
                    zinute = "Nenurodytas adresas!";
                    adresasBoxBorder.BackColor = Color.Red;
                }
                if (nepasirinkti == 2) zinute = "Nepasirinktas pristatymo būdas ir nenurodytas adresas!";

                if (nepasirinkti > 0)
                {
                    MessageBox.Show(zinute);
                }
                else
                {
                    ManageDb.SumazintiTurimusKiekius(Duomenys.Krepselis.Prekes);
                    Form pardavimoLangas = new PardavimoLangas(adresasBox.Text);
                    pardavimoLangas.Location = this.Location;
                    pardavimoLangas.Show();
                    this.Hide();
                }
            }
        }

        private void KrepselioLangas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Langai.Exit();
        }
    }
}
