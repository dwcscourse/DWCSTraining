using System;

namespace CityWithPetsTD
{
    public class Pet : IInhabitantWithBirthday
    {
        private string name;
        private DateTime birthday;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
        }

        public Pet(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
    }
}
