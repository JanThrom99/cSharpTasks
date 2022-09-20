using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class Cat : Animal
    {
        public new void GeraeuscheMachen()
        {
            Console.WriteLine("*Miau*");
        }

        public Cat(string name, int age, int size, int lifespan, int weight, bool fur)
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
