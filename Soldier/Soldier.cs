using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    public abstract class Soldier : ISoldier
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        private string lastName;
        public string LastName
        {
            get 
            {
                return lastName;
            }
        }


        public Soldier(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;         
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {ID} ";
        }
    }
}
