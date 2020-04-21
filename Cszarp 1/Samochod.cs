using System;
using System.Collections.Generic;
using System.Text;

namespace Cszarp_1

{
    //Zawiera dane określające pojedynczy samochód
    class Samochod
    {
        private string marka;
        private string model;
        private int rok;
        private int pojemnosc;
        private int przebieg;
        private string typ_skrzyni;

        public bool poprawny = true;
        internal IEnumerable<Samochod> list;

        public string Marka
        {
            get => marka;
            set
            {
                if (value == "Alfa Romeo" || value == "Aston Martin" || value == "Audi" || value == "Bentley"
                    || value == "BMW" || value == "Bugatti" || value == "Buick" || value == "Cadillac"
                    || value == "Chevrolet" || value == "Chrysler" || value == "Citroen" || value == "Dacia"
                    || value == "Daewoo" || value == "DAF" || value == "Daihatsu" || value == "Dodge"
                    || value == "Ferrari" || value == "Fiat" || value == "Ford" || value == "FSO" || value == "Honda"
                    || value == "Hyundai" || value == "Inifnity" || value == "Iveco" || value == "Jaguar"
                    || value == "Jeep" || value == "KIA" || value == "Lamborghini" || value == "Land Rover"
                    || value == "Lexus" || value == "Maserati" || value == "Maybach" || value == "Mazda"
                    || value == "McLaren" || value == "Mercedes" || value == "Mini" || value == "Mitsubishi"
                    || value == "Nissan" || value == "Opel" || value == "Peugeot" || value == "Porshe"
                    || value == "Renault" || value == "Rolls Royce" || value == "Rover" || value == "SAAB"
                    || value == "Scania" || value == "Seat" || value == "Skoda" || value == "Smart"
                    || value == "Subaru" || value == "Suzuki" || value == "Tesla" || value == "Toyota"
                    || value == "Volkswagen" || value == "Volvo")
                {
                    try
                    {
                        marka = value;
                    }
                    catch
                    {
                        poprawny = false;
                        marka = "brak";
                        Console.WriteLine("Zly format!");
                    }
                }
                else
                {
                    poprawny = false;
                    marka = "brak";
                    Console.WriteLine($"Niepoprawna nazwa marki: {value}!");
                }
            }
        }

        public string Model
        {
            get => model;
            set
            {
                try
                {
                    model = value;
                }
                catch
                {
                    poprawny = false;
                    model = "brak";
                    Console.WriteLine($"Niepoprawny model: {value}!");
                }
            }
        }

        public int Rok
        {
            get => Rok;
            set
            {
                if (value > 1950 && value <= 2020)
                {
                    try
                    {
                        Rok = value;
                    }
                    catch
                    {
                        poprawny = false;
                        Rok = 0;
                        Console.WriteLine($"Niepoprawny rok produkcji: {value}!");
                    }
                }
                else
                {
                    poprawny = false;
                    Rok = 0;
                    Console.WriteLine($"Niepoprawny rok produkcji: {value}!");
                }
            }
        }

        public int Pojemnosc
        {
            get => pojemnosc;
            set
            {
                if (value >= 330)
                {
                    try
                    {
                        pojemnosc = value;
                    }
                    catch
                    {
                        poprawny = false;
                        pojemnosc = 0;
                        Console.WriteLine($"Niepoprawna pojemnosc silnika: {value}!");
                    }
                }
                else
                {
                    poprawny = false;
                    pojemnosc = 0;
                    Console.WriteLine($"Niepoprawna pojemnosc silnika: {value}!");
                }
            }
        }

        public int Przebieg
        {
            get => przebieg;
            set
            {
                if (value > 0)
                {
                    try
                    {
                        przebieg = value;
                    }
                    catch
                    {
                        poprawny = false;
                        przebieg = 0;
                        Console.WriteLine($"Niepoprawny przebieg: {value}!");
                    }
                }
                else
                {
                    poprawny = false;
                    przebieg = 0;
                    Console.WriteLine($"Niepoprawny przebieg: {value}!", "DY");
                }
            }
        }

        public string Typ_skrzyni
        {
            get => typ_skrzyni;
            set
            {
                if (value == "auto" || value == "manual")
                {
                    try
                    {
                        typ_skrzyni = value;
                    }
                    catch
                    {
                        poprawny = false;
                        typ_skrzyni = "brak";
                        Console.WriteLine($"Zly format: {value}!");
                    }
                }
                else
                {
                    poprawny = false;
                    typ_skrzyni = "brak";
                    Console.WriteLine($"Niepoprawny typ skrzyni biegow: {value}!");
                }
            }
        }

        public Samochod(string marka = "brak", string model = "brak", int rok = 0, int pojemnosc = 0, int przebieg = 0, string typ_skrzyni = "brak")
        {
            this.marka = marka;
            this.model = model;
            this.rok = rok;
            this.pojemnosc = pojemnosc;
            this.przebieg = przebieg;
            this.typ_skrzyni = typ_skrzyni;
        }

        public override string ToString()
        {
            return marka.ToString() + "\t" + model.ToString() + "\t" + rok.ToString() + "\t" + pojemnosc.ToString() + "\t"
                + przebieg.ToString() + "\t" + typ_skrzyni.ToString();
        }
    }
}