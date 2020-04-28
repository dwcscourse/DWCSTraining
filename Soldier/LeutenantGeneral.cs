using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class LeutenantGeneral : Private
    {
        private List<Private> setOfPrivateIDs;

        public List<Private> SetOfPrivateIDs 
        {
            get
            {
                return setOfPrivateIDs;
            }
        }

        public LeutenantGeneral(int id, string firstName, string lastName, double salary, List<Private> privateIds) : base(id, firstName, lastName, salary)
        {
            this.setOfPrivateIDs = privateIds;
        }

        public override string ToString()
        {
            string leutenantGeneralOutpur = "\nPrivate:";

            foreach (var privateID in SetOfPrivateIDs)
            {
                leutenantGeneralOutpur += $"\n Name: {privateID.FirstName} {privateID.LastName} Id: {privateID.ID} Salary: {privateID.Salary:f2}";
            }

            return base.ToString() + leutenantGeneralOutpur;
        }
    }
}
