using System;
using System.Collections.Generic;
using System.Text;

namespace DnDAksesuaruParduotuve
{
    public static class PrekesInitialData
    {
        public static readonly Preke[] DataSeed =
        {
            new Preke { PrekeId = 1, Pavadinimas = "5th Ed. Player's Handbook", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 15, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/81pViXqeVLL.jpg" },
            new Preke { PrekeId = 2, Pavadinimas = "5th Ed. Dungeon Master's Guide", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 15, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/81ZmhRwdUjL.jpg" },
            new Preke { PrekeId = 3, Pavadinimas = "Icewind Dale: Rime of the Frostmaiden", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 1, NuotraukaInternete = "https://www.fantasyobchod.cz/image/data/d-d-icewind-dale-rime-of-the-frostmaiden-5f562a2c5fbbd.jpeg" },
            new Preke { PrekeId = 4, Pavadinimas = "Rime of the Frostmaiden Dice", Kategorija = "kauliukai", Kaina = 26, Svoris = 0.1, TurimasKiekis = 25 , NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/91kFhDIut-L.jpg" },
            new Preke { PrekeId = 5, Pavadinimas = "Tasha's Cauldron of Everything", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 1, NuotraukaInternete = "https://cdn.shoplightspeed.com/shops/626817/files/27501342/1600x2048x1/dungeons-and-dragons-rpg-tashas-cauldron-of-everyt.jpg" },
            new Preke { PrekeId = 6, Pavadinimas = "Ghosts of Saltmarsh", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 5, NuotraukaInternete = "https://d8mkdcmng3.imgix.net/deda/638038.jpg?auto=format&bg=0FFF&fit=fill&h=600&q=100&w=600&s=3528cc8745e0f250d8d86ff279cbca51" },
            new Preke { PrekeId = 7, Pavadinimas = "Guildmaster's Guide to Ravnica", Kategorija = "knyga",Kaina = 43, Svoris = 1, TurimasKiekis = 5, NuotraukaInternete = "https://cdn.shopify.com/s/files/1/1492/5286/products/816ldxUTQoL.jpg?v=1579312130" },
            new Preke { PrekeId = 8, Pavadinimas = "Out of the Abyss", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 5, NuotraukaInternete = "https://cdn.shopify.com/s/files/1/0068/1125/4841/products/OW2gcBOT2mzpFnW9RMnv_91o93lxnXGL.jpg?v=1575486108" },
            new Preke { PrekeId = 9, Pavadinimas = "Polyhedral 7-Die Set – Mercury", Kategorija = "kauliukai", Kaina = 8, Svoris = 0.1, TurimasKiekis = 100, NuotraukaInternete = "https://stalozaidimai.eu/wp-content/uploads/2020/10/46748_c65wh3h.png" },
            new Preke { PrekeId = 10, Pavadinimas = "Polyhedral 7-Die Set – Cobalt", Kategorija = "kauliukai", Kaina = 8, Svoris = 0.1, TurimasKiekis = 100, NuotraukaInternete = "https://stalozaidimai.eu/wp-content/uploads/2020/10/46752_2qp3qfh.png" },
            new Preke { PrekeId = 11, Pavadinimas = "Polyhedral 7-Die Set – Dusty Blue", Kategorija = "kauliukai", Kaina = 8, Svoris = 0.1, TurimasKiekis = 100, NuotraukaInternete = "https://www.meeplemart.com/resize/Shared/Images/Product/Chessex-25426-Polyhedral-7-Die-Set-Opaque-Dusty-Blue-Gold/CHX25426.jpg?" },
            new Preke { PrekeId = 12, Pavadinimas = "Laeral Silverhand's Explorer's Kit", Kategorija = "kauliukai", Kaina = 23, Svoris = 0.1, TurimasKiekis = 25, NuotraukaInternete = "https://www.spellenhuis.nl/media/catalog/product/w/h/wh3ipmn7dbe3u674sciszzzhdbgixwxz.jpg" },
            new Preke { PrekeId = 13, Pavadinimas = "Forest Beige & Black Dice Pouch", Kategorija = "kauliukų maišelis", Kaina = 7, Svoris = 0.08, TurimasKiekis = 10, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/71XaXNczwyL._SL1500_.jpg" },
            new Preke { PrekeId = 14, Pavadinimas = "Plush Dice Bag – Black", Kategorija = "kauliukų maišelis", Kaina = 10, Svoris = 0.08, TurimasKiekis = 0, NuotraukaInternete = "https://stalozaidimai.eu/wp-content/uploads/2020/09/rodykle-1.jpg" },
            new Preke { PrekeId = 15, Pavadinimas = "Plush Dice Bag – Purple", Kategorija = "kauliukų maišelis", Kaina = 10, Svoris = 0.08, TurimasKiekis = 10, NuotraukaInternete = "https://stalozaidimai.eu/wp-content/uploads/2020/09/15679.jpg" },
            new Preke { PrekeId = 16, Pavadinimas = "Plush Dice Bag – Blue", Kategorija = "kauliukų maišelis", Kaina = 10, Svoris = 0.08, TurimasKiekis = 10, NuotraukaInternete = "https://stalozaidimai.eu/wp-content/uploads/2020/09/15681.jpg" },
            new Preke { PrekeId = 17, Pavadinimas = "Acquisitions Incorporated", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 5, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/81WwX0mqQ7L.jpg" },
            new Preke { PrekeId = 18, Pavadinimas = "Candlekeep Mysteries", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 5, NuotraukaInternete = "https://media.dnd.wizards.com/styles/product_image_left_scale/public/images/product/jSdb2ck9jb0cb.png" },
            new Preke { PrekeId = 19, Pavadinimas = "Eberron: Rising From the Last War", Kategorija = "knyga", Kaina = 43, Svoris = 1, TurimasKiekis = 5, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/916w8dxeeOL.jpg" },
            new Preke { PrekeId = 20, Pavadinimas = "Monster Card Deck Levels 0-5", Kategorija = "kortos", Kaina = 21, Svoris = 0.7, TurimasKiekis = 6, NuotraukaInternete = "https://cdn.shoplightspeed.com/shops/623735/files/20611566/gale-force-nine-d-d-rpg-monster-cards-challenge-0.jpg" },
            new Preke { PrekeId = 21, Pavadinimas = "Monster Card Deck Levels 6-16", Kategorija = "kortos", Kaina = 13, Svoris = 0.7, TurimasKiekis = 8, NuotraukaInternete = "https://cdn.shopify.com/s/files/1/1176/7756/products/d-d-monster-cards-challenge-6-16-wizards-of-the-coast-board-games-15743541837933_2000x.jpg?v=1604343719" },
            new Preke { PrekeId = 22, Pavadinimas = "Curse of Strahd Tarokka Deck", Kategorija = "kortos", Kaina = 9, Svoris = 0.7, TurimasKiekis = 2, NuotraukaInternete = "https://cdn.shoplightspeed.com/shops/636231/files/22239844/1600x2048x2/gale-force-nine-d-d-5e-tarokka-deck.jpg" },
            new Preke { PrekeId = 23, Pavadinimas = "Volo's Guide To Monsters", Kategorija = "kortos", Kaina = 16, Svoris = 0.7, TurimasKiekis = 4, NuotraukaInternete = "https://cdn11.bigcommerce.com/s-4f6mmftha6/images/stencil/1280x1280/products/2314/8195/hasbro-dandd-monster-cards-volos-guide-to-monsters__17784.1608219739.jpg?c=1" },
            new Preke { PrekeId = 24, Pavadinimas = "Creatures & NPCs", Kategorija = "kortos", Kaina = 14, Svoris = 0.7, TurimasKiekis = 5, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/81dLSXApRcL._SL1500_.jpg" },
            new Preke { PrekeId = 25, Pavadinimas = "Mordenkainen's Tome of Foes", Kategorija = "kortos", Kaina = 21, Svoris = 0.7, TurimasKiekis = 7, NuotraukaInternete = "https://cdn.shoplightspeed.com/shops/637034/files/23098088/wizard-of-the-coast-d-d-monster-cards-mordenkainen.jpg" },
            new Preke { PrekeId = 26, Pavadinimas = "Epic Monsters", Kategorija = "kortos", Kaina = 23, Svoris = 0.7, TurimasKiekis = 11, NuotraukaInternete = "https://cdn.shoplightspeed.com/shops/609120/files/19340312/wizards-of-the-coast-dungeons-and-dragons-epic-mon.jpg" },
            new Preke { PrekeId = 27, Pavadinimas = "Magical Items", Kategorija = "kortos", Kaina = 24, Svoris = 0.7, TurimasKiekis = 12, NuotraukaInternete = "https://images-na.ssl-images-amazon.com/images/I/81gSb3PdOhL._AC_SL1500_.jpg" },
            new Preke { PrekeId = 28, Pavadinimas = "GBeye Mug – D20", Kategorija = "puodukas", Kaina = 10, Svoris = 0.6, TurimasKiekis = 1, NuotraukaInternete = "https://www.rikis.lt/wp-content/uploads/GBeye_Mug_Dungeons_and_Dragons_D20_600x600_01-500x500.jpg" },
            new Preke { PrekeId = 29, Pavadinimas = "GBeye Mug – Players Handbook", Kategorija = "puodukas", Kaina = 10, Svoris = 0.6, TurimasKiekis = 2, NuotraukaInternete = "https://www.rikis.lt/wp-content/uploads/GBeye_Mug_Dungeons_and_Dragons_Players_Handbook_600x600_01.jpg" },
            new Preke { PrekeId = 30, Pavadinimas = "GBeye Mug – Dungeon Master", Kategorija = "puodukas", Kaina = 10, Svoris = 0.6, TurimasKiekis = 3, NuotraukaInternete = "https://www.rikis.lt/wp-content/uploads/GBeye_Mug_Dungeons_and_Dragons_Dungeon_Master_600x600_01.jpg" }
        };
    }
}
