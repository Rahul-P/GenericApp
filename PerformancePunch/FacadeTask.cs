using System;
using System.Threading.Tasks;

namespace PerformancePunch
{
    /// <summary>
    /// Facade Tasks - Pronounced as FASssAaDE Tasks.
    /// Facade Task lack of Explicit code during task creation. 
    /// It is assumed that the computation is specified elsewhere and is already running such as a Network request.
    /// 
    /// Why provide a Facade Task?
    /// To provide a common object model (a.k.a TASK) for interfacing with both Asynchronous and Parallel Operations.
    /// 
    /// FacadeTask is a Facade Task.
    /// This will wrap all calls going out of our application to 3rd parties REST APIs. 
    /// </summary>
    public class FacadeTask : IDisposable
    {

        /// <summary>
        /// 
        /// 
        /// </summary> 
        /// <param name="action">The code as Action that will be executed as a Task.</param>
        /// <returns>TResult - Object of TResult.</returns>
        public Task RunAsFacadeTask<TResult>(object state)
        {
            using (this)
            {
                TaskCompletionSource<TResult> tc = new TaskCompletionSource<TResult>(state);
                return tc.Task;
            }
        }


        #region IDisposable Support

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
