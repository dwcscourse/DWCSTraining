using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class RegularShoppingCart : ShoppingCart
    {               
        protected override decimal CalculateDiscount(decimal sum)
        {
            return 0;
        }
    }
}

