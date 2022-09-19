using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle( string make, string model, int cCM, string color, int tyres)
        {
            Make = make;
            Model = model;
            CCM = cCM;
            Color = color;
            Tyres = tyres;
        }

        public Motorcycle()
        {

        }
    }
}