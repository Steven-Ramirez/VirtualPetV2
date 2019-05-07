using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Toy : Items
    {
        public Toy(string Name, int Happiness, int Loyalty)
        {
            this.itemName = Name;
            this.happinessPoints = Happiness;
            this.loyaltyPoints = Loyalty;
        }

        public override string About()
        {
            string s = base.About();
            s += $"{this.name} will give your pet {this.happinessPoints} happiness points and {this.loyaltyPoints} loyalty points";
            return s;

        }
    }
}