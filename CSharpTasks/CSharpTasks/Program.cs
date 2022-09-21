using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpTasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Dreieck d = new Dreieck(4, 5, 10);
            //d.Seite1 = 4;
            //d.Seite2 = 5;
            //d.Seite3 = 10;

            Kreis k = new Kreis(5);
            //k.Radius = 5;

            Rechteck r = new Rechteck(10, 25);
            //r.Seite1 = 10;
            //r.Seite2 = 25;

            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(d);
            geometries.Add(k);
            geometries.Add(r);

            foreach (var g in geometries)
            {
                Console.WriteLine($"Mein {g.GetType().Name} hat eine Fläche von {g.Flaeche()} und Umfang von {g.Umfang()}");
            }

            List<Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle("BMW", "1000RR", 2490, "rot", 2));
            fahrzeuge.Add(new Car(201, "Mercedes", "190E", 1996, "blau", 4));

            foreach (var fahrzeug in fahrzeuge)
            {
                fahrzeug.Starten();
                fahrzeug.Beschleunigen();
                fahrzeug.Beschleunigen();
                fahrzeug.Beschleunigen();
                fahrzeug.Beschleunigen();
                fahrzeug.Bremsen();
                Console.WriteLine($"{fahrzeug.GetType().Name}, {fahrzeug.Make}");
            }
            */

            //var dog1 = new Dog("Bello",3,80,12,45,true);
            //var cat1 = new Cat("Swiffers",5,24,15,13,true);
            //var pig1 = new Dog("Würstchen", 10, 65, 4, 100, false);

            //var gehege1 = new Gehege("Hundegehege",1,"Hund", dog1);
            //var gehege2 = new Gehege("Katzengehebe", 2, "Katze", cat1);
            //var gehege3 = new Gehege("Schweinegehege", 1, "Schwein", pig1);

            //var zoo = new Zoo("Der Neue Zoo");

            //zoo.AddGehege(gehege1);
            //zoo.AddGehege(gehege2);
            //zoo.AddGehege(gehege3);

            //zoo.PrintZooInfo();

            //dog1.GeraeuscheMachen();
            //cat1.GeraeuscheMachen();
            //pig1.GeraeuscheMachen();

            //dog1.Essen();
            //cat1.Essen();
            //pig1.Essen();

            //dog1.Trinken();
            //cat1.Trinken();
            //pig1.Trinken();


            //dog1.PrintAnimalInfo();
            //cat1.PrintAnimalInfo();
            //pig1.PrintAnimalInfo();

            var azubis = createAzubiList(5);
            var cleanedUpList = CleanList(azubis);
            foreach (var entry in cleanedUpList)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }

        public static List<string> createAzubiList(int anzahl)
        {
            var azubiListe = new List<string>();
            while (azubiListe.Count < anzahl)
            {
                Console.WriteLine("Bitte gib einen Namen ein");
                azubiListe.Add(Console.ReadLine());
            }

            return azubiListe;
        }

        public static List<string> CleanList(List<string> allTrainees)
        {
            var cleanList = new List<string>();
            foreach (var trainee in allTrainees)
            {
                if (trainee.ToLower().StartsWith("m"))
                {
                    cleanList.Add(trainee);
                }
            }

            return cleanList;
        }
    }
}