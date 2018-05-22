using System;
using System.Collections.Generic;

namespace PerformancePunch.FP
{
    public static class FilterData
    {

        /// <summary>
        /// Apply a function f to individual elements from T1 -> T2. 
        /// 
        /// <b>
        /// 'MySelect' is a HOF. A Higher Order Function.
        /// Treating functions as regular objects enables us to use 
        /// them as arguments and results of other functions. 
        /// Functions that handle other functions are 
        /// called higher order functions.
        /// </b>
        /// 
        /// </summary>
        /// 
        /// <typeparam name="T1">The data type to be worked on.
        /// </typeparam>
        /// <typeparam name="T2">the returned data. Filtered/sorted (etc...) 
        /// based on function f.
        /// </typeparam>
        /// 
        /// <param name="data">
        /// List of objects (etc...) crap to work on.
        /// </param>
        /// <param name="f">
        /// the Func that returns T2. 
        /// T2 is the data that you want after applying the rules you want.
        /// </param>
        /// 
        /// <returns>
        /// New IEnumerable<T2> with elements of T1 after being applied the 
        /// provided function f.
        /// </returns>
        /// 
        /// <example>
        /// In this example, the function iterates through the list, <b>applies 
        /// the function f to each element, puts the result in the 
        /// new list, and returns the collection.</b>
        /// By changing function f, you can create various transformations 
        /// of the original sequence using the same generic higher order function. 
        /// 
        /// </example>
        public static IEnumerable<T2> MySelect<T1, T2>
            (this IEnumerable<T1> data, Func<T1, T2> f)
        {
            IList<T2> retVal = new List<T2>();
            foreach (T1 x in data) retVal.Add(f(x));
            return retVal;
        }


        /// <summary>
        /// Compose - will convert Type 1 straight to Type 3.
        /// 
        /// The caller need not worry about the transformation.
        /// Caller can simply request compose to convert objects 
        /// of Type 1 to Type 3 straight.
        /// 
        /// The User - doesnt care: when Marketing turns into sales, 
        /// but they might care about marketing converting 
        /// into after sales service.
        /// 
        /// The chain here would be: Marketing/Lead -> Sales -> After Sales Service.
        /// 
        /// </summary>
        /// 
        /// <typeparam name="T1">Type 1</typeparam>
        /// <typeparam name="T2">Type 2</typeparam>
        /// <typeparam name="T3">Type 3</typeparam>
        /// 
        /// <param name="f">function f: that converts Type 1 to Type 2</param>
        /// <param name="g">function g: that converts Type 2 to Type 3</param>
        /// 
        /// <returns>
        /// Func<T1, T3>: Which means - This function simply converts 
        /// Objects of Type T1 to T3. 
        /// </returns>
        public static Func<T1, T3> Compose<T1, T2, T3>
            (Func<T1, T2> f, Func<T2, T3> g)
        {
            return (x) => g(f(x));
        }


        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2,
                    T3, TResult>(Func<T1, T2, T3, TResult> function)
        {
            return a => b => c => function(a, b, c);
        }

        //var curriedDistance = Curry<double, double, double, double>(Distance);
        //        //double d = curriedDistance(3)(4)(12);

        //static double Distance(double x, double y, double z)
        //{
        //    return Math.Sqrt(x * x + y * y + z * z);
        //}


        //public static Func<X, Z> Compose<X, Y, Z>(Func<X, Y> f, Func<Y, Z> g)
        //{
        //    return (x) => g(f(x));
        //}
        //Func<double, double> sin = Math.Sin;
        //Func<double, double> exp = Math.Exp;
        //Func<double, double> exp_sin = Compose(sin, exp);
        //double y = exp_sin(3);

    }
}
