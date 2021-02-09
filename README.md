# DnDAksesuaruParduotuve

Parduotuvės turimų prekių informacija yra įrašoma į duomenų bazę, naudojant DataSeed iš PrekesInitialData klasės.

Naudotojo nupirktos prekės yra išimamos iš duomenų bazės (atitinkamai sumažinami parduotuvės turimi kiekiai).
Ši atnaujinta informacija atsispindi tuomet, kai naudotojas sugrįžta į parduotuvę po apsipirkimo.

Duomenų bazei sukurti naudoju DropCreateDatabaseAlways tam, kad naujai atsidarius aplikaciją būtų matomi tie patys kiekiai – atitinkantys PrekesInitialData.
