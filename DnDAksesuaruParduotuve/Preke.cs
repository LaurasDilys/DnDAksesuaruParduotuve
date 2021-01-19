using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Preke
    {
        public Preke(string pavadinimas, string kategorija, double kaina, double svoris) : this(pavadinimas, kategorija, kaina, svoris, 1)
        {
        }

        public Preke(string pavadinimas, string kategorija, double kaina, double svoris, int turimasKiekis)
        {
            Pavadinimas = pavadinimas;
            Kategorija = kategorija;
            Kaina = kaina;
            Svoris = svoris;
            TurimasKiekis = turimasKiekis;
            pasirinktasKiekis = 0;
        }

        public string Pavadinimas { get; }
        public string Kategorija { get; }
        public double Kaina { get; }
        public double Svoris { get; }
        public int TurimasKiekis { get; private set; }

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
                        Duomenys.krepselis.Atimti(this);
                    }
                    else
                    {
                        pasirinktasKiekis = value;
                        Duomenys.krepselis.Prideti(this);
                    }
                    int i = Duomenys.prekes.IndexOf(this);
                    Langai.prekiuLangas.pasirinktiKiekiai[i].Text = PasirinktasKiekis.ToString();
                }
            }
        }
    }
}
