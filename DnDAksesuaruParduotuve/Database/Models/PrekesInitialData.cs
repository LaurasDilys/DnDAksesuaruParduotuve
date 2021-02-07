using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public static class PrekesInitialData
    {
        public static readonly Preke[] DataSeed =
        {
            new Preke { PrekeId = 1, Pavadinimas = "D&D kauliukai – Mercury", Kategorija = "kauliukai", Kaina = 8, Svoris = 0.1, TurimasKiekis = 100 },
            new Preke { PrekeId = 1, Pavadinimas = "D&D kauliukai – Golden Cobalt", Kategorija = "kauliukai", Kaina = 8, Svoris = 0.1, TurimasKiekis = 100 },
            new Preke { PrekeId = 1, Pavadinimas = "D&D kauliukai – Dusty Blue", Kategorija = "kauliukai", Kaina = 8, Svoris = 0.1, TurimasKiekis = 100 },
            new Preke { PrekeId = 2, Pavadinimas = "Kauliukų maišelis – Blue/Gold Velvet", Kategorija = "kauliukų maišelis", Kaina = 4, Svoris = 0.08, TurimasKiekis = 10 },
            new Preke { PrekeId = 4, Pavadinimas = "Tasha's Cauldron of Everything", Kategorija = "knyga", Kaina = 43, Svoris = 0.6, TurimasKiekis = 1 }
        };
    }
}
