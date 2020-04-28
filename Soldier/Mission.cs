using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class Mission
    {
        private string codeName;
        public string CodeName
        {
            get
            {
                return codeName;
            }
        }

        private string state;
        public string State
        {
            get
            {
                return state;
            }
        }

        public Mission(string codeName, string state)
        {
            this.codeName = codeName;
            this.state = state;
        }

        public void CompleteMission()
        {
            state = "Finished";
        }
    }
}
