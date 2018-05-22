using System;

namespace PerformancePunch.FP
{
    public static class Utilities
    {


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">
        /// The type of Object to be returned.
        /// </typeparam>
        /// <param name="func">
        /// The code that returns Type T.
        /// </param>
        /// <param name="cacheInterval">
        /// Time interval in <b>Seconds</b>.
        /// Function <b>func</b> will be executed again after the cacheInterval 
        /// has elapsed.
        /// </param>
        /// <returns></returns>
        /// 
        /// <example>
        /// 
        /// Func<DateTime> now = () => DateTime.Now;
        /// Func<DateTime> nowCached = now.Cache(4);
        ///
        /// Console.WriteLine("\tCurrent time\tCached time");
        /// for (int i = 0; i lt 20; i++)
        /// {
        ///     Console.WriteLine("{0}.\t{1:T}\t{2:T}", i+1, now(), nowCached());
        ///     Thread.Sleep(1000);
        /// }
        /// 
        /// </example>
        public static Func<T> Cache<T>(this Func<T> func, int cacheInterval)
        {
            var cachedValue = func();
            var timeCached = DateTime.Now;

            Func<T> cachedFunc =
                () => {
                    if ((DateTime.Now - timeCached).Seconds >= cacheInterval)
                    {
                        timeCached = DateTime.Now;
                        cachedValue = func();
                    }
                    return cachedValue;
                };

            return cachedFunc;
        }

        // Recursion is the ability that function can call itself
        // https://www.codeproject.com/Articles/375166/Functional-programming-in-Csharp




    }
}
