using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string client;
            int choice = 0;
            ClientType type = ClientType.regular;
            bool shouldContinue = true;
            RegularShoppingCart regCart = new RegularShoppingCart();
            PremiumShoppingCart premCart = new PremiumShoppingCart();
            PlatinumShoppingCart platCart = new PlatinumShoppingCart();
            
            List<Client> clients = new List<Client>()
            {
                new Client("Bella", ClientType.platinum),
                new Client("Ana", ClientType.regular),
                new Client("Tsvety", ClientType.premium)
            };

            List<Item> items = new List<Item>()
            {
                new Item(1, "bread", 1.20m),
                new Item(2, "rice", 2.20m),
                new Item(3, "toilet paper", 5),
                new Item(4, "water", 3.50m),
                new Item(5, "wine", 10),
            };

            Console.WriteLine("Client name:");
            client = Console.ReadLine();
            foreach (Client item in clients)
            {
                if(client == item.Name)
                {
                    type = item.Type;
                }
            }
            Console.WriteLine("List: \n 1.Bread \n 2.Rice \n 3.Toilet Paper \n 4.Water \n 5.Wine \n 6.Stop shopping");
            do
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (type == ClientType.regular)
                        {
                            regCart.AddItem(items[0]);
                        }
                        else if (type == ClientType.premium)
                        {
                            premCart.AddItem(items[0]);
                        }
                        else if (type == ClientType.platinum)
                        {
                            platCart.AddItem(items[0]);
                        }
                        break;
                    case 2:
                        if (type == ClientType.regular)
                        {
                            regCart.AddItem(items[1]);
                        }
                        else if (type == ClientType.premium)
                        {
                            premCart.AddItem(items[1]);
                        }
                        else if (type == ClientType.platinum)
                        {
                            platCart.AddItem(items[1]);
                        }
                        break;
                    case 3:
                        if (type == ClientType.regular)
                        {
                            regCart.AddItem(items[2]);
                        }
                        else if (type == ClientType.premium)
                        {
                            premCart.AddItem(items[2]);
                        }
                        else if (type == ClientType.platinum)
                        {
                            platCart.AddItem(items[2]);
                        }
                        break;
                    case 4:
                        if (type == ClientType.regular)
                        {
                            regCart.AddItem(items[3]);
                        }
                        else if (type == ClientType.premium)
                        {
                            premCart.AddItem(items[3]);
                        }
                        else if (type == ClientType.platinum)
                        {
                            platCart.AddItem(items[3]);
                        }
                        break;
                    case 5:
                        if (type == ClientType.regular)
                        {
                            regCart.AddItem(items[4]);
                        }
                        else if (type == ClientType.premium)
                        {
                            premCart.AddItem(items[4]);
                        }
                        else if (type == ClientType.platinum)
                        {
                            platCart.AddItem(items[4]);
                        }
                        break;
                    case 6:
                        shouldContinue = false;
                        break;
                }
            } while (shouldContinue);

            if (type == ClientType.regular)
            {
                Console.WriteLine(regCart.CalculateBill());
            }
            else if (type == ClientType.premium)
            {
                Console.WriteLine(premCart.CalculateBill());  
            }
            else if (type == ClientType.platinum)
            {
                Console.WriteLine(platCart.CalculateBill());
            }

        }
    }
}
