using Cszarp_1;
using System;
using System.IO;
using Wektor;

namespace Plikk
{
    class Plik
    {
        private string title = "katalog.txt";

        public bool Read(Auta auto)
        {
            try
            {
                using (StreamReader f = new StreamReader(title))
                {
                    string[] input = File.ReadAllLines(title);

                    foreach (var item in input)
                    {
                        Samochod c = new Samochod();

                        string[] temp = item.Split("\t");

                        c.Marka = temp[0].ToString();
                        c.Model = temp[1].ToString();
                        c.Rok = int.Parse(temp[2]);
                        c.Pojemnosc = int.Parse(temp[3]);
                        c.Przebieg = int.Parse(temp[4]);
                        c.Typ_skrzyni = temp[5].ToString();

                    }
                }
            }
            catch
            {
                Console.WriteLine("Blad pliku!");
                return false;
            }
            Console.WriteLine("Pomyslnie odczytano dane.");
            return true;
        }

        public bool Zapisz(Auta auto)
        {
            int tryb;
            bool x;

            if (File.Exists(title))
            {
                Console.WriteLine("Plik o podanej nazwie istnieje.");
                Console.WriteLine("0 - aby go nadpisac, 1 - aby dopisac linie");
                tryb = Menu.Wybory(0, 1);

                if (tryb == 0)
                {
                    File.Delete(title);
                    x = false;
                }
                else
                {
                    x = true;
                }
            }
            else
            {
                x = false;
            }

            using (StreamWriter f = new StreamWriter(title, x))
            {
                foreach (Samochod item in auto.list)
                {
                    try
                    {
                        f.WriteLine($"{item.Marka}\t{item.Model}\t{item.Rok}\t{item.Pojemnosc}\t{item.Przebieg}\t{item.Typ_skrzyni}");
                    }
                    catch
                    {
                        Console.WriteLine("Operacja nie powiodla sie!");
                        return false;
                    }
                }
            }

            Console.WriteLine("Pomyslnie zapisano dane.");
            return true;
        }

        public string GetTitle()
        {
            string end;

            Console.Write("Podaj nazwe pliku: ");
            title = Console.ReadLine();

            while (title.Length < 1)
            {
                Console.WriteLine("Nie podano nazwy pliku!");
                Console.Write("Podaj nazwe pliku: ");
                title = Console.ReadLine();
            }

            try
            {
                end = title.Substring(title.Length - 4);
            }
            catch
            {
                title = $"../../../{title}.txt";
                return title;
            }

            if (!end.Equals(".txt", StringComparison.OrdinalIgnoreCase))
            {
                title += ".txt";
            }

            title = $"../../../{title}";

            return title;
        }
    }
}
