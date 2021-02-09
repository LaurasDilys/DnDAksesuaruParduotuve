using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Preke
    {
        public Preke() { }

        public Preke(int prekeId, string pavadinimas, string kategorija, double kaina, double svoris, int turimasKiekis, string nuotraukaInternete)
        {
            PrekeId = prekeId;
            Pavadinimas = pavadinimas;
            Kategorija = kategorija;
            Kaina = kaina;
            Svoris = svoris;
            TurimasKiekis = turimasKiekis;
            NuotraukaInternete = nuotraukaInternete;
            pasirinktasKiekis = 0;
        }

        public int PrekeId { get; set; }
        public string Pavadinimas { get; set; }
        public string Kategorija { get; set; }
        public double Kaina { get; set; }
        public double Svoris { get; set; }
        public int TurimasKiekis { get; set; }
        public string NuotraukaInternete { get; set; }

        private int pasirinktasKiekis;
        public int PasirinktasKiekis
        {
            get { return pasirinktasKiekis; }
            set
            {
                if (value >= 0 && value <= TurimasKiekis)
                {
                    if (pasirinktasKiekis > value)
                    {
                        pasirinktasKiekis = value;
                        Duomenys.Krepselis.Atimti(this);
                    }
                    else
                    {
                        pasirinktasKiekis = value;
                        Duomenys.Krepselis.Prideti(this);
                    }
                    int i = Duomenys.Prekes.IndexOf(this);
                    Langai.PrekiuLangas.PasirinktiKiekiai[i].Text = PasirinktasKiekis.ToString();
                }
            }
        }
    }
}
