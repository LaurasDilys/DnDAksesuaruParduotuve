using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    class Duomenys
    {
        public static List<Preke> prekes = NuskaitytiPrekes();
        public static Krepselis krepselis = new Krepselis();

        private static List<Preke> NuskaitytiPrekes()
        {
            List<Preke> prekes = new List<Preke>()
            {
                new Preke("D&D kauliukai", "kauliukai", 9, 0.1),
                new Preke("Kauliukų maišelis", "kauliukų maišelis", 10, 0.08),
                new Preke("Trys", "kauliukai", 25, 0.8),
                new Preke("Tasha's Cauldron of Everything", "knyga", 284, 0.6, 100),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 5),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 4),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 3),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 2),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 7),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 5),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 1),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 1),
                //new Preke("Raudoni kauliukai", "kauliukai", 9, 1),
                //new Preke("Žali kauliukai", "kauliukai", 10, 1),

            };

            return prekes;
        }
    }
}
