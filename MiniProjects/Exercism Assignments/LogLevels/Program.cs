// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string message1 = logLine.Substring(logLine.IndexOf(":") + 1);
        return message1.Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[");
        int endIndex = logLine.IndexOf("]");
        string endString = logLine.Substring(startIndex + 1, endIndex - 1).Trim();
        return endString.ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}

