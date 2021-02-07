using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public class DnDAksesuaruContextInitializer : CreateDatabaseIfNotExists<DnDAksesuaruContext>
    {
        protected override void Seed(DnDAksesuaruContext context)
        {
            context.Prekes.AddRange(PrekesInitialData.DataSeed);
        }
    }
}
