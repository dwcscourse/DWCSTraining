using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class PremiumShoppingCart : ShoppingCart
    {
        private int discount = 10;
        protected override decimal CalculateDiscount(decimal sum)
        {
            return sum * discount / 100;
        }
    }
}
