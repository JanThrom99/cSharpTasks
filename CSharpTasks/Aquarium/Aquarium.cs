using System;
using System.Collections.Generic;
using System.Threading;

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

        //print out the aquarium array
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

        public void FillAquarium()
        {
            

            //generate number for random fish position
            Random rnd = new Random((int)DateTime.Now.Ticks);
            foreach (var fish in this.Fishes)
            {
                //only generate new X and Y coordinates when the fish doesnt have any
                
                    fish.FishX = rnd.Next(1, this.Height);
                    fish.FishY = rnd.Next(1, this.Width - 1); ;
                
                Console.WriteLine(fish.Name + " height: " + fish.FishX);
                Console.WriteLine(fish.Name + " position:  " + fish.FishY);
                foreach (var fish1 in this.Fishes)
                {
                    if (fish1.FishY == fish.FishY)
                    {
                        //assign random fish positions 
                        do
                        {
                            fish1.FishY = rnd.Next(1, this.Width - 1) - rnd.Next(2, 5);
                        } while (fish1.FishY > this.Width - 1 || fish1.FishY < 0);
                    }
                }
            }
            // check if positions are the same -> if so change them
            for (int i = 0; i < this.Fishes.Count - 1; i++)
            {
                if (this.Fishes[i].FishY == this.Fishes[i + 1].FishY)
                {
                    this.Fishes[i].FishY = rnd.Next(1, this.Width - 1) - rnd.Next(2, 5);
                }
            }
            do
            {
                Console.Clear();
                //fill the aquarium array with content 
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
                        //iterate over fishes and put them in the array
                        foreach (var fish in this.Fishes)
                        {
                            if (fish.FishX == j)
                            {
                                // write the fish in the array (counter used to write the fish char for char
                                var counter = 0;
                                var fishFormSplit = fish.Form.ToCharArray();
                                foreach (var splitEntry in fishFormSplit)
                                {
                                    this.AquariumArray[fish.FishY + counter, j] = splitEntry.ToString();
                                    counter++;
                                }
                            }
                        }
                    }
                }
                ShowAquarium();
                foreach (var fish in this.Fishes)
                {

                    fish.FishY--;
                }
                Thread.Sleep(1000);

            } while (true);

        }
    }
}
// TODO IMPLEMENT THAT FISHES TURN AROUND 