using System;

namespace CSharpTasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            House foo = new House(16, 8, 10, 45, 50, "reetgedeckt", "grün", 3, 350000);

            foo.CalculateLivingArea();
            foo.CalculatePropertySize();
            foo.ChangeColor("rot");
            foo.PrintProperties();
            Console.ReadKey();
        }
    }
}