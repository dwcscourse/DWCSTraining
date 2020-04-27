using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public interface ISoldier
    {
        int ID { get; }
        string FirstName { get; }
        string LastName { get; }

    }
}
