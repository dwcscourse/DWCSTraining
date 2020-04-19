using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Client
    {
        private string name;
        private ClientType type;

        public Client(string name, ClientType type)
        {
            this.name = name;
            this.type = type;
        }

        public ClientType Type
        {
            get
            {
                return this.type;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}
