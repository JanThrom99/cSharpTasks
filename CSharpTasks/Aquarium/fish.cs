using System;
using System.Collections.Generic;

namespace AquariumTask
{
    public class Fish
    {
        public string Name;
        public string Form;
        public string ReverseForm;
        public double ChangeDepth;
        public int Size;
        public int FishX;
        public int FishY;

        public Fish(string name)
        {
            this.Name = name;
            switch (name)
            {
                case "carp":
                    this.Form = "<><";
                    this.ReverseForm = "><>";
                    this.Size = 1;
                    this.ChangeDepth = 0.5;
                    this.FishX = 0;
                    this.FishY = 0;
                    return;
                case "shark":
                    this.Form = "<///====><";
                    this.ReverseForm = @"><====\\\>";
                    this.Size = 4;
                    this.ChangeDepth = 0.25;
                    this.FishX = 0;
                    this.FishY = 0;
                    return;
                case "blowfish":
                    this.Form = "<()><";
                    this.ReverseForm = "><()>";
                    this.Size = 3;
                    this.ChangeDepth = 0.1;
                    this.FishX = 0;
                    this.FishY = 0;
                    return;
                case "swordfish":
                    this.Form = "-<><";
                    this.ReverseForm = "><>-";
                    this.Size = 2;
                    this.ChangeDepth = 0.2;
                    this.FishX = 0;
                    this.FishY = 0;
                    return;
            }
        }
        public void GiveFishInfo()
        {
            Console.WriteLine($"Dein Fisch heißt {this.Name} und hat diese Form: {this.Form} bzw ReverseForm: {this.ReverseForm}");
        }
    }
}
