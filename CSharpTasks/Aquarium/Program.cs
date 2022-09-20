using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wie hoch soll das aquiarium werden?");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("wie breit soll das aquiarium werden?");
            var width = Convert.ToInt32(Console.ReadLine());

            var fishTank = new Aquarium(height,width);
            fishTank.ShowAquarium();

            var foo = new Fish("carp");
            var bar = new Fish("swordfish");
            foo.GiveFishInfo();
            bar.GiveFishInfo();
            Console.ReadKey();
        }
    }
}
