using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetV1
{
    public class Store : Pets
    {
        public Items Items;
        public int gold = 100;
        public Pets Pets;
        public bool hasPets;
        public string petName;

        List<Items> ItemList;
        List<Items> OwnedItems;
        List<Pets> PetsList;


        public Store()
        {
            Items = new Items();
            AboutStore();
        }

        public void AboutStore()
        {
            ItemList = new List<Items>();
            ItemList.Add(new Toy("Stuffed Animal", 25, 10));
            ItemList.Add(new Clothes("Buttondown Shirt", 5));
            ItemList.Add(new Ball("Red Ball", 15));
            ItemList.Add(new Treats("Buffalo Treats", 10, 20));
            ItemList.Add(new Food("Hunger Pets", 25, 20, 25));

            Console.WriteLine("Welcome to the Petmart!");
            Console.WriteLine("You have " + gold);
            Console.WriteLine("Would you like to buy a (Dog), (Panda) or a (Dragon)? Each pet is 50 gold");
            Console.WriteLine("Or would you like to shop for (items) or go home?");
            string answer = Console.ReadLine().ToLower();
            PetsList = new List<Pets>();

            if (answer == "dog")
            {
                Console.WriteLine("Great! And what would you like to name your pet?");
                petName = Console.ReadLine();

                PetsList.Add(new Dog(petName, 50, 20, 15));
                hasPets = true;
                gold = gold - 50;
                AboutStore();
            }

            if (answer == "dragon")
            {
                Console.WriteLine("Great! And what would you like to name your pet?");
                petName = Console.ReadLine();

                PetsList.Add(new Dragon(petName, 10, 10, 5));
                hasPets = true;
                gold = gold - 50;
                AboutStore();
            }

            if (answer == "panda")
            {
                Console.WriteLine("Great! And what would you like to name your pet?");
                petName = Console.ReadLine();

                PetsList.Add(new Panda(petName, 50, 20, 15));
                hasPets = true;
                gold = gold - 50;
                AboutStore();
            }

            if (answer == "items")
            {
                ItemStore();
            }

            if (answer == "home")
            {
                Home();
            }

            else if (answer == "")
            {
                Console.WriteLine("Please enter a valid answer");
                AboutStore();
            }


        }

        public void ItemStore()
        {
            foreach (Items i in ItemList)
            {
                Console.WriteLine(i.About());
                if (i is Toy)
                {
                    Console.WriteLine(((Toy)i).About());
                }
            }

            Console.Write("What would you like to buy? Or return to the pet (shop)?: ");
            string answer = Console.ReadLine();
            answer.ToLower();

            if (answer == "1")
            {
                OwnedItems.Add(new Toy("Stuffed Animal", 25, 10));
            }

            if (answer == "2")
            {
                OwnedItems.Add(new Clothes("Buttdown Shirt", 5));
            }

            if (answer == "3")
            {
                OwnedItems.Add(new Ball("Red Ball", 15));

            }

            if (answer == "4")
            {
                OwnedItems.Add(new Treats("Buffalo Treats", 10, 20));
            }

            if (answer == "5")
            {
                OwnedItems.Add(new Food("Hunger Pets", 25, 20, 25));
            }

            if (answer == "shop")
            {
                AboutStore();
            }

        }

        public void Home()
        {
            if (hasPets == false)
            {
                Console.Clear();
                Console.WriteLine("Welcome Home! It seems you don't have any pets! Lets go to the store");
                AboutStore();
            }
            else
            {
                Console.WriteLine("Welcome Home!");
                Console.WriteLine(Stats());
                Console.ReadLine();
            }
        }



    }
}