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
    partial class PrekiuLangas
    {
        public static int AntstumasnuoKaires(int objektoIndeksas)
        {
            return objektoIndeksas % 4 * 221;
        }

        public static int AntstumasnuoVirsaus(int objektoIndeksas)
        {
            return objektoIndeksas / 4 * 250;
        }

        public PictureBox Nuotrauka(int objektoIndeksas)
        {
            PictureBox nuotrauka = new PictureBox();
            nuotrauka.Location =
                new System.Drawing.Point(AntstumasnuoKaires(objektoIndeksas),
                                        AntstumasnuoVirsaus(objektoIndeksas));
            nuotrauka.Size = new System.Drawing.Size(174, 112);
            nuotrauka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            nuotrauka.TabStop = false;
            //nuotrauka.TabIndex = objektoIndeksas;

            return nuotrauka;
        }

        public Label Kategorija(int objektoIndeksas)
        {
            Label kategorija = new Label();
            kategorija.AutoSize = true;
            kategorija.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kategorija.Location =
                new System.Drawing.Point(AntstumasnuoKaires(objektoIndeksas),
                                  119 + AntstumasnuoVirsaus(objektoIndeksas));
            kategorija.Size = new System.Drawing.Size(70, 17);
            //kategorija.TabIndex = objektoIndeksas;

            return kategorija;
        }

        public Label Pavadinimas(int objektoIndeksas)
        {
            Label pavadinimas = new Label();
            pavadinimas.AutoSize = true;
            pavadinimas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pavadinimas.Location =
                new System.Drawing.Point(-1 + AntstumasnuoKaires(objektoIndeksas),
                                       140 + AntstumasnuoVirsaus(objektoIndeksas));
            pavadinimas.Size = new System.Drawing.Size(162, 23);
            //pavadinimas.TabIndex = objektoIndeksas;

            return pavadinimas;
        }

        public Button MinusButton(int objektoIndeksas)
        {
            Button minusButton = new Button();
            minusButton.Click += new EventHandler(minusButton_Click);
            minusButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            minusButton.Location =
                new System.Drawing.Point(AntstumasnuoKaires(objektoIndeksas),
                                  167 + AntstumasnuoVirsaus(objektoIndeksas));
            minusButton.Size = new System.Drawing.Size(32, 32);
            minusButton.Text = " -";
            minusButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            minusButton.UseVisualStyleBackColor = true;
            //minusButton.TabIndex = objektoIndeksas;

            return minusButton;
        }

        public Label PasirinktasKiekis(int objektoIndeksas)
        {
            Label pasirinktasKiekis = new Label();
            pasirinktasKiekis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pasirinktasKiekis.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pasirinktasKiekis.Location =
                new System.Drawing.Point(36 + AntstumasnuoKaires(objektoIndeksas),
                                       168 + AntstumasnuoVirsaus(objektoIndeksas));
            pasirinktasKiekis.Size = new System.Drawing.Size(35, 30);
            pasirinktasKiekis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //pasirinktasKiekis.TabIndex = objektoIndeksas;

            return pasirinktasKiekis;
        }

        public Button PlusButton(int objektoIndeksas)
        {
            Button plusButton = new Button();
            plusButton.Click += new EventHandler(plusButton_Click);
            plusButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            plusButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            plusButton.Location =
                new System.Drawing.Point(75 + AntstumasnuoKaires(objektoIndeksas),
                                       167 + AntstumasnuoVirsaus(objektoIndeksas));
            plusButton.Size = new System.Drawing.Size(32, 32);
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            //plusButton.TabIndex = objektoIndeksas;

            return plusButton;
        }

        public Label Kaina(int objektoIndeksas)
        {
            Label kaina = new Label();
            kaina.AutoSize = true;
            kaina.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kaina.Location =
                new System.Drawing.Point(116 + AntstumasnuoKaires(objektoIndeksas),
                                        171 + AntstumasnuoVirsaus(objektoIndeksas));
            kaina.Size = new System.Drawing.Size(64, 23);
            //kaina.TabIndex = objektoIndeksas;

            return kaina;
        }

        public Label InfoApieKieki(int objektoIndeksas)
        {
            Label infoApieKieki = new Label();
            infoApieKieki.AutoSize = true;
            infoApieKieki.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            infoApieKieki.Location =
                new System.Drawing.Point(AntstumasnuoKaires(objektoIndeksas),
                                  205 + AntstumasnuoVirsaus(objektoIndeksas));
            infoApieKieki.Size = new System.Drawing.Size(129, 17);
            //infoApieKieki.TabIndex = objektoIndeksas;

            return infoApieKieki;
        }

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox DnDLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrekiuLangas));
            this.AksesuaraiLogo = new System.Windows.Forms.Label();
            this.PrekiuPanel = new System.Windows.Forms.Panel();
            this.CartLogo = new System.Windows.Forms.PictureBox();
            this.KrepselisLogo = new System.Windows.Forms.Label();
            this.PasirinktuPrekiuKaina = new System.Windows.Forms.Label();
            this.PasirinktuPrekiuKiekis = new System.Windows.Forms.Label();
            DnDLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(DnDLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DnDLogo
            // 
            DnDLogo.Image = ((System.Drawing.Image)(resources.GetObject("DnDLogo.Image")));
            DnDLogo.Location = new System.Drawing.Point(17, 19);
            DnDLogo.Name = "DnDLogo";
            DnDLogo.Size = new System.Drawing.Size(54, 33);
            DnDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            DnDLogo.TabIndex = 0;
            DnDLogo.TabStop = false;
            // 
            // AksesuaraiLogo
            // 
            this.AksesuaraiLogo.AutoSize = true;
            this.AksesuaraiLogo.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AksesuaraiLogo.Location = new System.Drawing.Point(69, 20);
            this.AksesuaraiLogo.Name = "AksesuaraiLogo";
            this.AksesuaraiLogo.Size = new System.Drawing.Size(122, 30);
            this.AksesuaraiLogo.TabIndex = 1;
            this.AksesuaraiLogo.Text = "Aksesuarai";
            // 
            // PrekiuPanel
            // 
            this.PrekiuPanel.AutoScroll = true;
            this.PrekiuPanel.Location = new System.Drawing.Point(17, 76);
            this.PrekiuPanel.Name = "PrekiuPanel";
            this.PrekiuPanel.Size = new System.Drawing.Size(878, 737);
            this.PrekiuPanel.TabIndex = 2;
            // 
            // CartLogo
            // 
            this.CartLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartLogo.Image = ((System.Drawing.Image)(resources.GetObject("CartLogo.Image")));
            this.CartLogo.Location = new System.Drawing.Point(730, 13);
            this.CartLogo.Name = "CartLogo";
            this.CartLogo.Size = new System.Drawing.Size(50, 40);
            this.CartLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CartLogo.TabIndex = 3;
            this.CartLogo.TabStop = false;
            this.CartLogo.Click += new System.EventHandler(this.KrepselioLangas_Show);
            // 
            // KrepselisLogo
            // 
            this.KrepselisLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KrepselisLogo.AutoSize = true;
            this.KrepselisLogo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KrepselisLogo.Location = new System.Drawing.Point(797, 13);
            this.KrepselisLogo.Name = "KrepselisLogo";
            this.KrepselisLogo.Size = new System.Drawing.Size(61, 17);
            this.KrepselisLogo.TabIndex = 5;
            this.KrepselisLogo.Text = "Krepšelis";
            this.KrepselisLogo.Click += new System.EventHandler(this.KrepselioLangas_Show);
            // 
            // PasirinktuPrekiuKaina
            // 
            this.PasirinktuPrekiuKaina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasirinktuPrekiuKaina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasirinktuPrekiuKaina.Location = new System.Drawing.Point(777, 33);
            this.PasirinktuPrekiuKaina.Name = "PasirinktuPrekiuKaina";
            this.PasirinktuPrekiuKaina.Size = new System.Drawing.Size(81, 20);
            this.PasirinktuPrekiuKaina.TabIndex = 6;
            this.PasirinktuPrekiuKaina.Text = "0.00 €";
            this.PasirinktuPrekiuKaina.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.PasirinktuPrekiuKaina.Click += new System.EventHandler(this.KrepselioLangas_Show);
            // 
            // PasirinktuPrekiuKiekis
            // 
            this.PasirinktuPrekiuKiekis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasirinktuPrekiuKiekis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasirinktuPrekiuKiekis.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasirinktuPrekiuKiekis.Location = new System.Drawing.Point(746, 17);
            this.PasirinktuPrekiuKiekis.Name = "PasirinktuPrekiuKiekis";
            this.PasirinktuPrekiuKiekis.Size = new System.Drawing.Size(32, 25);
            this.PasirinktuPrekiuKiekis.TabIndex = 4;
            this.PasirinktuPrekiuKiekis.Text = "0";
            this.PasirinktuPrekiuKiekis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasirinktuPrekiuKiekis.Click += new System.EventHandler(this.KrepselioLangas_Show);
            // 
            // PrekiuLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 829);
            this.Controls.Add(this.PasirinktuPrekiuKiekis);
            this.Controls.Add(this.PasirinktuPrekiuKaina);
            this.Controls.Add(this.KrepselisLogo);
            this.Controls.Add(this.PrekiuPanel);
            this.Controls.Add(this.CartLogo);
            this.Controls.Add(this.AksesuaraiLogo);
            this.Controls.Add(DnDLogo);
            this.MaximumSize = new System.Drawing.Size(913, 876);
            this.MinimumSize = new System.Drawing.Size(913, 876);
            this.Name = "PrekiuLangas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D&D Aksesuarai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Langai.FormClosed);
            ((System.ComponentModel.ISupportInitialize)(DnDLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AksesuaraiLogo;
        private Panel PrekiuPanel;
        private PictureBox CartLogo;
        public Label PasirinktuPrekiuKaina;
        public Label PasirinktuPrekiuKiekis;
        private Label KrepselisLogo;
    }
}

