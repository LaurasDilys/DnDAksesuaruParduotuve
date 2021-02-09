using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class ManageDb
    {
        public static List<Preke> NuskaitytiPrekes()
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
                                         preke.TurimasKiekis,
                                         preke.NuotraukaInternete));
                }
            }
            return prekes;
        }

        public static void SumazintiTurimusKiekius(List<Preke> krepselis)
        {
            using (var context = new DnDAksesuaruContext())
            {
                foreach (Preke preke in krepselis)
                {
                    context.Prekes.Single(p => p.PrekeId == preke.PrekeId).TurimasKiekis -= preke.PasirinktasKiekis;
                }
                context.SaveChanges();
            }
        }


    }
}
