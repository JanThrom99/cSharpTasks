using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Dog : Animal
    {
        public new void GeraeuscheMachen()
        {
            Console.WriteLine("*Wuff*");
        }

        public Dog(string name, int age, int size, int lifespan, int weight, bool fur)
        {
            Name = name;
            Age = age;
            Size = size;
            Lifespan = lifespan;
            Weight = weight;
            Fur = fur;
        }
    }
}
