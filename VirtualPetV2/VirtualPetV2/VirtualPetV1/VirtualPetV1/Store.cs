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
        public int gold = 100;
        public Pets Pets;

        List<Pets> PetsList;

        public Store()
        {
            Items = new Items();
        }

        public void List()
        {
            List<Items> ItemList;
            ItemList = new List<Items>();

            ItemList.Add(new Toy("Stuffed Animal", 25, 10));
            ItemList.Add(new Clothes("Buttondown Shirt", 5));
            ItemList.Add(new Ball("Red Ball", 15));
            ItemList.Add(new Treats("Buffalo Treats", 10, 20));
            ItemList.Add(new Food("Hunger Pets", 25, 20, 25));
        }

        public void AboutStore()
        {
            Console.WriteLine("Welcome to the Petmart!");
            Console.WriteLine("You have " + gold);
            Console.WriteLine("Would you like to buy a (Dog), (Panda) or a (Dragon)? Each pet is 50 gold");
            Console.WriteLine("Or would you like to shop for (items)?");
            string answer = Console.ReadLine();
            answer.ToLower();
            gold = gold - 50;

            if (answer == "dog")
            {
                Console.WriteLine("Great! And what would you like to name your pet?");
                Pets.name = Console.ReadLine();

                PetsList.Add(new Dog(Pets.name, 50, 20, 15));
            }

            if (answer == "panda")
            {
                Console.WriteLine("Great! And what would you like to name your pet?");
                Pets.name = Console.ReadLine();

                PetsList.Add(new Dragon(Pets.name, 10, 10, 5));
            }

            else
            {
                Console.WriteLine("Great! And what would you like to name your pet?");
                Pets.name = Console.ReadLine();

                PetsList.Add(new Panda(Pets.name, 50, 20, 15));
            }

        }

        public void Home()
        {

        }



    }
}