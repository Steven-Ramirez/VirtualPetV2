using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Ball : Items
    {
        public Ball(string Name, int Happiness)
        {
            this.itemName = Name;
            this.happinessPoints = Happiness;
        }

        public override string About()
        {
            string s = base.About();
            s += $"{this.itemName} will give you {this.happinessPoints} happiness points.";
            return s;
        }
    }
}