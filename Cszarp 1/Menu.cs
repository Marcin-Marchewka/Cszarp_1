using System;
using System.Collections.Generic;
using System.Text;

namespace Cszarp_1
{
    static class Menu
    {
        public static int MainList()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("1. Wczytaj z pliku");
            Console.WriteLine("2. Zapisz w nowym pliku");
            Console.WriteLine("3. Dodaj samochod");
            Console.WriteLine("4. Usun samochod");
            Console.WriteLine("5. Wyswietl wszystkie samochody");
            Console.WriteLine("6. Wyswietl dane pojedynczego samochodu");
            Console.WriteLine("7. Wyjscie z programu");
            Console.WriteLine();

            int choise = Wybory(1, 9);
            Console.Clear();
            return choise;
        }

        public static int Wybory(int a, int b)
        {
            int wybor;

            while (true)
            {
                try
                {
                    Console.WriteLine("Twoj wybor: ");
                    wybor = int.Parse(Console.ReadLine());

                    if (wybor < a || wybor > b)
                    {
                        Console.WriteLine("Niewlasciwy wybor!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Niepoprawny format");
                }
            }

            return wybor;
        }
    }

}
