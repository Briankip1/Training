﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace GameClass
{
    public class Hangman
    {

        public int Lives;
        public string ChosenWord = " ";
        public string guess;
       //public string guessLetter;    
        public List<string> GuessedLetters = new List<string>();
        public List<GameHistory> HistoryTable = new List<GameHistory>();

        public List<string> RandomWords;



        public Hangman(int lives, List<string> rwords)
        {
            this.Lives = lives;
            this.RandomWords = rwords;
            this.ChosenWord = Randomize();
           // ListOfGuesses(guessLetter, DateTime.Now);
        }

        public string Randomize()
        {
            Random random = new Random();

            return RandomWords[random.Next(0, RandomWords.Count)].ToLower();

        }

        public void DisplayProgress()
        {

            int charactersLeft = 0;


            foreach (char character in ChosenWord)
            {
                string letter = character.ToString();

                if (GuessedLetters.Contains(letter))
                {
                    Console.Write(letter);
                } 
                
                else
                {
                    Console.Write(" _ ");
        
                    charactersLeft++;
                }
        
            }      
           // return charactersLeft == 0;  
        }

        public void HandleGuess()
        {
            Console.WriteLine(" Input Letter here: ");
            guess = Console.ReadLine().ToString().ToLower();
            
            if (GuessedLetters.Contains(guess))
            {
                Console.WriteLine(" You already entered the letter "); 
                return;   
            }
             GuessedLetters.Add(guess);

            HistoryTable.Add(new GameHistory(guess, DateTime.Now));
            
            if (!ChosenWord.Contains(guess))
            {
               Lives--;

                if(Lives > 0)
                {
                    Console.WriteLine($" The letter {guess} is not in the word. You have {Lives} {(Lives == 1 ? "try" : "tries")} left.");
                } 
            }      
        }

        public bool CheckForWin()
        {
            int charactersLeft = 0;
            foreach (char character in ChosenWord)
            {
                string ChosenWordLetter = character.ToString();

                if (!GuessedLetters.Contains(ChosenWordLetter))
                {
                    charactersLeft++; ;
                }         
            }
            if(charactersLeft == 0)
            {
                return true;
            }
            return false;     
           
        }

        public string GetGameHistory()
        {
            var gameHistoryTable = new StringBuilder();
            gameHistoryTable.AppendLine("Date \t\t\t guessLetter");

            foreach (var item in HistoryTable)
            {
                gameHistoryTable.AppendLine($"{item.Date}\t\t{item.guessLetter}");
            }
            if (CheckForWin())
            {
                Console.WriteLine($" You won with {Lives} {(Lives == 1 ? "life" : "lives")} left!");
            }
            else 
            { 
                Console.WriteLine($" You lost! The correct word was {ChosenWord}.\n");
            }

            return gameHistoryTable.ToString();
        }
    }
}


   