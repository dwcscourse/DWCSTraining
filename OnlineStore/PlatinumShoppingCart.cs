using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class PlatinumShoppingCart : ShoppingCart
    {
        private int discount = 20;
        protected override decimal CalculateDiscount(decimal sum)
        {
            return sum * discount / 100;
        }
    }
}

