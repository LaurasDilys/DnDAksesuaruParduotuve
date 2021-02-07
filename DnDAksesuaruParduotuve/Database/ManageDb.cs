using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class ManageDb
    {
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
