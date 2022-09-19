using System;

namespace CSharpTasks
{
    public class Dreieck : IGeometry
    {
        public int Seite1 { get; set; }
        public int Seite2 { get; set; }
        //hypothenuse
        public int Seite3 { get; set; }

        public float Umfang()
        {
            return (float)(Seite1 + Seite2 + Seite3);
        }

        public float Flaeche()
        {
            return 2;
        }

        public Dreieck(int seite1, int seite2, int seite3)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }

        public Dreieck()
        {
            
        }
    }
}
