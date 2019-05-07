using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public abstract class Pets
    {
        public int loyalty;
        public int happiness;
        public int hunger;
        public string name;

        protected int baseStats = 100;

        public Pets()
        {
            Stats();
        }

        public virtual string Stats()
        {
            string s = $"Here are the stats for {name} \n";
            s += $"Loyalty: {loyalty}/{this.baseStats}\n";
            s += $"Happiness: {happiness}/{this.baseStats}\n";
            s += $"Hunger: {hunger}/{this.baseStats}";
            return s;
        }
    }
}