using System;

namespace PerformancePunch.FP
{
    public static class GenPredicate
    {
        /// <summary>
        /// MatchCount : Returns the number of elements in a ARRAY that satify 
        /// a given condition. This can be used for quick checks.
        /// 
        /// eg - 10 Customers in ARRAY of Customer(s) of 100 have 
        /// email-addresses provided.
        /// </summary>
        /// 
        /// <typeparam name="T"></typeparam>
        /// 
        /// <param name="arr"></param>
        /// <param name="condition"></param>
        /// <returns>int : Number of Matches found.</returns>
        /// 
        /// <example>
        ///     int numberOfNegativeNumbers = MatchCount(numbers, x => x lt 0);
        ///     
        /// /*LINQ Equivalent */
        ///     int numberOfNegativeNumbers = numbers.Count(x => x lt 0);
        /// </example>
        public static int MatchCount<T>(T[] arr, Predicate<T> condition)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (condition(arr[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
