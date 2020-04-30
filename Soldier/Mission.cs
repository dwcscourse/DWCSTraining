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

        private MissionStates state;
        public MissionStates State
        {
            get
            {
                return state;
            }
        }

        public Mission(string codeName, MissionStates state)
        {
            this.codeName = codeName;
            this.state = state;
        }

        public void CompleteMission()
        {
            state = MissionStates.Finished;
        }
    }
}
