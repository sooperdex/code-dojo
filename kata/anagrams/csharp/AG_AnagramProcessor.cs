using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class AnagramProcessor
    {
        public  IEnumerable<string> GenerateAnagram(string anagramString)
        {
            if (anagramString.Length == 0) yield break;
            if (anagramString.Length == 1) yield return anagramString;

            foreach (string rest in GenerateAnagram(anagramString.Substring(1)))
            {
                for (int i = 0; i < anagramString.Length; i++)
                {
                    string temp = rest.Substring(0, i) + anagramString[0] + rest.Substring(i);
                    yield return temp;
                }
            }
        }
    }
}

