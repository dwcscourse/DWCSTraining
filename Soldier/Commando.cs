using System.Collections.Generic;

namespace Soldier
{
    public class Commando : Private, ISpecialisedSoldier
    {
        private string corps;
        public string Corps
        {
            get 
            {
                return corps;
            }

        }

        private List<Mission> missions;
        public List<Mission> Missions
        {
            get
            {
                return missions;
            }
            set
            {
                missions = value;
            }
        }

        public Commando(int id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.corps = corps;
        }

        public override string ToString()
        {
            string commandoOutput = $"\nCorps: {corps} \nMissions:";

            foreach (var mission in missions)
            {
                commandoOutput += $"\n Code Name: {mission.CodeName} State: {mission.State}";
            }

            return base.ToString() + commandoOutput;
        }
    }
}