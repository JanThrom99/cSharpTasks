using System;

namespace AquariumTask
{
    public class Fish
    {
        public string Name;
        public string Form;
        public double AendertTiefe;
        public int Size;
        public int FishHeight;
        public int FishPosition;

        public Fish(string name)
        {
            this.Name = name;
            switch (name)
            {
                case "carp":
                    this.Form = "<><";
                    this.Size = 1;
                    this.AendertTiefe = 0.5;
                    return;
                case "shark":
                    this.Form = "<///====><";
                    this.Size = 4;
                    this.AendertTiefe = 0.25;
                    return;
                case "blowfish":
                    this.Form = "<()><";
                    this.Size = 3;
                    this.AendertTiefe = 0.1;
                    return;
                case "swordfish":
                    this.Form = "-<><";
                    this.Size = 2;
                    this.AendertTiefe = 0.2;
                    return;
            }
        }
        public void GiveFishInfo()
        {
            Console.WriteLine($"Dein Fisch heißt {this.Name} und hat diese Form: {this.Form}");
        }
    }
}
