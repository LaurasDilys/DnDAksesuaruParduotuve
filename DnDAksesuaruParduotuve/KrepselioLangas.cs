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
            pasirinktasPristatymoBudas = -1;
        }

        private List<Label> pristatymoLabels;
        public static int pasirinktasPristatymoBudas;
        public static List<KrepselioElementas> krepselioElementai = new List<KrepselioElementas>();


        public void KrepselioPanel_Update(Preke preke)
        {
            if (Duomenys.krepselis.Prekes.Count > krepselioElementai.Count)
            {
                krepselioElementai.Add(new KrepselioElementas(preke));
                KrepselioPanel.Controls.Add(krepselioElementai.Last());
            }
            for (int i = 0; i < krepselioElementai.Count; i++)
            {
                krepselioElementai[i].Elementas_Update();
            }
        }



        private void PristatymoLabel_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font, FontStyle.Bold);
            label.BackColor = SystemColors.GradientActiveCaption;
            pasirinktasPristatymoBudas = pristatymoLabels.IndexOf(label);
            for (int i = 0; i < pristatymoLabels.Count; i++)
            {
                if (i != pasirinktasPristatymoBudas)
                {
                    pristatymoLabels[i].Font = new Font(label.Font, FontStyle.Regular);
                    pristatymoLabels[i].BackColor = SystemColors.ControlLight;
                }
            }
            pristatymoBudasLabel.ForeColor = Color.Black;
            Siunta.SiuntosInfo_Update();
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
            //Hide();
            Langai.prekiuLangas.Show();
        }

        private void apmoketiButton_Click(object sender, EventArgs e)
        {
            int nepasirinkti = 0;
            string zinute;
            //if (krepselis.Count == 0)
            //{
            //    zinute = "Krepšelis yra tuščias! Išsirinkite norimas prekes.";
            //}
            //else
            //{
            if (pasirinktasPristatymoBudas == -1)
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
            if (nepasirinkti == 2)
            {
                zinute = "Nepasirinktas pristatymo būdas ir nenurodytas adresas!";
            }
            else if (nepasirinkti == 0)
            {
                //Dėkojame. Siunta bus prisatyta adresu...
                //Ar norite grįžti į parduotuvę?
            }
        }
    }
}
