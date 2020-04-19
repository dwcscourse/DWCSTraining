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
<<<<<<< HEAD
       
        public int ThrowDice(Random rnd)
=======
        
        public int ThrowDice()
>>>>>>> parent of b06ac3a... HW Tsveti - Casino & Bank Account
        {
            return rnd.Next(1, 7);            
        }
    }
}
