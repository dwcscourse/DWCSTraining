using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Player
    {
        private Random rnd = new Random();
        private string name;
        public Player(string name)
        {
            this.name = name;
        }
        public string Name 
        {
            get 
            {
                return this.name;
            }
        }
        
        public int ThrowDice()
        {
            return rnd.Next(1, 7);            
        }
    }
}
