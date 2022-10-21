using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
    
{
    
    internal class GameControls
    {
        public string[] household;
        char[] character;

        public string randomWords()
        {
            Random words = new Random();
            words.Next(words.Length);
        }

        public string Splitwords()
        {
            for (int i = 0; i < household.Length; i++)
            {
                char[] character = household[i].ToCharArray();

                if ()

        }
        }
    }
}
