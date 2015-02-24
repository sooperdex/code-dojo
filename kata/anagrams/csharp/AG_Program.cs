using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            AnagramProcessor anagram = new AnagramProcessor();

            Console.WriteLine("Enter String: ");
            input = Console.ReadLine();

            anagram.ProcessString(input);
        }
    }
}

