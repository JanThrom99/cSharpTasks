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

            var foo = new Fish("carp");
            var bar = new Fish("swordfish");
            var foobar = new Fish("blowfish");
            var barfoo = new Fish("shark");

            fishTank.AddFish(foo);
            fishTank.AddFish(bar);
            fishTank.AddFish(foobar);
            fishTank.AddFish(barfoo);

            foo.GiveFishInfo();
            bar.GiveFishInfo();
            foobar.GiveFishInfo();
            barfoo.GiveFishInfo();

            fishTank.FillAquarium();
            fishTank.ShowAquarium();
            Console.ReadKey();
        }
    }
}
