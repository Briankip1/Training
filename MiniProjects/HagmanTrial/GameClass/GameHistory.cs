using System;

namespace GameClass
{

    public class GameHistory

    {
        public string guessLetter;
        public DateTime Date;

        public GameHistory(string enteredguess, DateTime date)
        {
            this.Date = date;
            this.guessLetter = enteredguess;
        }

    }
}