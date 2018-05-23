using System;
using System.Threading.Tasks;

namespace PerformancePunch
{
    public class CreateGenTask : IDisposable
    {

        // Create Tasks


        public Task ActionTaskWith2Params(string arg1, string arg2, Action<string, string> action)
        {
            // Equivalent, but slightly more efficent... StartNew().
            Task _task = Task.Factory.StartNew(() =>
            {
                action(arg1, arg2);
            });

            return _task;
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
