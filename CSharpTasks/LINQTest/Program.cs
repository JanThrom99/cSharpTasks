using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //var rnd = new Random();
            //var newList = new List<int>();
            //for (int i = 0; i < 15; i++)
            //{
            //    newList.Add(rnd.Next(1, 25));
            //}
            //var foo =
            //    from entry in newList
            //    where (entry % 2 == 0)
            //    select entry;
            //Console.WriteLine("alle zahlen: ");
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("alle durch zwei Teilbaren zahlen: ");
            //foreach (var item in foo)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion

            #region Task 2
            //var rnd = new Random();
            //var newList = new List<int>();
            //for (int i = 0; i < 15; i++)
            //{
            //    newList.Add(rnd.Next(1, 25));
            //}
            //var foo =
            //    from entry in newList
            //    where (entry % 2 != 0)
            //    select entry;
            //Console.WriteLine("alle zahlen: ");
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("alle ungeraden zahlen: ");
            //foreach (var item in foo)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion

            #region Task 3 
            //var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            //foreach (var item in arr1)
            //{
            //    if (item*item >20 )
            //    {
            //        Console.WriteLine($"Zahl: {item}, Quadrahtzahl: {item * item}");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region Task 4
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            #endregion

        }
    }
}
