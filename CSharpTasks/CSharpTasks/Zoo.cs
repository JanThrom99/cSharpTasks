using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Zoo
    {
        public string Name { get; set; }
        public int GehegeAnzahl { get; set; }
        public List<Gehege> vorhandeneGehege { get; set; }

        public void AddGehege(Gehege newGehege)
        {
            this.vorhandeneGehege.Add(newGehege);
            Console.WriteLine($"{newGehege.GehegeName} wurde hinzugefügt");
            this.GehegeAnzahl += 1;
        }
        
        public Zoo(string name)
        {
            Name = name;
            vorhandeneGehege = new List<Gehege>();
        }

        public void PrintZooInfo()
        {
            Console.WriteLine($"Name: {Name}, Gehege Anzahl: {GehegeAnzahl}");
            foreach (var gehege in vorhandeneGehege)
            {
                Console.WriteLine($"Gehege Name: {gehege.GehegeName}");
            }
        }
    }
}
