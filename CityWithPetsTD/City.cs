using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityWithPetsTD
{
    public class City
    {
        
        private List<ICitizen> citizens = new List<ICitizen>();
        private List<IInhabitantWithBirthday> inhabitantsWithBirthday = new List<IInhabitantWithBirthday>();

        public List<ICitizen> Citizens 
        {
            get
            {
                return citizens;
            }
        }

        public List<IInhabitantWithBirthday> InhabitantsWithBirthday
        {
            get
            {
                return inhabitantsWithBirthday;
            }
        }

        public void CreateInhabitants(string habitant)
        {
            string[] inhabitantData = habitant.Split(' ');

            if (inhabitantData[0] != "Citizen" && inhabitantData[0] != "Robot" && inhabitantData[0] != "Pet")
            {
                if (inhabitantData.Length == 3)
                {
                    citizens.Add(new Citizen(inhabitantData[0], int.Parse(inhabitantData[1]), inhabitantData[2], DateTime.Now));
                    inhabitantsWithBirthday.Add(new Citizen(inhabitantData[0], int.Parse(inhabitantData[1]), inhabitantData[2], DateTime.Now));
                }
                else if (inhabitantData.Length == 4)
                {
                    citizens.Add(new Citizen(inhabitantData[0], int.Parse(inhabitantData[1]), inhabitantData[2], Convert.ToDateTime(inhabitantData[3])));
                    inhabitantsWithBirthday.Add(new Citizen(inhabitantData[0], int.Parse(inhabitantData[1]), inhabitantData[2], Convert.ToDateTime(inhabitantData[3])));
                }
                else if (inhabitantData.Length == 2)
                {
                    citizens.Add(new Robot(inhabitantData[0], inhabitantData[1]));
                }
                else
                {
                    citizens.Add(new Citizen("Tsveti", 36, "ID123456", new DateTime(1983, 12, 11)));
                }
            }
            else
            {
                if (inhabitantData[0] == "Citizen" || (inhabitantData[0] != "Robot" && inhabitantData[0] != "Pet"  && inhabitantData.Length == 3))
                {
                    citizens.Add(new Citizen(inhabitantData[1], int.Parse(inhabitantData[2]), inhabitantData[3], Convert.ToDateTime(inhabitantData[4])));
                    inhabitantsWithBirthday.Add(new Citizen(inhabitantData[1], int.Parse(inhabitantData[2]), inhabitantData[3], Convert.ToDateTime(inhabitantData[4])));
                }
                else if (inhabitantData[0] == "Pet")
                {
                    inhabitantsWithBirthday.Add(new Pet(inhabitantData[1], Convert.ToDateTime(inhabitantData[2])));
                }
                else if (inhabitantData[0] == "Robot")
                {
                    citizens.Add(new Robot(inhabitantData[1], inhabitantData[2]));
                }
            }

        }

        public List<string> CheckForFakeID(List<ICitizen> inhabitants, string lastDigitsOfFakeID)
        {
            List<string> idsList = new List<string>();

            foreach (ICitizen inhabitant in inhabitants)
            {
                if (inhabitant.ID.EndsWith(lastDigitsOfFakeID))
                {
                    idsList.Add(inhabitant.ID);
                }
            }

            return idsList;
        }

        public List<DateTime> GetBirthdaysForAYear(List<IInhabitantWithBirthday> inhabitantsWithBirthday, int year)
        {
            List<DateTime> birthdaysForAYear = new List<DateTime>();

            foreach (IInhabitantWithBirthday inhabitantWithBirthday in inhabitantsWithBirthday)
            {
                if (inhabitantWithBirthday.Birthday.Year == year)
                {
                    birthdaysForAYear.Add(inhabitantWithBirthday.Birthday);
                }
            }

            return birthdaysForAYear;

        }
    }
}
