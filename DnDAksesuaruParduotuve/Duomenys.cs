using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Duomenys
    {
        public Duomenys()
        {
            NuskaitytiPrekes();
        }

        public static List<Preke> Prekes { get; set; }
        public static Krepselis Krepselis { get; set; } = new Krepselis();

        public static void NuskaitytiPrekes()
        {
            List<Preke> prekes = new List<Preke>();

            using (var context = new DnDAksesuaruContext())
            {
                foreach (var preke in context.Prekes)
                {
                    prekes.Add(new Preke(preke.PrekeId,
                                         preke.Pavadinimas,
                                         preke.Kategorija,
                                         preke.Kaina,
                                         preke.Svoris,
                                         preke.TurimasKiekis));
                }
            }

            Prekes = prekes;
        }
    }
}
