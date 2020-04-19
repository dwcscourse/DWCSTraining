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
<<<<<<< HEAD
                int countMax = 0;

                foreach (var player in players)
                {
                    int dice = player.ThrowDice(rnd);

                    Console.WriteLine($"{player.Name} throws {dice}");

                    if (dice == max)
                    {
                        countMax++;
                    }
                    else if (dice > max)
                    {
                        max = dice;
                        winner = player.Name;
                        countMax = 0;
                    }
                }

                if (countMax >= 1)
                {
                    haveWinner = false;
                    max = 0;
                    Console.WriteLine("There is duplication. Roll the dice again!");
                }
                else
                {
                    haveWinner = true;
=======
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
>>>>>>> parent of b06ac3a... HW Tsveti - Casino & Bank Account
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

<<<<<<< HEAD
            Dictionary<string, int> dictionary = CountElementsOfList(winnersOfRounds);

            // Съкратен начин за взимате на максималните стойности от dictionary (групира по value, намиран групата с  най-висока стойност на value И я записва в лист)
            //List<Player> list = dictionary
            //    .GroupBy(x => x.Value)
            //    .Aggregate((x1, x2) => x1.Key > x2.Key ? x1 : x2)
            //    .Select(x => new Player(x.Key)).ToList();


            string gameWinner = "";
            
            List<Player> playersWithSameResults = new List<Player>();

            int countMax = 0;
            int maxWonRounds = 0;

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine($"The score of {pair.Key} is {pair.Value}");
                if (pair.Value > maxWonRounds)
                {
                    maxWonRounds = pair.Value;
                    gameWinner = pair.Key;
                    playersWithSameResults.Add(new Player(pair.Key));
                    countMax = 0;
                }
                else if (pair.Value == maxWonRounds)
                {
                    countMax++;
                    playersWithSameResults.Add(new Player(pair.Key));
                }
            }

            if (countMax >= 1)
            {
                Console.WriteLine("The players with the same maximum score, play another round !!!!!");
                gameWinner = PlayRound(playersWithSameResults);
            }
=======
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
>>>>>>> parent of b06ac3a... HW Tsveti - Casino & Bank Account

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
