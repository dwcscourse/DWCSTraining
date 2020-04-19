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
            ClientType type = ClientType.regular;

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
                if (client == item.Name)
                {
                    type = item.Type;
                }
            }

            ShoppingCart cart = GetCart(type);

            Console.WriteLine("List: \n 1.Bread \n 2.Rice \n 3.Toilet Paper \n 4.Water \n 5.Wine \n 6.Stop shopping");

            string[] inputItems = Console.ReadLine().Split(',');

            foreach (string item in inputItems)
            {
                int number = int.Parse(item);
                cart.AddItem(items[number - 1]);
            }

            Console.WriteLine(cart.CalculateBill());
        }

        private static ShoppingCart GetCart(ClientType clientType)
        {
            if (clientType == ClientType.regular)
            {
                return new RegularShoppingCart();
            }
            else if (clientType == ClientType.premium)
            {
                return new PremiumShoppingCart();
            }
            else if (clientType == ClientType.platinum)
            {
                return new PlatinumShoppingCart();
            }
            return new RegularShoppingCart();
        }
    } 
}
