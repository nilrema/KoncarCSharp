
using System;
using System.Collections.Generic;
using zadatak_2.Models;

namespace zadatak_2
{
    internal class Program{
        static void Main(string[] args) {
            // Inicijalizacija liste za pohranu učionica
            var ucionice = new List<Ucionica>();
            // Varijabla za provjeru želi li korisnik unijeti još učionica
            char nastavakOdgovor;
            do {
                // Unos kategorije (kat) učionice
                Console.Write("Molim kat učionice: ");
                var kat = int.Parse(Console.ReadLine()); // Pretvorba stringa u int

                // Unos broja učionice
                Console.Write("Molim broj učionice: ");
                var broj = Console.ReadLine(); // Čitanje stringa

                // Varijabla za pohranu odgovora o računalima u učionici
                bool? racunala = null; // Postavljeno na null radi provjere unosa
                do {
                    // Unos informacije o prisutnosti računala
                    Console.Write("Ima li učionica računala? (d/n): ");
                    var racunalaOdgovor = Console.ReadKey(); // Čitanje odgovora
                    Console.WriteLine();

                    if (racunalaOdgovor.KeyChar == 'd') { // Provjera odgovora
                        racunala = true; 
                    }
                    else if (racunalaOdgovor.KeyChar == 'n') { // Provjera odgovora
                        racunala = false;
                    }
                    else {
                        // Upozorenje u slučaju neispravnog unosa
                        Console.Write($"Unos {racunalaOdgovor.KeyChar} nije podržan.");
                    }
                } while (racunala == null);  // Ponavljanje unosa sve dok korisnik ne unese 'd' ili 'n'

                // Dodavanje novog objekta Ucionica u listu
                var ucionica = new Ucionica
                {
                    Kat = kat,
                    Broj = broj,
                    Racunala = racunala.Value
                };
                do
                { 
                    Console.Write("Ime polaznika: "); 
                    var ime = Console.ReadLine(); // Čitanje stringa

                    Console.Write("Prezime polaznika: ");
                    var prezime = Console.ReadLine(); // Čitanje stringa

                    Console.Write("OIB polaznika: ");
                    var oib = Console.ReadLine(); // Čitanje stringa

                    ucionica.Polaznici.Add(new Polaznik
                    {
                        Ime = ime,
                        Prezime = prezime,
                        Oib = oib,
                        BrojMjesta = 24 // fiksno postavljeno na 24
                    });

                    Console.Write("Želite li unijeti još polaznika? (d/n): "); // Upit za nastavak unosa
                    nastavakOdgovor = Console.ReadKey().KeyChar; // Čitanje odgovora
                    Console.WriteLine(); // Prazan redak
                } while (nastavakOdgovor != 'n'); // Ponavljanje unosa sve dok korisnik ne unese 'n'

                 ucionice.Add(ucionica); // Dodavanje učionice u listu

                // Provjera želi li korisnik unijeti još učionica
                Console.Write("Želite li unijeti još učionica? (d/n): ");
                nastavakOdgovor = Console.ReadKey().KeyChar; // Čitanje odgovora
                Console.WriteLine(); // Prazan redak
            } while (nastavakOdgovor != 'n'); // Ponavljanje unosa sve dok korisnik ne unese 'n'

            // Ispis učionica i polaznika
            Console.WriteLine("Popis učionica i polaznika:");
            foreach (var ucionica in ucionice)
            {
                Console.WriteLine($"Učionica {ucionica.Kat}-{ucionica.Broj}");
                Console.WriteLine($"Broj mjesta: {ucionica.BrojMjesta}");
                Console.WriteLine($"Računala: {(ucionica.Racunala ? "Da" : "Ne")}");
                Console.WriteLine("Polaznici:");

                // Sortiranje polaznika po prezimenu i imenu
                var sortiraniPolaznici = ucionica.Polaznici.OrderBy(p => p.Prezime).ThenBy(p => p.Ime); 

                // Ispis polaznika
                foreach (var polaznik in sortiraniPolaznici)
                {
                    Console.WriteLine($" {polaznik.Ime} {polaznik.Prezime} ({polaznik.Oib})");
                }
                Console.WriteLine();
            }

            // Ispis ukupnog broja polaznika
            var ukupnoPolaznika = ucionice.Sum(u => u.Polaznici.Count);
            Console.WriteLine($"Ukupno {ukupnoPolaznika} polaznika.");
        }
    }
}
