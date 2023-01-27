// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
        throw new NotImplementedException("Please implement the static Languages.NewList() method");
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> languages = new List<string>() { "C#", "Clojure", "Elm" };
        return languages;


    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;

    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {

        if (languages.Contains(language))
        {
            return true;
        }
        return false;
    }


    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;

    }

    public static bool IsExciting(List<string> languages)
    {

        if ((languages.Contains("C#") && languages.Count <= 3))
        {
            return true;
        }
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Count() == languages.Distinct().Count();
    }

}
