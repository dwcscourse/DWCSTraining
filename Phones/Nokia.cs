using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    public class Nokia : ISmartphone
    {
        public string Browse(string webSite)
        {
            return $"Nokia Browse: {webSite}";
        }

        public string Calling(string number)
        {
            return $"Nokia Calling {number}";
        }

        public string ConnectingPeople()
        {
            return "Connecting People!";
        }
    }
}
