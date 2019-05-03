using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Panda : Pets
    {
        public Panda(string Name, int Loyalty, int Happiness, int Hunger)
        {
            this.name = Name;
            this.loyalty = Loyalty;
            this.happiness = Happiness;
            this.hunger = Hunger;
        }
    }
}