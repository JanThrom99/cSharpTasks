using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumTask
{
    public class Aquarium
    {
        public int Height;
        public int Width;
        public string[,] AquariumArray;

        public Aquarium(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            this.AquariumArray = new string[this.Width, this.Height];

            for (int j = 0; j < this.Height; j++)
            {
                for (int i = 0; i < this.Width; i++)
                {
                    if (i == 0 || i == this.Width - 1)
                    {
                        this.AquariumArray[i, j] = "|";
                    }
                    else if (j == this.Height - 1)
                    {
                        this.AquariumArray[i, j] = "_";
                    }
                    else
                    {
                        this.AquariumArray[i, j] = " ";
                    }
                }
            }
        }

        public void ShowAquarium()
        {
            for (int j = 0; j < this.Height; j++)
            {
                for (int i = 0; i < this.Width; i++)
                {
                    Console.Write(this.AquariumArray[i, j]);
                }
                Console.Write("\n");
            }
        }

        public void AddFish(int fishType)
        {
            //TODO Implement
        }
    }
}
