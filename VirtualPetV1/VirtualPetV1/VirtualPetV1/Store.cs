using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetV1
{
    public class Store
    {
        public Items Items;

        public Store()
        {
            Items = new Items();
        }

        public void ItemList()
        {
            List<Items> ItemList;
            ItemList = new List<Items>();

            ItemList.Add(new Toy("Stuffed Animal", 25, 10));
            ItemList.Add(new Clothes("Buttondown Shirt", 5));
            ItemList.Add(new Ball("Red Ball", 15));
            ItemList.Add(new Treats("Buffalo Treats", 10, 20));
            ItemList.Add(new Food("Hunger Pets", 25, 20, 25));

        }

        

    }
}