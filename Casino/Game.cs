using System;
using System.Collections.Generic;
using System.Linq;

namespace Casino
{
    class Game
    {
        private Random rnd = new Random();
        private int rounds;
        private List<Player> players;
        public Game(int rounds, List<Player> players)
        {
            this.rounds = rounds;
            this.players = players;
        }

        private string PlayRound(List<Player> players)
        {
            int max = 0;
            string winner = "";
            bool haveWinner = false;

            while (!haveWinner)
            {
                List<int> thrownDices = new List<int>();

                foreach (var player in players)
                {
                    int dice = player.ThrowDice(rnd);
                    thrownDices.Add(dice);

                    Console.WriteLine($"{player.Name} throws {dice}");

                    if (dice > max)
                    {
                        max = dice;
                        winner = player.Name;
                    }                                     
                }

                int countMax = 0;
                foreach (var thrownDice in thrownDices)
                {
                    if (thrownDice == max)
                    {
                        countMax++;
                    }
                }

                if (countMax > 1)
                {
                    haveWinner = false;
                    max = 0;
                    Console.WriteLine("There is duplication. Roll the dice again!");
                }
                else
                {
                    haveWinner = true;
                }
            }

            return winner;
        }

        public string PlayGame()
        {
            List<string> winnersOfRounds = new List<string>();

            for (int i = 1; i <= rounds; i++)
            {
                string winnersOfRound = PlayRound(this.players);
                winnersOfRounds.Add(winnersOfRound);
                Console.WriteLine($"The winner of Round {i} is {winnersOfRound}");
            }

            Dictionary<string, int> dictionary = CountElementsOfList(winnersOfRounds);
            dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int winnerScore = dictionary.ElementAt(0).Value;
            string gameWinner = "";

            List<Player> playersWithSameResults = new List<Player>();

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine($"The score of {pair.Key} is {pair.Value}");
            }

            if ((dictionary.Count > 1) && (dictionary.ElementAt(0).Value == dictionary.ElementAt(1).Value))
            {
                foreach (KeyValuePair<string, int> winner in dictionary)
                {
                    if (winner.Value == winnerScore)
                    {
                        playersWithSameResults.Add(new Player(winner.Key));
                    }
                }

                Console.WriteLine("The players with the same maximum score, play another round !!!!!");
                gameWinner = PlayRound(playersWithSameResults);
            }
            else
            {
                gameWinner = dictionary.ElementAt(0).Key;
            }

            return gameWinner;
        }

        private Dictionary<string, int> CountElementsOfList(List<string> listWithNames)
        {
            listWithNames.Sort();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

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
