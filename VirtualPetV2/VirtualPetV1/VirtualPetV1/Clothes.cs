using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Clothes : Items
    {
        public Clothes(string Name, int Happiness)
        {
            this.itemName = name;
            this.happinessPoints = Happiness;
        }

        public override string About()
        {
            string s = base.About();
            s += $"{this.itemName} will give your pet {this.happinessPoints} happiness points";
            return s;
        }
    }
}