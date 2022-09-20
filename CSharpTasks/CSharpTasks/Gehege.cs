using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    public class Gehege
    {
        public string GehegeName { get; set; }
        public int GehegeId { get; set; }
        public string TierArt { get; set; }
        public Animal Tier { get; set; }

        public Gehege(string name, int gehegeId, string tierart, Animal tier)
        {
            GehegeName = name;
            GehegeId = gehegeId;
            TierArt = tierart;
            Tier = tier;
        }
    }
}
