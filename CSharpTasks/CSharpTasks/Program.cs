using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1 
            var a = 3;
            var b = 4;
            var sum = a + b;
            Console.WriteLine(sum);
            Console.ReadKey();


            //task 2
            Console.WriteLine("welche beiden Zahlen willst du addieren?");
            Console.WriteLine("zahl 1: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zahl 2: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            var addedNumbers = number1 + number2;
            Console.WriteLine("Die Summe ist: "+ addedNumbers);
            Console.ReadKey();

            // task 3 
            Console.WriteLine("gib einen Text ein und ich ersetze alle U's durch G's");
            var userString = Console.ReadLine();
            var replacedUserString = userString.Replace("U", "G").Replace("u", "g");
            Console.WriteLine(replacedUserString);
            Console.ReadKey();


        }
    }
}
