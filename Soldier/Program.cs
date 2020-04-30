using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<ISoldier> soldiers = new List<ISoldier>();

            while (input != "End")
            {
                string[] inputData = input.Split(' ');
                if ((inputData[0] != "Engineer" && inputData[0] != "Commando") || ((inputData[0] == "Engineer" || inputData[0] == "Commando") && isCorpsInputCorrect((Corps) Enum.Parse(typeof(Corps),inputData[5])) == true))
                {
                    soldiers.Add(CreateSoldier(input, soldiers));
                }
                input = Console.ReadLine();
            }
            
            foreach (Soldier soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private static Soldier CreateSoldier(string input, List<ISoldier> soldiers)
        {
            string[] inputData = input.Split(' ');
            if (inputData[0] == "Private")
            {
                Private private1 = new Private(int.Parse(inputData[1]), inputData[2], inputData[3], double.Parse(inputData[4]));
                Private.rota = "MyRota";
                return private1;
            }
            else if (inputData[0] == "LeutenantGeneral")
            {

                List<Private> priates = CreateListOfPrivate(input, soldiers);

                LeutenantGeneral leutenantGeneral = new LeutenantGeneral(int.Parse(inputData[1]), inputData[2], inputData[3], double.Parse(inputData[4]), priates);

                return leutenantGeneral;
            }
            else if (inputData[0] == "Engineer")
            {
                Engineer engineer = new Engineer(int.Parse(inputData[1]), inputData[2], inputData[3], double.Parse(inputData[4]), (Corps) Enum.Parse(typeof(Corps), inputData[5]));

                
                engineer.Repairs = engineer.CreateLisfOfRepairs(input);

                return engineer;
            }
            else if (inputData[0] == "Commando")
            {
                Commando commando = new Commando(int.Parse(inputData[1]), inputData[2], inputData[3], double.Parse(inputData[4]), (Corps) Enum.Parse(typeof(Corps),inputData[5]));

                commando.Missions = commando.CreateListOfMissions(input);
                return commando;
            }
            else if (inputData[0] == "Spy")
            {
                return new Spy(int.Parse(inputData[1]), inputData[2], inputData[3], double.Parse(inputData[4]), int.Parse(inputData[5]));
            }
            else
            {
                return new Private(123456789, "Tsveti", "Dimitrova", 100);
            }
        }
      
        private static bool isCorpsInputCorrect(Corps corpInput)
        {
            return corpInput == Corps.Airforces || corpInput == Corps.Marines;
        }

        private static List<Private> CreateListOfPrivate(string input, List<ISoldier> soldiers)
        {
            List<Private> priates = new List<Private>();
            string[] privatesInput = input.Split(' ');
            
            for (int i = 5; i < privatesInput.Length; i++)
            {
                foreach (var soldier in soldiers)
                {
                    if (int.Parse(privatesInput[i]) == soldier.ID)
                    {
                        priates.Add((Private)soldier);
                    }
                }
            }
            return priates;
        }
    }
}
