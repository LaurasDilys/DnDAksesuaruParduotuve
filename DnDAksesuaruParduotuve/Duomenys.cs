using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class Duomenys
    {
        public Duomenys()
        {
            Prekes = ManageDb.NuskaitytiPrekes();
        }

        public static List<Preke> Prekes { get; set; }
        public static Krepselis Krepselis { get; set; } = new Krepselis();

        
    }
}
