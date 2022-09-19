namespace CSharpTasks
{
    public class Rechteck : IGeometry
    {
        public int Seite1 { get; set; }
        public int Seite2 { get; set; }

        public float Flaeche()
        {
            return Seite1 * Seite2;
        }

        public float Umfang()
        {
            return 2 * Seite1 + 2 * Seite2;
        }

        public Rechteck(int seite1, int seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }

        public Rechteck()
        {
            
        }
    }
}
