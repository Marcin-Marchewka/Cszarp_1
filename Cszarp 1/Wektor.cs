using System;
using System.Collections.Generic;
using Cszarp_1;

namespace Wektor
{
    //Zawiera wektor przechowujący samochody wraz z metodami do operowania na nim.
    class Auta
    {
        //wektor
        public List<Samochod> list = new List<Samochod>();

        //metody
        public void Dodawanie_samochodu()
        {
            Samochod auto = new Samochod();

            if (auto.poprawny)
            {
                Console.Write("Marka: ");
                auto.Marka = Console.ReadLine();
            }
            if (auto.poprawny)
            {
                Console.Write("Model: ");
                auto.Model = Console.ReadLine();
            }
            if (auto.poprawny)
            {
                Console.Write("Rok produkcji: ");
                auto.Rok = int.Parse(Console.ReadLine());
            }
            if (auto.poprawny)
            {
                Console.Write("Pojemnosc silnika: ");
                auto.Pojemnosc = int.Parse(Console.ReadLine());
            }
            if (auto.poprawny)
            {
                Console.Write("Przebieg: ");
                auto.Przebieg = int.Parse(Console.ReadLine());
            }
            if (auto.poprawny)
            {
                Console.Write("Typ skrzyni biegow: ");
                auto.Typ_skrzyni = Console.ReadLine();
            }

            if (auto.poprawny)
            {
                Push(auto);
            }
        }

        public void Push(Samochod auto)
        {
            try
            {
                list.Add(auto);
            }
            catch
            {
                Console.WriteLine("Blad zapisu w wektorze!");
            }
        }

        public List<int> Szukaj()
        {
            List<int> indx = new List<int>();
            Samochod auto = new Samochod();

            Console.Write("Marka: ");
            auto.Marka = Console.ReadLine();
            Console.Write("Model: ");
            auto.Model = Console.ReadLine();

            if (auto.Marka == "brak" || auto.Model == "brak")
            {
                indx.Add(-1);
                return indx;
            }

            int j = 0;
            Console.WriteLine();
            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Marka == auto.Marka && list[i].Model == auto.Model)
                {
                    j++;
                    Console.WriteLine($"{j}. {list[i]}");
                    indx.Add(i);
                }
            }

            if (j == 0)
            {
                Console.WriteLine("Nie znaleziono pasujacych wynikow.");
                indx.Add(-1);
            }

            return indx;
        }

        public void Usun(List<int> indx)
        {
            int wybor;

            if (indx[0] == -1)
            {
                return;
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("Pozycja do usuniecia: ");
                try
                {
                    wybor = int.Parse(Console.ReadLine());

                    if (wybor < 1 || wybor > indx.Count)
                    {
                        Console.WriteLine("Nieprawidlowa wartosc!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Nieprawidlowa wartosc!");
                }
            }

            list.RemoveAt(indx[wybor - 1]);

            Console.WriteLine("Pomyslnie usunieto pozycje.");
        }

        public void Wyswietl_wszystkie()
        {
            Console.WriteLine("- Marka - Model - Rok produkcji - Pojemnosc - Przebieg - Typ skrzyni biegow -");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        
        
    }
}