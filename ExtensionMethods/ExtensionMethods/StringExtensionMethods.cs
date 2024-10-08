using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.ExtensionMethods;
public static class StringExtensionMethods
{
    public static string CapitalizeFirstLetter(this string inputString)
    {
        if (string.IsNullOrEmpty(inputString)) { return inputString; }
        char firstLetter = char.ToUpper(inputString[0]);
        string remainder = "";

        if (inputString.Length > 1) { remainder = inputString.Substring(1, inputString.Length - 1); };
        return firstLetter + remainder;
    }

    public static int GetWordCount(this string inputString)
    {
        return inputString.Split(" ".ToCharArray()).Count();
    }


    //very hard to read
    public static string ROT13(this string input)
    {
        return !string.IsNullOrEmpty(input) ? new string(input.ToCharArray().Select(s => { return (char)(s >= 97 && s <= 122 ? s + 13 > 122 ? s - 13 : s + 13 : s >= 65 && s <= 90 ? s + 13 > 90 ? s - 13 : s + 13 : s); }).ToArray()) : input;
    }

     //Easier to read, but may be detected as a trojan by some antivirus software
    //public static string ROT13UnBuildable(this string inputString)
    //{
    //    if (string.IsNullOrEmpty(inputString)) return inputString;

    //    char[] buffer = new char[inputString.Length];

    //    for (int i = 0; i < inputString.Length; i++)
    //    {
    //        char c = inputString[i];
    //        if (c >= 97 && c <= 122)
    //        {
    //            int j = c + 13;
    //            if (j > 122) j -= 26;
    //            buffer[i] = (char)j;
    //        }
    //        else if (c >= 65 && c <= 90)
    //        {
    //            int j = c + 13;
    //            if (j > 90) j -= 26;
    //            buffer[i] = (char)j;
    //        }
    //        else { buffer[i] = c; }
    //    }
    //    return new string(buffer);
    //}
}
