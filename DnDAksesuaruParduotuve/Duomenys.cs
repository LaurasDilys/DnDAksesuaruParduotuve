using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Duomenys
    {
        public static List<Preke> Prekes = NuskaitytiPrekes();
        public static Krepselis Krepselis = new Krepselis();

        private static List<Preke> NuskaitytiPrekes()
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
            
            return prekes;
        }
    }
}
