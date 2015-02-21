namespace DG_Anagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string originalText = "biro";

            var allPermutations = Permutator.Permute<char>(originalText, originalText.Length);

            PrintPermutations<char>(allPermutations);
        }

        static void PrintPermutations<T>(IEnumerable<IEnumerable<T>> allPermutations)
        {
            foreach (IEnumerable<T> permutation in allPermutations)
            {
                foreach (T item in permutation)
                {
                    Console.Write(item.ToString());
                }

                Console.WriteLine();
            }
        }
    }
}
