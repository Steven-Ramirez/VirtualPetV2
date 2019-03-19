using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Dog : Pets
    {
        public Dog(int Loyalty, int Happiness, int Hunger)
        {
            this.loyalty = Loyalty;
            this.happiness = Happiness;
            this.hunger = Hunger;
        }

    }
}