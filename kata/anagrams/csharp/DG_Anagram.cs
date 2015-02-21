namespace DG_Anagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> FilterItemAt<T>(this IEnumerable<T> list, int indexToSkip)
        {
            var filteredList = new List<T>();

            filteredList.AddRange(list.TakeWhile((item, index) => index < indexToSkip));
            filteredList.AddRange(list.SkipWhile((item, index) => index <= indexToSkip));

            return filteredList;
        }
    }

    public class Permutator
    {
        public static IEnumerable<IEnumerable<T>> Permute<T>(IEnumerable<T> list, int elementsInTheList)
        {
            if (elementsInTheList == 0)
            {
                yield return new T[0];
            }

			int itemIndex = 0;

			foreach (T item in list)
			{
				IEnumerable<T> remainingItems = list.FilterItemAt(itemIndex);

				foreach (IEnumerable<T> permutationOfRemainder in Permute(remainingItems, elementsInTheList - 1))
				{
					var newList = new List<T>() { item };

					newList.AddRange(permutationOfRemainder);

					yield return newList;
				}

				++itemIndex;
			}
        }
    }
}
