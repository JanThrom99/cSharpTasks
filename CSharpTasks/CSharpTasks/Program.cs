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
            int a = 3;
            int b = 4;
            int sum = a + b;
            Console.WriteLine(sum);
            Console.ReadKey();


            //task 2
            Console.WriteLine("welche beiden Zahlen willst du addieren?");
            Console.WriteLine("zahl 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zahl 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine("Die Summe ist: "+ sum);
        }
    }
}
