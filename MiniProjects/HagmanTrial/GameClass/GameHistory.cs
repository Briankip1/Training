using System;

namespace GameClass
{

    public class GameHistory

    {
        public string guessLetter { get; }
        public DateTime Date { get; }

        public GameHistory(string enteredguess, DateTime date)
        {
            this.Date = date;
            this.guessLetter = enteredguess;
        }

    }
}