using System;
using System.Collections.Generic;

namespace AquariumTask
{
    public class Aquarium
    {
        public int Height;
        public int Width;
        public string[,] AquariumArray;
        public List<Fish> Fishes;

        public Aquarium(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            this.Fishes = new List<Fish>();
            this.AquariumArray = new string[this.Width, this.Height];
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

        public void AddFish(Fish fish)
        {
            this.Fishes.Add(fish);
        }

        public void FillAquarium()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            foreach (var fish in this.Fishes)
            {
                fish.FishHeight = rnd.Next(1, this.Height);
                fish.FishPosition = rnd.Next(1, this.Width - 1); ;
                Console.WriteLine(fish.Name + " height: " + fish.FishHeight);
                Console.WriteLine(fish.Name + " position:  " + fish.FishPosition);
                foreach (var fish1 in this.Fishes)
                {
                    if (fish1.FishPosition == fish.FishPosition)
                    {
                        do
                        {
                            fish1.FishPosition = rnd.Next(1, this.Width - 1) - rnd.Next(2, 5);
                        } while (fish1.FishPosition > this.Width - 1 || fish1.FishPosition < 0);
                    }
                }
            }

            for (int i = 0; i < this.Fishes.Count - 1; i++)
            {
                if (this.Fishes[i].FishPosition == this.Fishes[i + 1].FishPosition)
                {
                    this.Fishes[i].FishPosition = rnd.Next(1, this.Width - 1) - rnd.Next(2, 5);
                }
            }




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
                    foreach (var fish in this.Fishes)
                    {
                        if (fish.FishHeight == j)
                        {
                            var counter = 0;
                            var fishFormSplit = fish.Form.ToCharArray();
                            foreach (var splitEntry in fishFormSplit)
                            {
                                this.AquariumArray[fish.FishPosition + counter, j] = splitEntry.ToString();
                                counter++;
                            }
                        }
                    }
                }
            }
        }
    }
}
