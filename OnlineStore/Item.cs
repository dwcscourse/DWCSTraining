using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Item
    {
        private int code;
        private string name;
        private decimal price;

        public Item(int code, string name, decimal price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

        public int Code
        {
            get
            {
                return this.code;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }
    }
}
