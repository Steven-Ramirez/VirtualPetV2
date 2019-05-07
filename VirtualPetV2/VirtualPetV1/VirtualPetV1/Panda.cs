using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Panda : Pets
    {
        public Panda()
        {
           
        }

        public Panda(string Name, int Loyalty, int Happiness, int Hunger)
        {
            this.name = Name;
            this.loyalty = Loyalty;
            this.happiness = Happiness;
            this.hunger = Hunger;
        }

        public override string Stats()
        {
            string s = $"Here are the stats for {name} \n";
            s += $"Loyalty: {loyalty}/{this.baseStats}\n";
            s += $"Happiness: {happiness}/{this.baseStats}\n";
            s += $"Hunger: {hunger}/{this.baseStats}";
            return s;
        }
    }
}