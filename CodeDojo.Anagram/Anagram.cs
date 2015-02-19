/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 19/02/2015
 * Time: 13:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace CodeDojo.Anagram
{
	/// <summary>
	/// Description of Anagram.
	/// </summary>
	public static class Anagram
	{
        private static bool IsValidIndex(string text, int index)
        {
            return 0 <= index && index < text.Length;
        }

        public static string SwitchLetters(string text, int startPosition, int endPosition)
        {
            char[] textChars = text.ToCharArray();

            if (IsValidIndex(text, startPosition) && IsValidIndex(text, endPosition))
            {
                char tempChar = textChars[startPosition];
                textChars[startPosition] = textChars[endPosition];
                textChars[endPosition] = tempChar;
            }

            return new string(textChars);
        }
        
        public static string ShiftLetters(string text, int count)
        {
        	string result = text;
        	
        	if (IsValidIndex(text, count))
        	{
        		result = text.Substring(count) + text.Substring(0, count);
        	}
        	
        	return result;
        }              
        
        public static IList Process(string text)
        {
        	IList results = new ArrayList();
        	string result;
        	string temp;
        	
        	for(int i=0; i<text.Length; i++)
        	{
	       		temp = Anagram.ShiftLetters(text, i);
        		
	        	for(int j=0; j<temp.Length; j++)
	        	{
	        		for(int k=0; k<temp.Length; k++)
	        		{
	        			result = Anagram.SwitchLetters(temp, j, k);
	        			
	        			if (results.Contains(result) == false)
	        			{
	        				results.Add(result);
	        			}
	        		}        		
	        	}
         	}
        	                
        	return results;
        }
	}
}
