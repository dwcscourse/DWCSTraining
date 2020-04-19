using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public abstract class ShoppingCart
    {
        private List<Item> items = new List<Item>();
        
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public decimal CalculateBill()
        {
            decimal sum = 0;

            foreach (Item item in items)
            {
                sum = sum + item.Price;
            }
            return sum - CalculateDiscount(sum);
        }

        protected abstract decimal CalculateDiscount(decimal sum);
    }
}
