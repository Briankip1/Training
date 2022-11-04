using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    public class Hangman
    {



        public int Lives;
        public string ChosenWord = " ";
        public List<string> Letters = new List<string>();

        public List<string> RandomWords;
        
    

        public Hangman(int lives, List<string> rwords)
        {
            this.Lives = lives;
            this.RandomWords = rwords;
            this.ChosenWord = Randomize();
        }

        public string Randomize()
        {
            Random random = new Random();

            return  RandomWords[random.Next(0, RandomWords.Count)];
            
        }

        public void HandleGuess()
        {
            while (Lives != 0)
            {
                Console.Write("Input the guess letter here ..  ");


                var key = Console.ReadKey().Key.ToString().ToLower();


                if (Letters.Contains(key))
                {

                    Console.WriteLine(" You already entered this letter! ");
                }


                Letters.Add(key);


                if (!ChosenWord.Contains(key))
                {
                    Lives--;
                }



                if (Lives > 0)
                {

                    Console.WriteLine($" The letter {key} is not in the word. You have {Lives} {(Lives == 1 ? "try" : "tries")} left.");
                }
            }
        }


        public void CheckingLetters()
        {
            while (Lives != 0)
            {
                int charactersLeft = 0;

                foreach (char character in ChosenWord)
                {
                    string letter = character.ToString();
                    if (Letters.Contains(letter))
                    {
                        Console.Write(letter);
                    }

                    else
                    {
                        Console.Write("_");

                        charactersLeft++;
                    }

                }
                if (charactersLeft == 0)
                {
                    break;
                }
            }
        }

       


        public void  Outcome()
        {
            if (Lives > 0)
            {

                Console.WriteLine($"You won with {Lives} {(Lives == 1 ? "life" : "lives")} left!");
            }
            else
            {
                Console.WriteLine($"You lost! The word was {ChosenWord}.");
            }


        }



    }
}


