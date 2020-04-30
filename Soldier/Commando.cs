using System;
using System.Collections.Generic;

namespace Soldier
{
    public class Commando : Private, ISpecialisedSoldier
    {
        private Corps corps;
        public Corps Corps
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

        public Commando(int id, string firstName, string lastName, double salary, Corps corps) : base(id, firstName, lastName, salary)
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

        public List<Mission> CreateListOfMissions(string input)
        {
            List<Mission> missions = new List<Mission>();
            string[] missionsInput = input.Split(' ');

            for (int i = 6; i < missionsInput.Length; i += 2)
            {
                if (missionsInput[i + 1] == Convert.ToString(MissionStates.inProgress) || missionsInput[i + 1] == Convert.ToString(MissionStates.Finished))
                {
                    missions.Add(new Mission(missionsInput[i], (MissionStates)Enum.Parse(typeof(MissionStates), missionsInput[i + 1])));
                }
            }

            return missions;
        }

    }
}