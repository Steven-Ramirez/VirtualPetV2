using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Dragon : Pets
    {
        public Dragon(string Name, int Loyalty, int Happiness, int Hunger)
        {
            this.name = Name;
            this.loyalty = Loyalty;
            this.happiness = Happiness;
            this.hunger = Hunger;
        }

    }
}