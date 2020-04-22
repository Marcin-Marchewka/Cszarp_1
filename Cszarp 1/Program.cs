using System;
using Cszarp_1;
using System.IO;
using Wektor;
using Plikk;
using Pomoc;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Auta samochody = new Auta();
            Plik plik = new Plik();

            bool warunek = false;

            while (true)
            {
                switch (Menu.MainList())
                {
                    case 1:

                        Console.WriteLine("--- Wczytywanie z pliku ---");
                        Console.WriteLine();

                        if (File.Exists(plik.GetTitle()))
                        {
                            Help.Czyszczenie(samochody);
                        }
                        warunek = plik.Read(samochody);

                        break;

                    case 2:

                        Console.WriteLine("--- Zapis do pliku ---");
                        Console.WriteLine();
                        if (warunek)
                        {
                            plik.GetTitle();
                            plik.Zapisz(samochody);
                        }
                        else
                        {
                            Console.WriteLine("Brak danych w bazie do zapisania");
                        }
                        break;

                    case 3:

                        Console.WriteLine("--- Dodawanie samochodu do bazy ---");
                        Console.WriteLine();
                        samochody.Dodawanie_samochodu();
                        warunek = true;
                        break;

                    case 4:

                        Console.WriteLine("--- Usuwanie samochodu z bazy ---", "G");
                        Console.WriteLine();
                        if (warunek)
                        {
                            samochody.Usun(samochody.Szukaj());
                        }
                        else
                        {
                            Console.WriteLine("Brak danych w bazie", "DY");
                        }
                        break;

                    case 5:

                        Console.WriteLine("--- Wszystkie samochody ---");
                        Console.WriteLine();
                        samochody.Wyswietl_wszystkie();
                        break;

                   
                    case 6:

                        Console.WriteLine("--- Wyszukiwanie samochodu ---");
                        Console.WriteLine();
                        if (warunek)
                        {
                            samochody.Szukaj();
                        }
                        else
                        {
                            Console.WriteLine("Brak danych w bazie");
                        }
                        break;

                    case 7:

                        return;
                }
               
            }
        }
    }
}
