using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public class LeutenantGeneral : Private
    {
        private List<Private> setOfPrivates;

        public List<Private> SetOfPrivates 
        {
            get
            {
                return setOfPrivates;
            }
        }

        public LeutenantGeneral(int id, string firstName, string lastName, double salary, List<Private> privates) : base(id, firstName, lastName, salary)
        {
            this.setOfPrivates = privates;
        }

        public override string ToString()
        {
            string leutenantGeneralOutpur = "\nPrivate:";

            foreach (var privateID in SetOfPrivates)
            {
                leutenantGeneralOutpur += $"\n Name: {privateID.FirstName} {privateID.LastName} Id: {privateID.ID} Salary: {privateID.Salary:f2}";
            }

            return base.ToString() + leutenantGeneralOutpur;
        }
    }
}
