using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Treats : Items
    {
        public Treats(string Name, int Happiness, int Loyalty)
        {
            this.itemName = Name;
            this.happinessPoints = Happiness;
            this.loyaltyPoints = Loyalty;
        }

        public override string About()
        {
            string s = base.About();
            s += $"{this.itemName} will give {this.happinessPoints} happiness, and {this.loyaltyPoints} points";
            return s;
        }
    }
}