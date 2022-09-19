using System;

namespace CSharpTasks
{
    public class Kreis : IGeometry
    {
        public float Radius { get; set; }

        public float Umfang()
        {
            return 2 * (float)Math.PI * Radius;
        }

        public float Flaeche()
        {
            return (float)Math.PI * Radius * Radius;
        }

        public Kreis()
        {
            
        }

        public Kreis(float radius)
        {
            Radius = radius;
        }
    }
}
