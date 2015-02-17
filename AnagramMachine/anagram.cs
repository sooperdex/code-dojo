using System;
using System.Collections.Generic;

public class Anagram
{
    public static int InputChar(char inputValue)
    {
        return 1;
    }

    public static int InputString(string inputValue)
    {
        int stringLength = inputValue.Length;
        int factorial = 1;

        for(int i=stringLength; i>0; i--)
        {
            factorial = factorial * i;
        }

        return factorial;
    }

    public static string ReturnString(string inputValue)
    {
        return inputValue;
    }

    public static string SwitchString(string inputValue, int sourcePosition, int targetPosition)
    {
            char[] chars = inputValue.ToCharArray();

            char temp = chars[sourcePosition];
            chars[sourcePosition] = chars[targetPosition];
            chars[targetPosition] = temp;
            
            return new string(chars);        
    }

    public static HashSet<string> GetPermeatations(string inputValue)
    {
        HashSet<string> strings = new HashSet<string>();
        strings.Add("1");
        strings.Add("2");
        return strings;
    }

    public static HasheSet<string> BuildList (string newWord)
    { 
        HashSet<string> finalList = new HashSet<string>();
        for (int i =0; i < newWord.Lenght; i++)
    {
        string newString =  switchString(newWord, 0, i+1);
        finalList.Add(newString);
    }
    return finalList;
    }
       
 
}