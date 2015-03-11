using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagrams
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Please Enter a String: ");
            string input = Console.ReadLine();

            AnagramProcessor anagramBuilder = new AnagramProcessor();
            IEnumerable<string> results = anagramBuilder.GenerateAnagram(input);
                
            OutputList(results);
        }

        static void OutputList(IEnumerable<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

