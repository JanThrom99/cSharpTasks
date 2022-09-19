using System;
using System.Runtime.CompilerServices;

namespace CSharpTasks
{
    public class House
    {
        public float HouseLength { get; set; }
        public float HouseWidth { get; set; }
        public int HouseHeight { get; set; }
        public float PropertyLength { get; set; }
        public float PropertyWidth { get; set; }
        public string RoofType { get; set; }
        public string Color { get; set; }
        public float Stories { get; set; }
        public decimal Price { get; set; }
        public int PropertySize { get; private set; }
        public int LivingArea { get; private set; }

        public House(float houseLength, int houseHeight, float houseWidth, float propertyLength, float propertyWidth, string roofType, string color, int stories, decimal price )
        {
            HouseHeight = houseHeight;
            HouseLength = houseLength;
            HouseWidth = houseWidth;
            PropertyLength = propertyLength;
            PropertyWidth = propertyLength;
            RoofType = roofType;
            Color = color;
            Stories = stories;
            Price = price;
        }

        public void CalculatePropertySize()
        {
            PropertySize = Convert.ToInt32(PropertyLength * PropertyWidth);
            Console.WriteLine(PropertySize);
        }

        public void CalculateLivingArea()
        {
            LivingArea =  Convert.ToInt32(HouseLength * HouseWidth* Stories);
            Console.WriteLine(LivingArea);
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
            Console.WriteLine($"Das Haus wurde in {newColor} neu gestrichen");
        }

        public void PrintProperties()
        {
            Console.WriteLine($"hier hast du die Eigenschaften deines Hauses: " +
                                     $"\n Hauslänge: {HouseLength} " +
                                     $"\n Hausbreite: {HouseWidth} " +
                                     $"\n Hausbreite: {HouseLength} " +
                                     $"\n PropertyLength: {PropertyLength}" +
                                     $"\n PropertyWidth: {PropertyWidth}" +
                                     $"\n RoofType: {RoofType}" +
                                     $"\n Color: {Color}" +
                                     $"\n Stories: {Stories}" +
                                     $"\n Price: {Price}");
        }
    }
}