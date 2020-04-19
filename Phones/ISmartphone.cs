using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    public interface ISmartphone : IPhone
    {
        string Browse(string webSite);
    }
}
