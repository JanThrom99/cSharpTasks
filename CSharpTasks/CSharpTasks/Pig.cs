using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class Pig : Animal
    {
        public new void GeraeuscheMachen()
        {
            Console.WriteLine("*Oink Oink*");
        }

        public Pig(string name, int age, int size, int lifespan, int weight, bool fur)
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
