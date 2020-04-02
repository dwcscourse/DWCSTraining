using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());
            int numberOfRounds = int.Parse(Console.ReadLine());

            List<Player> players = new List<Player>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter player name: ");

                players.Add(new Player(Console.ReadLine()));
            }

            Game game = new Game(numberOfRounds, players);

            string winner = game.PlayGame();

            Console.WriteLine(winner);




        }
    }
}
