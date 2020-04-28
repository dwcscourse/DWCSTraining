using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityWithPetsTD
{
    public class Citizen : IInhabitantWithBirthday, ICitizen
    {
        private string name; 
        public string Name
        {
            get
            {
                return name;
            }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get 
            {
                return birthday;
            }
        }

        int age;

        private string id;
        public string ID
        {
            get 
            {
                return id;
            }
        }

        public Citizen(string name, int age, string id, DateTime birthday)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthday = birthday;
        }
    }
}
