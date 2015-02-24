using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class AnagramProcessor
    {
        char[] anagramScramble;
        List<string> anagramDictionary = new List<string>();

        public void ProcessString(string inputString)
        {
            int arrayLength;

            anagramScramble = inputString.ToArray();
            arrayLength = anagramScramble.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                ShiftArray(anagramScramble, arrayLength);
            }

            ShowDictionary();
        }

        void ShiftArray(char[] baseAnagram, int baseLength)
        {
            char[] amendedAnagram = new char[baseLength + 1];
            char[] tempAnagram = new char[baseLength + 1];

            for (int si = 0; si < baseLength; si++)
            {
                Array.Copy(baseAnagram, tempAnagram, baseLength);
                Array.Copy(tempAnagram, si, amendedAnagram, si + 1, 1);
            }

            Array.Copy(amendedAnagram, baseLength, amendedAnagram, 0, 1);
            Array.Resize(ref amendedAnagram, baseLength);

            string shiftedAnagram = new string(amendedAnagram);
            anagramDictionary.Add(shiftedAnagram.ToString());

            anagramScramble = amendedAnagram;
        }

        void ShowDictionary()
        {
            foreach (string word in anagramDictionary)
            {
                Console.WriteLine(word);
            }
        }
    }
}

