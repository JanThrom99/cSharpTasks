using System;
using System.Collections.Generic;

namespace CSharpTasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dreieck d = new Dreieck(4,5,10);
            //d.Seite1 = 4;
            //d.Seite2 = 5;
            //d.Seite3 = 10;

            Kreis k = new Kreis(5);
            //k.Radius = 5;
            
            Rechteck r = new Rechteck(10,25);
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
            fahrzeuge.Add(new Motorcycle("BMW","1000RR",2490,"rot",2));
            fahrzeuge.Add(new Car(201,"Mercedes","190E",1996,"blau",4));

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


            Console.ReadKey();
        }
    }
}