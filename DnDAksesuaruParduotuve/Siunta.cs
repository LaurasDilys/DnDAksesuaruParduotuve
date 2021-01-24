using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Siunta
    {
        public Siunta(Krepselis krepselis)
        {
            Krepselis = krepselis;
            PasirinktasPristatymoBudas = -1;
        }

        private Krepselis Krepselis { get; }
        public int PasirinktasPristatymoBudas { get; set; }
        public Dictionary<char, int> Pakuotes { get { return PakuociuInfo(out siuntimoKaina); } }

        private double siuntimoKaina;
        public double BendraKaina { get { return siuntimoKaina + Krepselis.PrekiuKaina; } }

        public List<string> SiuntosInfo()
        {
            List<string> siuntosInfo = new List<string>();
            if (Krepselis.Prekes.Count == 0)
            {
                return siuntosInfo;
            }
            else
            {
                siuntosInfo.Add(PasirinktasPristatymoBudas == -1 ? "Nepasirinktas pristatymo būdas!" : "Pasirinktas pristatymo būdas: ");
                switch (PasirinktasPristatymoBudas)
                {
                    case 0:
                        siuntosInfo[^1] += "paštu į namus";
                        break;
                    case 1:
                        siuntosInfo[^1] += "kurjeriu";
                        break;
                    case 2:
                        siuntosInfo[^1] += "į paštomatą";
                        break;
                    case 3:
                        siuntosInfo[^1] += "tarptautinis";
                        break;
                }
                siuntosInfo.Add("");
                siuntosInfo.Add("Siuntą sudaro:");
                if (Pakuotes.Count == 1 && Pakuotes.First().Value == 1)
                {
                    siuntosInfo.Add(string.Format("{0} dydžio pakuotė", Pakuotes.First().Key));
                }
                else
                {
                    foreach (var pakuote in Pakuotes)
                    {
                        siuntosInfo.Add(string.Format("{0}x {1} dydžio pakuotė{2}", pakuote.Value, pakuote.Key, pakuote.Value == 1 ? "" : "s"));
                    }
                }
                siuntosInfo.Add("");
                siuntosInfo.Add(string.Format("Siuntimo kaina: {0:0.00} €", siuntimoKaina));
                siuntosInfo.Add("");
                siuntosInfo.Add(string.Format("Pasirinktų prekių kaina: {0:0.00} €", Krepselis.PrekiuKaina));
                return siuntosInfo;
            }
        }

        private Dictionary<char, int> PakuociuInfo(out double siuntimoKaina)
        {
            //Sakykim, pakuotės dydis yra nustatomas tokiu būdu:
            //S dydžio pakuotė: iki 1 kg 
            //M dydžio pakuotė: 1-5 kg
            //L dydžio pakuotė: 5-20 kg

            Dictionary<char, int> pakuotes = new Dictionary<char, int>();
            double likoSupakuoti = Krepselis.PrekiuSvoris;
            while (likoSupakuoti > 0)
            {
                if (likoSupakuoti <= 1)
                {
                    pakuotes.Add('S', 1);
                    likoSupakuoti = 0;
                }
                else if (likoSupakuoti <= 5)
                {
                    pakuotes.Add('M', 1);
                    likoSupakuoti = 0;
                }
                else
                {
                    if (pakuotes.ContainsKey('L')) pakuotes['L']++;
                    else pakuotes.Add('L', 1);
                    if (likoSupakuoti <= 20) likoSupakuoti = 0;
                    else likoSupakuoti -= 20;
                }
            }

            siuntimoKaina = 0;
            foreach (var pakuote in pakuotes)
            {
                siuntimoKaina += PakuotesKaina(pakuote.Key) * pakuote.Value;
            }
            return pakuotes;
        }

        //Žemiau esančiame metode yra nurodytos visos pakuočių kainos
        //priklausomai nuo pakuotės dydžio ir pasirinkto pristatymo būdo
        private double PakuotesKaina(char pakuotesDydis)
        {
            switch (PasirinktasPristatymoBudas)
            {
                case 0: //Siunčiant paštu į namus
                    switch (pakuotesDydis)
                    {
                        case 'S':
                            return 1.88;
                        case 'M':
                            return 2.44;
                        case 'L':
                            return 3.14;
                    }
                    break;
                case 1: //Siunčiant kurjeriu
                    switch (pakuotesDydis)
                    {
                        case 'S':
                            return 4.90;
                        case 'M':
                            return 5.99;
                        case 'L':
                            return 7.25;
                    }
                    break;
                case 2: //Siunčiant į paštomatą
                    switch (pakuotesDydis)
                    {
                        case 'S':
                            return 2.69;
                        case 'M':
                            return 3.49;
                        case 'L':
                            return 4.49;
                    }
                    break;
                case 3: //Tarptautinis siuntimas
                    switch (pakuotesDydis)
                    {
                        case 'S':
                            return 12.69;
                        case 'M':
                            return 23.49;
                        case 'L':
                            return 34.49;
                    }
                    break;
            }
            return 0;
        }
    }
}
