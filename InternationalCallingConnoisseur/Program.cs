using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        var novoDic = new Dictionary<int, string>();
        return novoDic;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var dic = new Dictionary<int, string>();
        dic.Add(1, "United States of America");
        dic.Add(55, "Brazil");
        dic.Add(91, "India");
        return dic;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dic1 = new Dictionary<int, string>();
        dic1.Add(countryCode, countryName);
        return dic1;

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
        if (existingDictionary.TryGetValue(countryCode, out var countryName))
        {
            return countryName;
        }
        else
        {
            return "";
        }

    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            return true;
        }
        else
        {
            return false;
        }
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
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary.Remove(countryCode);
        }
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestName = "";
        foreach(var countryName in existingDictionary)
        {
            if (countryName.Value.Length > longestName.Length)
            {
                longestName = countryName.Value;
            }
        }return longestName;
    }
}