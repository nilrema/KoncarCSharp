using System;
using System.Collections.Generic;

namespace zadatak_1.Models
{
    // Klasa Ucionica predstavlja model učionice sa svojim svojstvima.
    internal class Ucionica
    {
        // Svojstvo 'Kat' predstavlja kat na kojem se učionica nalazi.
        // Tip podatka je 'int'
        public int Kat { get; set; }

        // Svojstvo 'Broj' predstavlja identifikacijski broj ili naziv učionice.
        // Tip podatka je 'string', a upitnik (?) označava da svojstvo može biti null (nullable).
        public string? Broj { get; set; }

        // Svojstvo 'BrojMjesta' označava broj mjesta (sjedala) dostupnih u učionici.
        public int BrojMjesta { get; set; }

        // Svojstvo 'Racunala' je bool tipa i označava da li učionica ima računala (true - da, false - ne).
        public bool Racunala { get; set; }

        // Svojstvo 'Polaznici' je lista objekata tipa Polaznik.
        // Ova lista služi za pohranu informacija o polaznicima koji prisustvuju u učionici.
        // Inicijalizirana je kao nova prazna lista Polaznika.
        public List<Polaznik> Polaznici { get; set; } = new List<Polaznik>();
    }
}
