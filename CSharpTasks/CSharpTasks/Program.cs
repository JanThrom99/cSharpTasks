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
            //var a = 3;
            //var b = 4;
            //var sum = a + b;
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //task 2
            //Console.WriteLine("welche beiden Zahlen willst du addieren?");
            //Console.WriteLine("zahl 1: ");
            //var number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("zahl 2: ");
            //var number2 = Convert.ToInt32(Console.ReadLine());
            //var addedNumbers = number1 + number2;
            //Console.WriteLine("Die Summe ist: " + addedNumbers);
            //Console.ReadKey();

            //task 3 
            //Console.WriteLine("gib einen Text ein und ich ersetze alle U's durch G's");
            //var userString = Console.ReadLine();
            //var replacedUserString = userString.Replace("U", "G").Replace("u", "g");
            //Console.WriteLine(replacedUserString);
            //Console.ReadKey();

            //task 4
            //Console.WriteLine("gib einen Text ein und ich sage dir wie lang er ist");
            //var uString = Console.ReadLine();
            //var lengthWithSpaces = uString.Length;
            //var lengthWithoutSpaces = uString.Replace(" ", "").Length;
            //Console.WriteLine("Länge mit Leerzeichen: " + lengthWithSpaces);
            //Console.WriteLine("Länge ohne Leerzeichen: " + lengthWithoutSpaces);
            //Console.ReadKey();

            //task 2b
            //Console.WriteLine("welche beiden Fließkomma Zahlen willst du addieren?");
            //Console.WriteLine("zahl 1: ");
            //var number11 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("zahl 2: ");
            //var number22 = Convert.ToDouble(Console.ReadLine());
            //var addedDoubles = number11 + number22;
            //Console.WriteLine("Die Summe ist: " + addedDoubles);
            //Console.ReadKey();

            //task 5
            //Console.WriteLine("gib einen Text ein");
            //var uString = Console.ReadLine();
            //var newString = uString.PadLeft(20,'y');
            //Console.WriteLine(newString);
            //Console.ReadKey();

            //task 6
            //Console.WriteLine("gib einen Text ein");
            //var uString = Console.ReadLine();
            //var newString = uString.PadRight(30, 'y');
            //Console.WriteLine(newString);
            //Console.ReadKey();

            //task 7
            Console.WriteLine("gib einen Text mit Leerzeichen am Anfang und am Ende ein");
            var uString = Console.ReadLine();
            var newString = uString.Trim();
            Console.WriteLine(":"+newString+":");
            Console.ReadKey();
        }
    }
}
