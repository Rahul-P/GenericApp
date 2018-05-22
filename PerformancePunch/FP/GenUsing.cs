using System;

namespace PerformancePunch.FP
{
    public static class GenUsing
    {
        /// <summary>
        /// Use me instead of Using block.      
        /// 
        /// Example usage - obj.Use(  x=> x.DoAction(); x.DoAllYouWantOfMe(); x.SummonSwitchBlockssss(); );
        /// 
        /// </summary>
        /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
        /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
        /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
        /// 
        /// <example>
        ///     obj.Use(x => x.DoAction(); ); where obj implements <see cref="IDisposable"/>
        /// </example>
        public static void Use<T>(this T obj, Action<T> action) where T : IDisposable
        {
            using (obj)
            {
                action(obj);
            }
        }
    }
}
