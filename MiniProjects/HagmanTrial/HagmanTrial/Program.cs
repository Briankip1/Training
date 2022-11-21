// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// a pool words to be randomized, in form of an array
using GameClass;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Collections;
using System.ComponentModel;

//Console.WriteLine("Enter the guess characters below...");
//Console.ReadLine();

public class Program
{
    public static void Main(string[] args)
    {
       // Console.Write("Input a letter here ...");
        var RandomWords = new List<string>()
        {
            "apples",
            "kiwi",
            "Avocado"
        };

        Hangman GameOne = new Hangman(6, RandomWords);
        // condition to break the loop if the correct word is guessed 
        var correctWord = false;

        while(GameOne.Lives !=0 && correctWord != true)
        {
            GameOne.DisplayProgress(); 

            GameOne.HandleGuess();

            correctWord = GameOne.CheckForWin();
        }
       

        Console.WriteLine(GameOne.GetGameHistory());
        Console.ReadLine();    
    }
}