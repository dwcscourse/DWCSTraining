using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    public class Smartphone : Phone, ISmartphone
    {
        public string Browse(string webSite)
        {
            if (CheckURL(webSite))
            {
                return $"Browsing: {webSite}!";
            }
            else
            {
                return "Invalid URL!";
            }
        }

        private bool CheckURL(string webSite)
        {
            foreach (Char symbol in webSite)
            {
                if (char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
