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

        }

        public virtual string Stats()
        {
            string s = $"Here are the stats for {this.name} ";
            s += $"{this.loyalty}/{this.baseStats}";
            s += $"{this.happiness}/{this.baseStats}";
            s += $"{this.hunger}/{this.baseStats}";
            return s;
        }
    }
}