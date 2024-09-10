using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.ClassLibrary
{
    public class Dice
    {
        Random random = new Random();
        public int Roll(int min, int max)
        {
            return random.Next();
        }
    }
}
