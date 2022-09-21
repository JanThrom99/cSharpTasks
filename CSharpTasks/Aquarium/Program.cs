using System;

namespace AquariumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wie hoch soll das aquiarium werden? (mindestens 20)");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("wie breit soll das aquiarium werden? (mindestens 20)");
            var width = Convert.ToInt32(Console.ReadLine());

            var fishTank = new Aquarium(height, width);

            var carp = new Fish("carp");
            var shark = new Fish("shark");
            var swordfish = new Fish("swordfish");
            var blowfish = new Fish("blowfish");

            fishTank.Fishes.Add(carp);
            fishTank.Fishes.Add(shark);
            fishTank.Fishes.Add(swordfish);
            fishTank.Fishes.Add(blowfish);

            carp.GiveFishInfo();
            shark.GiveFishInfo();
            swordfish.GiveFishInfo();
            blowfish.GiveFishInfo();

            fishTank.FillAquarium();
            Console.ReadKey();
        }

        
    }
}
