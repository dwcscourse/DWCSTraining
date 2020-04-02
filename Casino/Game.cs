using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Game
    {
        private int rounds;
        private List<Player> players;
        public Game(int rounds, List<Player> players)
        {
            this.rounds = rounds;
            this.players = players;
        }

        private string PlayRound()
        {
            int max=0;
            string winner = "";
            bool isDuplicate = true;

            while (!isDuplicate)
            {
                foreach (Player player in players)
                {
                    int dice = player.ThrowDice();
                    if (dice > max)
                    {
                        max = dice;
                        winner = player.Name;
                    }
                    else if (dice == max)
                    {
                        isDuplicate = true;
                    }               
                }
            }
                return winner;
        }

        public string PlayGame()
        {
            List<string> winnersOfRounds = new List<string>();
            var dictionary = CountElementsOfList(winnersOfRounds);

            for (int i = 1; i <= rounds; i++)
            {
                winnersOfRounds.Add(PlayRound());                  
            }

            int temp = 0;
            string gameWinner = "";
           
            foreach (KeyValuePair<string, int> winner in dictionary)
            {
                if (temp < winner.Value)
                {
                    temp = winner.Value;
                    gameWinner = winner.Key;
                }                
            }
            
            //Add case with two winners

            return gameWinner;
        }

        private Dictionary<string, int> CountElementsOfList(List<string> listWithNames)
        {
            listWithNames.Sort();
            var dictionary = new Dictionary<string, int>();
            
            foreach (var name in listWithNames)
            {
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, 1);
                }
                else
                {
                    dictionary.TryGetValue(name, out int count);
                    dictionary[name] = count + 1;                 
                }
            }

            return dictionary;
        }           
    }
}
