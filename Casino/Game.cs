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

        public void PlayRound()
        {
            int max=0;
            string winner;
            bool isDuplicate = true;
            while (isDuplicate == true)
            {
                foreach (Player player in players)
                {
                    int dice = player.ThrowDice();
                    if (dice > max)
                    {
                        max = dice;
                    }
                    else if (dice == max)
                    {
                        isDuplicate = false;
                    }
                }
            }
        }
    }
}
