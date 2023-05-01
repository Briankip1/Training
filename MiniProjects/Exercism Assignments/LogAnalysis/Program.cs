// See https://aka.ms/new-console-template for more information
using System;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string after)
    {
        int start = str.IndexOf(after) + after.Length;
        return str.Substring(start);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string after, string finish)
    {
        int start = str.IndexOf(after) + after.Length;
        int finishAt = str.IndexOf(finish) - start;
        return str.Substring(start, finishAt);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}