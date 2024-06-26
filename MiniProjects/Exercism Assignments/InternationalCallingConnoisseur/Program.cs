﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
        throw new NotImplementedException($"Please implement the (static) GetEmptyDictionary() method");
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> prepopulatedCodes = new Dictionary<int, string>()
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
        return prepopulatedCodes;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> newCodes = new Dictionary<int, string>();
        newCodes.Add(countryCode, countryName);
        return newCodes;

    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {

        if (existingDictionary.ContainsKey(countryCode))
        {
            return existingDictionary[countryCode];
        }
        else
        {
            return string.Empty;
        }
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Count > 0)
        {
            return existingDictionary ?.Values.MaxBy(x => x.Length);
        }
        return string.Empty;
    }
}