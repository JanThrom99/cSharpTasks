using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public abstract class Vehicle
    {
        public int Tyres { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int CCM { get; set; }
        public bool Motorlaeuft { get; private set; }
        public int Geschwindigkeit { get; private set; }


        public void Starten()
        {
            if (this.Motorlaeuft)
            {
                Console.WriteLine("Mehr als Motor an geht nicht!");
            }
            else
            {
                this.Motorlaeuft = true;
                Console.WriteLine("der Motor ist jetzt an ");
            }
        }

        public void Beschleunigen()
        {
            Geschwindigkeit += 10;
            Console.WriteLine($"{this.GetType().Name} wurde Beschleunigt auf {Geschwindigkeit} Km/h");
        }

        public void Bremsen()
        {
            if (Geschwindigkeit <=0)
            {
                Console.WriteLine($"{this.GetType().Name} steht bereits");
            }
            else
            {
                Geschwindigkeit -= 10;
                Console.WriteLine($"{this.GetType().Name} wird gebremst auf {Geschwindigkeit} Km/h");

            }
        }
    }
}