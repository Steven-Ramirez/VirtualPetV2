using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Food : Items
    {
        public Food(string Name, int Happiness, int Hunger, int Loyalty)
        {
            this.itemName = Name;
            this.happinessPoints = Happiness;
            this.hungerPoints = Hunger;
            this.loyaltyPoints = Loyalty;
        }

        public override string About()
        {
            string s = base.About();
            s += $"{this.itemName} will give {this.happinessPoints} happiness,{this.hungerPoints} hunger, and {this.loyaltyPoints} points";
            return s;
        }
    }
}