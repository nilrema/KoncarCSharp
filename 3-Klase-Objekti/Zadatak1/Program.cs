using System;
using zadatak_1.Models;
using System.Collections.Generic;

namespace zadatak_1
{
    // Klasa 'Program' sadrži metodu Main, koja je ulazna točka aplikacije.
    internal class Program
    {
        // Metoda Main je mjesto gdje instanciramo objekte Ucionica i Polaznik i izvodimo operacije nad njima.
        static void Main(string[] args)
        {
            // Stvaranje liste za pohranu objekata Ucionica.
            var ucionice = new List<Ucionica>();

            // Instanciranje prvog objekta Ucionica i postavljanje njegovih svojstava.
            // To ispunjava dio zadatka gdje trebamo stvoriti objekte učionica s određenim atributima.
            var ucionica1 = new Ucionica { Kat = 2, Broj = "D-5", BrojMjesta = 24, Racunala = true };

            // Dodavanje dva objekta Polaznik u prvu Ucionicu.
            // To ispunjava zahtjev za dodavanje dva polaznika u prvu učionicu.
            ucionica1.Polaznici.Add(new Polaznik { Ime = "Chuck", Prezime = "Norris", Oib = "6669996669" });
            ucionica1.Polaznici.Add(new Polaznik { Ime = "Steven", Prezime = "Seagal", Oib = "12345678901" });

            // Dodavanje prve Ucionice u listu učionica.
            ucionice.Add(ucionica1);

            // Instanciranje drugog objekta Ucionica i postavljanje njegovih svojstava.
            var ucionica2 = new Ucionica { Kat = 3, Broj = "E-2", BrojMjesta = 24, Racunala = false };

            // Dodavanje tri objekta Polaznik u drugu Ucionicu.
            // To ispunjava zahtjev za dodavanje tri polaznika u drugu učionicu.
            ucionica2.Polaznici.Add(new Polaznik { Ime = "Drago", Prezime = "Diklić", Oib = "54637282920" });
            ucionica2.Polaznici.Add(new Polaznik { Ime = "Milo", Prezime = "Hrnić", Oib = "12345678902" });
            ucionica2.Polaznici.Add(new Polaznik { Ime = "Elio", Prezime = "Pisak", Oib = "32345678902" });

            // Dodavanje druge Ucionice u listu učionica.
            ucionice.Add(ucionica2);

            // Iteriranje kroz svaku Ucionicu u listi i ispisivanje njezinih detalja zajedno s detaljima svakog Polaznika koji se nalazi u njoj.
            // Ovo prikazuje podatke koje smo upravo stvorili i manipulirali.
            foreach (var ucionica in ucionice)
            {
                Console.WriteLine($"Učionica: {ucionica.Broj}, Kat: {ucionica.Kat}, Mjesta: {ucionica.BrojMjesta}, Računala: {(ucionica.Racunala ? "Da" : "Ne")}");
                Console.WriteLine("Polaznici:");
                foreach (var polaznik in ucionica.Polaznici)
                {
                    Console.WriteLine($"Ime: {polaznik.Ime}, Prezime: {polaznik.Prezime}, OIB: {polaznik.Oib}");
                }
                Console.WriteLine();
            }
        }
    }
}
