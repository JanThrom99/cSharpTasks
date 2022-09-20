using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Size { get; set; }
        public int Lifespan { get; set; }
        public int Weight { get; set; }
        public bool Fur { get; set; }


        public void Essen()
        {
            Console.WriteLine($"{Name} isst");
        }

        public void Trinken()
        {
            Console.WriteLine($"{Name} trinkt");
        }

        public void GeraeuscheMachen()
        { }

        public void PrintAnimalInfo()
        {
            if (Fur)
            {
                Console.WriteLine($"Name: {Name}, Alter: {Age}, Größe: {Size}, Lebensdauer: {Lifespan}, Gewicht: {Weight}, hat das Tier Fell: ja");
            }
            else
            {
                Console.WriteLine($"Name: {Name}, Alter: {Age}, Größe: {Size}, Lebensdauer: {Lifespan}, Gewicht: {Weight}, hat das Tier Fell: nein");
            }
            
        }
    }
}
