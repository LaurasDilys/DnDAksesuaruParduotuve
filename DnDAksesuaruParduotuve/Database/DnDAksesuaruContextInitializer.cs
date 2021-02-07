using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class DnDAksesuaruContextInitializer : DropCreateDatabaseAlways<DnDAksesuaruContext>
    {
        protected override void Seed(DnDAksesuaruContext context)
        {
            context.Prekes.AddRange(PrekesInitialData.DataSeed);
        }
    }
}
