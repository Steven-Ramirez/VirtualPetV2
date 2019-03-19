using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Items : Pets
    {
        public int loyaltyPoints;
        public int happinessPoints;
        public int hungerPoints;
        public string itemName;
        public int goldPerItem;


        public Items()
        {

        }

        public virtual string About()
        {
            string s = "";
            return s;
        }


    }
}