using System;
using System.Collections.Generic;
using System.Text;
using Wektor;
using Cszarp_1;

namespace Pomoc
{
    class Help
    {
        public static void Czyszczenie(Auta auto)
        {
            if (auto.list.Count != 0)
            {
                string wybor;

                Console.WriteLine("Baza danych programu zawiera juz dane. Czy chcesz je skasowac?");

                while (true)
                {
                    try
                    {
                        Console.Write("y - tak, n - nie: ");
                        wybor = Console.ReadLine();

                        if (wybor[0] == 'y')
                        {
                            //auto.list.Czyszczenie();
                            Console.WriteLine("Baza danych zostala oprozniona.");
                            break;
                        }
                        else if (wybor[0] == 'n')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna wartosc!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Niepoprawna wartosc!");
                    }
                }
            }
        }
    }
}
