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
        public List<GameHistory> HistoryTable = new List<GameHistory>();

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

            return RandomWords[random.Next(0, RandomWords.Count)];

        }



        public void HandleGuess()
        {
            //while (Lives != 0)
            //{
            //    Console.Write("Input the guess letter here ..  ");


            //    var key = Console.ReadKey().Key;
            //    string guessLetter = key.ToString().ToLower();


            //    if (Letters.Contains(guessLetter))
            //    {

            //        Console.WriteLine(" You already entered this letter! ");
            //    }



            //    Letters.Add(guessLetter);


            //    if (!ChosenWord.Contains(guessLetter))
            //    {
            //        Lives--;
            //    }
                    Console.WriteLine("Input Letter here: ");
                    var guess = Console.ReadLine().ToString().ToLower();

                    //if (ChosenWord.Contains(guess))
                    //{
                    //    Console.Write(guess);

                    //}
                    Letters.Add(guess);

                    if (!ChosenWord.Contains(guess))
                    {
                        //Console.Write(guess + "_");

                        Lives--;
                        Console.WriteLine($" The letter {guess} is not in the word. You have {Lives} {(Lives == 1 ? "try" : "tries")} left.");

                    }

                    //if (Lives > 0)
                    //{

                    //Console.WriteLine($" The letter {guess} is not in the word. You have {Lives} {(Lives == 1 ? "try" : "tries")} left.");
                    // }
                   //  int charactersLeft = 0;


                  //  foreach (char character in ChosenWord)
                  //  {
                   //     string letter = character.ToString();
                     //   if (Letters.Contains(letter))
                     //   {
                    //        Console.Write(letter);
                    //    }

                    //    else
                    //    {
                    //        Console.Write("_");

                     //       charactersLeft++;
                     //   }
                  //  }

                 //      if (charactersLeft == 0)
                //    {
                 //       break;  
                //    }
                    
                    
               // }

            //if (Lives > 0)
             //   {

            //        Console.WriteLine($"You won with {Lives} {(Lives == 1 ? "life" : "lives")} left!");
             //   }
            //    else
           //    {
                 //   Console.WriteLine($"You lost! The word was {ChosenWord}.");
               // }

        }


        public void CheckingLetters()
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
           // if (charactersLeft == 0)
           // {
             
           // }
            

        }


       public void Outcome()
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

         public string GetGameHistory()
         {
               var gameHistory = new StringBuilder();
               gameHistory.AppendLine("Date \t\t guessLetter");

                foreach(GameHistory guess in HistoryTable)
                {
                    gameHistory.AppendLine($"{guess.Date.ToString()}\t{guess.guessLetter}");
                }

                return gameHistory.ToString();
         }
    }
}


   