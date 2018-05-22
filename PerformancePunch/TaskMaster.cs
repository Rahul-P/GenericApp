using PerformancePunch.FP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PerformancePunch
{
    /// <summary>
    /// Task == a unit of work; an object denoting an ongoing [CPU bound] operation or computation.
    /// Task == object representing an ongoing computation.
    /// Tasks are objects - you can check status, wait, harvest results, store exceptions (etc...).
    /// 
    /// VanTask denotes a unit of work, an ongoing computation.
    /// VanTask is a CODE TASK.
    /// 
    /// YOUR JOB as DEVELOPER - is to create VanTasks (well, tasks!)
    /// .NET's JOB is to execute tasks as efficiently as possible.
    /// 
    /// This class has been designed based on the work of Dr. Joe Hummel, PhD.
    /// PhD in field of high-performance computing (.NET Platform).
    /// 
    /// Async and Parallel components of .NET 4 [ "->" denotes derived from or based on top off.]
    /// Resource Manager -> Task Scheduler -> Task Parallel Library(TPL) -> Concurrent Data Structures/ Parallel LINQ etc.
    /// 
    /// Key Notes: (For Asynchronous programming: https://docs.microsoft.com/en-us/dotnet/csharp/async)
    /// 1. Use await instead of Task.Wait or Task.Result
    /// 2. Use await Task.WhenAny	instead of Task.WaitAny
    /// 3. Use await Task.WhenAll	instead of Task.WaitAll
    /// 
    /// When a Task throws an Exception E - that goes unhandeled
    /// 1. Task is terminated
    /// 2. E is caught, saved as part of an AggregateException AE, and stored in task object's Exception property
    /// 3. AE is re-thrown wuopn - .Wait, .Result or .WaitAll
    /// 
    /// - Closure variables are stored within compiler-generated class
    /// - Closure varaiables are passded 'by Reference'
    /// 
    /// 
    /// </summary>
    public class TaskMaster : IDisposable
    {

        #region Tasks - Create Many

        public Task StartTask(Action action)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                return Task.Factory.StartNew(() =>
                {
                    action();
                });
            }
        }

        public Task<Result<TResult>> StartTask<TInput1, TResult>(TInput1 arg1, 
            Func<TInput1, Result<TResult>> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                return Task.Factory.StartNew<Result<TResult>>(() =>
                {
                    return function(arg1);
                });
            }
        }

        #endregion



        #region Grab results from Tasks 1- Wait Any, 2- Wait All. (With and WithOUT Cancellation Token)

        // Wait all One by One - Pattern.
        //public Task<Result<TResult>> Pattern_WaitAllOneByOne_NotCompletelyImplemented<TResult>
        //    (List<Task<Result<TResult>>> tasks,
        //    CancellationTokenSource cancellationTokenSource)
        //{
        //    using (this)
        //    {
        //        if (tasks != null && tasks.Count > 0
        //        && cancellationTokenSource != null && cancellationTokenSource.Token != null)
        //        {
        //            Task<Result<TResult>>[] _tasks = tasks.ToArray();
        //            try
        //            {
        //                while (_tasks.Length > 0)
        //                {
        //                    int index = Task.WaitAny(_tasks, cancellationTokenSource.Token);
        //                    Task<Result<TResult>> finishedTask = _tasks[index];

        //                    // Exception property sets the Exception to observed 
        //                    // and hence Exception will not be thrown during GC time.
        //                    if (finishedTask.Exception == null)
        //                        return finishedTask;

        //                    _tasks = _tasks.Where(t => t != finishedTask).ToArray();
        //                }
        //                // All Tasks Failed
        //                return Task.FromException<Result<TResult>>
        //                    (new InvalidOperationException
        //                    ("Exception occured executing all tasks. All tasks failed."));
        //            }
        //            catch (AggregateException ae)
        //            {
        //                Handle_AggregateException(ae);
        //            }
        //            catch (Exception e)
        //            {
        //                Handle_Exception(e);
        //            }
        //        }
        //        return null; // Returning null because code at the other end has supplied this 
        //                     // method call with a null.  
        //                     // Or Cancellation token is not provided.       
        //    }
        //}

        // Wait all - Pattern.
        public List<Task<Result<TResult>>> Pattern_WaitAll<TResult>
            (List<Task<Result<TResult>>> tasks,
            CancellationTokenSource cancellationTokenSource)
        {
            using (this)
            {
                List<Task<Result<TResult>>> finishedTasks = new List<Task<Result<TResult>>>();

                if (tasks != null && tasks.Count > 0
                && cancellationTokenSource != null && cancellationTokenSource.Token != null)
                {
                    Task<Result<TResult>>[] _tasks = tasks.ToArray();
                    try
                    {
                        while (_tasks.Length > 0)
                        {
                            // Task.WaitAll(_tasks, cancellationTokenSource.Token); // Should be somethign like this.

                            int index = Task.WaitAny(_tasks, cancellationTokenSource.Token); // Should be WhenAll or Wait All

                            Task<Result<TResult>> finishedTask = _tasks[index];
                            finishedTasks.Add(finishedTask);

                            // Exception property sets the Exception to observed 
                            // and hence Exception will not be thrown durin GC time.
                            //if (finishedTask.Exception == null)
                            //{
                            //    
                            //}
                            //else
                            //{
                            //
                            //}

                            _tasks = _tasks.Where(t => t != finishedTask).ToArray();
                        }

                        return finishedTasks;

                        // All Tasks Failed
                        //return Task.FromException<Result<TResult>>
                        //    (new InvalidOperationException
                        //    ("Exception occured executing all tasks. All tasks failed."));
                    }
                    catch (AggregateException ae)
                    {
                        Handle_AggregateException(ae);
                    }
                    catch (Exception e)
                    {
                        Handle_Exception(e);
                    }
                }
                return null; // Returning null because code at the other end has supplied this 
                             // method call with a null.  
                             // Or Cancellation token is not provided.       
            }
        }

        // Wait Any - Pattern.
        public Task<Result<TResult>> Pattern_WaitAny<TResult>
            (List<Task<Result<TResult>>> tasks,
            CancellationTokenSource cancellationTokenSource)
        {
            using (this)
            {
                if (tasks != null && tasks.Count > 0
                && cancellationTokenSource != null && cancellationTokenSource.Token != null)
                {
                    Task<Result<TResult>>[] _tasks = tasks.ToArray();
                    try
                    {
                        while (_tasks.Length > 0)
                        {
                            int index = Task.WaitAny(_tasks, cancellationTokenSource.Token);
                            Task<Result<TResult>> finishedTask = _tasks[index];

                            // Exception property sets the Exception to observed 
                            // and hence Exception will not be thrown durin GC time.
                            if (finishedTask.Exception == null)
                                return finishedTask; // return the first completed task! 

                            _tasks = _tasks.Where(t => t != finishedTask).ToArray();
                        }
                        // All Tasks Failed
                        return Task.FromException<Result<TResult>>
                            (new InvalidOperationException
                            ("Exception occured executing all tasks. All tasks failed."));
                    }
                    catch (AggregateException ae)
                    {
                        Handle_AggregateException(ae);
                    }
                    catch (Exception e)
                    {
                        Handle_Exception(e);
                    }
                }
                return null; // Returning null because code at the other end has supplied this 
                             // method call with a null.  
                             // Or Cancellation token is not provided.       
            }
        }



        // Task Composition - is here.

        #endregion

        public async Task<Result<TResult>> RunAsTaskAsync<TResult>(Func<Result<TResult>> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<Result<TResult>> _task = Task.Factory.StartNew(() =>
                {
                    return function();
                });
                return await RunTaskAndReturnComputedResult(_task);
            }
        }

        public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TResult>
            (TInput1 arg1, TInput2 arg2, Func<TInput1, TInput2, Result<TResult>> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<Result<TResult>> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg1, arg2);
                });
                return await RunTaskAndReturnComputedResult(_task);
            }
        }

        #region Private methods to facilitate Tasks

        private Task<Result<TResult>> RunTaskAndReturnComputedResult<TResult>
            (Task<Result<TResult>> t) 
        {
            try
            {
                t.Wait();               
            }
            catch (AggregateException aggregateException)
            {
                string[] _exceptions = Handle_AggregateException(aggregateException).ToArray();

                //return Task.FromResult(new Result<TResult>(new InvalidOperationException("Exception occured executing all tasks. All tasks failed."), false, String.Concat(_exceptions)));
                //aggregateException           

                return Task.FromException<Result<TResult>>
                            (new InvalidOperationException("Exception occured executing all tasks. All tasks failed."));
            }
            catch (Exception exception)
            {
                // Record Exception using Diagnostics
                string[] _exceptions = Handle_Exception(exception).ToArray();

                return Task.FromResult(
                    new Result<TResult>(
                        default(TResult), false, 
                        "Opps! this fell off. We are looking into this, please try again soon.",
                        String.Concat(_exceptions)));
                //exception
            }
            // ehh! return a completed task now with required data
            return Task.FromResult(new Result<TResult>(t.Result.Value, true, string.Empty, string.Empty));           
        } 

        #endregion


        #region Handle Exceptions


        private IList<string> Handle_AggregateException(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {                
                if (ex.InnerException is OperationCanceledException)
                {                   
                    errors.Add(ex.Message != null ? ex.Message : "Task was cancelled");
                }
                else
                {
                    errors.Add(ex.Message != null ? ex.Message : "No exception message found/set.");
                }                
            }

            // Record string in Windows Event Log via Diagnostics.

            if (errors.Count == 0)
                errors.Add("No exception message found/set.");

            return errors;
        }

        private IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException?.Message
                : "Inner Exception is null");

            return errors;
        }


        #endregion

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
