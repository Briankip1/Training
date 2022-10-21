using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    public class Player
    {
        public string FirstName;
        public string LastName;
        public bool Win;
        public string guessLetter;

            public string Move1()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|-");
                    return guessLetter;
                }
                else
                {
                    Console.WriteLine("It is the correct letter.. continue");
                    return guessLetter;
                }
            }

            public string Move2()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|--");
                    return guessLetter;
                }
                else
                {
                    Console.WriteLine("It is the correct letter.. continue");
                    return guessLetter;
                }
            }

            public string Move3()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|---");
                    return guessLetter;
                }
                else
                {
                    Console.WriteLine("It is the correct letter.. continue");
                    return guessLetter;
                }
            }

            public string Move4()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|----");
                    return guessLetter;
                }
                else
                {
                    Console.WriteLine("It is the correct letter.. continue");
                    return guessLetter;
                }
            }

            public string Move5()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|-----");
                    return guessLetter;
                }
                else
                {
                    Console.WriteLine("It is the correct letter.. continue");
                    return guessLetter;
                }
            }

            public string Move6()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|------");
                    return guessLetter;
                }
                else
                {
                    Console.WriteLine("It is the correct letter.. continue");
                    return guessLetter;
                }
            }

            public void Move7()
            {
                if (guessLetter != character)
                {
                    Console.WriteLine("___|------0");
                    Console.WriteLine("Game Over \nPress Any Key to Try Again\n");
                    Console.ReadKey();
                }
            }

            public Player(string first, string last, bool w)
            {
                FirstName = first;
                LastName = last;
                Win = w;

            }
     
    

}

}

