using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    public class Phone : IPhone
    {
        public string Calling(string number)
        {
            if (CheckNumber(number))
            {
                return $"Calling ... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }

        private bool CheckNumber(string number)
        {
            foreach (Char symbol in number)
            {
                if (char.IsLetter(symbol))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
