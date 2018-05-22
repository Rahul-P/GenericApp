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
    /// 
    /// 
    /// </summary>


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
    /// </summary>
    public class GenTask : IDisposable
    {
        #region Run Tasks       

        public async Task<TResult> RunAsTaskAsync<TInput, TResult>(TInput arg, Func<TInput, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg);
                });
                return await WaitForTaskWithResultToCompleteAndHandleException(_task);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="arg"></param>
        /// <param name="function"></param>
        /// <param name="cancellationTokenSource">
        /// Creation of Token will be done as below:
        /// ex. CancellationTokenSource source = new CancellationTokenSource();     
        /// 
        /// Token associated with this Task. 
        /// Create single token and pass to multiple VanTask(s) if you wish to cancel them all.
        /// 
        /// If you cancel a VanTask or VanTask(s) using this Token - then - You must create a 
        /// new Token for following VanTask or VanTask(s). Tokens' are SticKYyYyYyYy and hence this remedy.
        /// 
        /// In you Function before comencing on a Heavy Computing Task - check for the token.
        /// ex. if(cancellationToken.IsCancellationRequested) 
        /// {
        ///     // Clean up code goes before
        ///     cancellationToken.ThrowIfCancellationRequested();
        /// }
        /// </param>
        /// <returns></returns>
        public async Task<TResult> RunAsTaskAsync<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, TResult> function,
            CancellationTokenSource cancellationTokenSource)
        {
            using (this)
            {
                CancellationToken cancellationToken = cancellationTokenSource != null
                        ? cancellationTokenSource.Token
                        : new CancellationTokenSource().Token;

                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg, cancellationToken);
                },
                cancellationToken);

                return await WaitForTaskWithResultToCompleteAndHandleException(_task);
            }
        }

        #endregion


        #region Create Tasks and return Tasks - Section: 'Run created tasks - manage results etc' - takes care of tasks created.   

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

        public Task<TResult> StartTask<TInput, TResult>(TInput arg, Func<TInput, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                return Task.Factory.StartNew(() =>
                {
                    return function(arg);
                });
            }
        }

        // Wait for all - Wait any - Tasks.
        public List<Task> WaitForAllTasksToComplete_WaitAll<TResult>(List<Task> tasks)
        {
            using (this)
            {
                if (tasks != null && tasks.Count > 0)
                {
                    Task[] _tasks = tasks.ToArray();
                    try
                    {
                        Task.WaitAll(_tasks);
                    }
                    catch (AggregateException ae)
                    {
                        Handle_AggregateException(ae);
                    }
                    catch (Exception e)
                    {
                        Handle_Exception(e);
                    }
                    return _tasks.ToList();
                }
                return tasks;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tasks"></param>
        /// <param name="cancellationTokenSource">One Call to dotCANCEL to cancel them all.</param>
        /// <returns></returns>
        public List<Task> WaitForAllTasksToComplete_WaitAll<TResult>(List<Task> tasks,
            CancellationTokenSource cancellationTokenSource)
        {
            using (this)
            {
                if (tasks != null && tasks.Count > 0
                && cancellationTokenSource != null && cancellationTokenSource.Token != null)
                {
                    Task[] _tasks = tasks.ToArray();
                    try
                    {
                        Task.WaitAll(_tasks, cancellationTokenSource.Token);
                    }
                    catch (AggregateException ae)
                    {
                        Handle_AggregateException(ae);
                    }
                    catch (Exception e)
                    {
                        Handle_Exception(e);
                    }
                    return _tasks.ToList();
                }
                return tasks;
            }
        }

        public Task<TInput> FetchFirstTaskToComplete_WaitAny<TInput>(List<Task<TInput>> tasks)
        {
            using (this)
            {
                if (tasks != null && tasks.Count > 0)
                {
                    Task<TInput>[] _tasks = tasks.ToArray();
                    try
                    {
                        while (_tasks.Length > 0)
                        {
                            CancellationTokenSource tokenSource = new CancellationTokenSource();

                            int index = Task.WaitAny(_tasks, tokenSource.Token);
                            Task<TInput> finishedTask = _tasks[index];

                            // Exception property sets the Exception to observed 
                            //and hence Exception will not be thrown durin GC time.
                            if (finishedTask.Exception == null)
                            {
                                tokenSource.Cancel();
                                return finishedTask;
                            }

                            _tasks = _tasks.Where(t => t != finishedTask).ToArray();
                        }
                        // All Tasks Failed
                        return Task.FromException<TInput>
                            (new InvalidOperationException("Exception occured executing all tasks. All tasks failed."));
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
                return null; // Returning null because code at the other end has supplied this method call with a null. 
            }
        }

        public Task<TInput> FetchFirstTaskToComplete_WaitAny<TInput>(List<Task<TInput>> tasks,
            CancellationTokenSource cancellationTokenSource)
        {
            using (this)
            {
                if (tasks != null && tasks.Count > 0
                && cancellationTokenSource != null && cancellationTokenSource.Token != null)
                {
                    Task<TInput>[] _tasks = tasks.ToArray();
                    try
                    {
                        while (_tasks.Length > 0)
                        {
                            int index = Task.WaitAny(_tasks, cancellationTokenSource.Token);
                            Task<TInput> finishedTask = _tasks[index];

                            // Exception property sets the Exception to observed 
                            // and hence Exception will not be thrown durin GC time.
                            if (finishedTask.Exception == null)
                                return finishedTask;

                            _tasks = _tasks.Where(t => t != finishedTask).ToArray();
                        }
                        // All Tasks Failed
                        return Task.FromException<TInput>
                            (new InvalidOperationException("Exception occured executing all tasks. All tasks failed."));
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
                return null; // Returning null because code at the other end has supplied this method call with a null.  
                             // Or Cancellation token is not provided.       
            }
        }


        #endregion     




        // Run this as awaitable task  
        // run task with One object - Operation result
        // run task with one object - Operation result awaitable


        private Task WaitForTaskToCompleteAndHandleException(Task t)
        {
            try
            {
                t.Wait();
            }
            catch (AggregateException ae)
            {
                Handle_AggregateException(ae);
            }
            catch (Exception e)
            {
                // Record Exception using Diagnostics
                Handle_Exception(e);
            }
            return t;
        }

        private Task<TResult> WaitForTaskWithResultToCompleteAndHandleException<TResult>(Task<TResult> t)
        {
            try
            {
                t.Wait();
            }
            catch (AggregateException ae)
            {
                Handle_AggregateException(ae);
            }
            catch (Exception e)
            {
                // Record Exception using Diagnostics
                Handle_Exception(e);
            }
            return t;
        }


        #region Exception Handling - AggregateException and Exception (Ss)

        private void Handle_AggregateException(AggregateException ae)
        {
            ae.Flatten();
            //string mainMessage = ae.InnerException?.Message + ae.InnerException?.StackTrace;

            foreach (Exception ex in ae.InnerExceptions)
            {
                string taskWasCancelled = string.Empty;
                if (ex.InnerException is OperationCanceledException)
                    taskWasCancelled = "Task was cancelled";

                string msg = ex.Message;
                // Record string in Windows Event Log via Diagnostics.
            }
        }

        private void Handle_Exception(Exception e)
        {
            // Record the following - Exception and Inner Exception details                        
            string innerExceptionMsg = e.InnerException != null
                ?
                    e.InnerException?.Message
                : "Inner Exception is null";
        }

        #endregion


        // Wait for a task to finish
        // return a value from a task
        // Compose tasks
        // handle exceptions
        // cancel a task

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



        #region   The one with Result Objects


        public async Task<Result<TResult>> RunAsTaskAsync2<TResult>(Func<TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function();
                });
                return await WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        public async Task<Result<TResult>> RunAsTaskAsync2<TInput, TResult>(TInput arg,
            Func<TInput, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg);
                });
                return await WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        public Task<Result<TResult>> RunAsTask2<TInput1, TResult>
            (TInput1 arg1, Func<TInput1, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg1);
                });
                return WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        public async Task<Result<TResult>> RunAsTaskAsync2<TInput1, TInput2, TResult>
            (TInput1 arg1, TInput2 arg2, Func<TInput1, TInput2, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg1, arg2);
                });
                return await WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        public async Task<Result<TResult>> RunAsTaskAsync2<TInput1, TInput2, TInput3, TResult>
            (TInput1 arg1, TInput2 arg2, TInput3 arg3, Func<TInput1, TInput2, TInput3, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg1, arg2, arg3);
                });
                return await WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        public async Task<Result<TResult>> RunAsTaskAsync2<TInput1, TInput2, TInput3, TInput4, TResult>
            (TInput1 arg1, TInput2 arg2, TInput3 arg3, TInput4 arg4,
            Func<TInput1, TInput2, TInput3, TInput4, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg1, arg2, arg3, arg4);
                });
                return await WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        public async Task<Result<TResult>> RunAsTaskAsync2<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>
            (TInput1 arg1, TInput2 arg2, TInput3 arg3, TInput4 arg4, TInput5 arg5,
            Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult> function)
        {
            using (this)
            {
                // Equivalent, but slightly more efficent... StartNew().
                Task<TResult> _task = Task.Factory.StartNew(() =>
                {
                    return function(arg1, arg2, arg3, arg4, arg5);
                });
                return await WaitForTaskWithResultToCompleteAndHandleException2(_task);
            }
        }

        private Task<Result<TResult>> WaitForTaskWithResultToCompleteAndHandleException2<TResult>(Task<TResult> t)
        {
            try
            {
                t.Wait();
            }
            catch (AggregateException aggregateException)
            {
                string[] _exceptions = Handle_AggregateException2(aggregateException).ToArray();
                // -- should be brought back --  return Task.FromResult(new Result<TResult>(aggregateException, false, _exceptions.ToString()));
            }
            catch (Exception exception)
            {
                // Record Exception using Diagnostics
                string[] _exceptions = Handle_Exception2(exception).ToArray();
                // -- should be brought back -- return Task.FromResult(new Result<TResult>(exception, false, _exceptions));
            }
            // ehh! return a completed task now with required data
            // -- should be brought back -- return Task.FromResult(new Result<TResult>(true, t.Result));

            //-- should be brought back -- return Task.FromResult(new Result<TResult>(true, t.Result));

            return null;
        }

        #region Exception Handling - AggregateException and Exception (Ss)

        private IList<string> Handle_AggregateException2(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {
                // string taskWasCancelled = string.Empty;
                //if (ex.InnerException is OperationCanceledException)
                //    taskWasCancelled = "Task was cancelled";

                errors.Add(ex.Message != null ? ex.Message : "No exception message found/set.");
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add("No exception message found/set.");

            return errors;
        }

        private IList<string> Handle_Exception2(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException?.Message
                : "Inner Exception is null");

            return errors;
        }

        #endregion




        #endregion
    }


    //public class TaskManager : IDisposable
    //{
    //    public async Task<Result<TResult>> RunAsTaskAsync<TResult>(Func<TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function();
    //            });
    //            return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    public async Task<Result<TResult>> RunAsTaskAsync<TInput, TResult>(TInput arg,
    //        Func<TInput, TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function(arg);
    //            });
    //            return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    public Task<Result<TResult>> RunAsTask<TInput1, TResult>
    //        (TInput1 arg1, Func<TInput1, TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function(arg1);
    //            });
    //            return WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TResult>
    //        (TInput1 arg1, TInput2 arg2, Func<TInput1, TInput2, TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function(arg1, arg2);
    //            });
    //            return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TInput3, TResult>
    //        (TInput1 arg1, TInput2 arg2, TInput3 arg3, Func<TInput1, TInput2, TInput3, TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function(arg1, arg2, arg3);
    //            });
    //            return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TInput3, TInput4, TResult>
    //        (TInput1 arg1, TInput2 arg2, TInput3 arg3, TInput4 arg4,
    //        Func<TInput1, TInput2, TInput3, TInput4, TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function(arg1, arg2, arg3, arg4);
    //            });
    //            return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>
    //        (TInput1 arg1, TInput2 arg2, TInput3 arg3, TInput4 arg4, TInput5 arg5,
    //        Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult> function)
    //    {
    //        using (this)
    //        {
    //            // Equivalent, but slightly more efficent... StartNew().
    //            Task<TResult> _task = Task.Factory.StartNew(() =>
    //            {
    //                return function(arg1, arg2, arg3, arg4, arg5);
    //            });
    //            return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //        }
    //    }

    //    private Task<Result<TResult>> WaitForTaskWithResultToCompleteAndHandleException<TResult>(Task<TResult> t)
    //    {
    //        try
    //        {
    //            t.Wait();
    //        }
    //        catch (AggregateException aggregateException)
    //        {
    //            string[] _exceptions = Handle_AggregateException(aggregateException).ToArray();
    //            return Task.FromResult(new Result<TResult>(aggregateException, false, _exceptions));
    //        }
    //        catch (Exception exception)
    //        {
    //            // Record Exception using Diagnostics
    //            string[] _exceptions = Handle_Exception(exception).ToArray();
    //            return Task.FromResult(new Result<TResult>(exception, false, _exceptions));
    //        }
    //        // ehh! return a completed task now with required data
    //        return Task.FromResult(new Result<TResult>(true, t.Result));
    //    }

    //    #region Exception Handling - AggregateException and Exception (Ss)

    //    private IList<string> Handle_AggregateException(AggregateException ae)
    //    {
    //        IList<string> errors = new List<string>();

    //        ae.Flatten();
    //        foreach (var ex in ae.InnerExceptions)
    //        {
    //            // string taskWasCancelled = string.Empty;
    //            //if (ex.InnerException is OperationCanceledException)
    //            //    taskWasCancelled = "Task was cancelled";

    //            errors.Add(ex.Message != null ? ex.Message : "No exception message found/set.");
    //            // Record string in Windows Event Log via Diagnostics.
    //        }

    //        if (errors.Count == 0)
    //            errors.Add("No exception message found/set.");

    //        return errors;
    //    }

    //    private IList<string> Handle_Exception(Exception e)
    //    {
    //        IList<string> errors = new List<string>();

    //        // Record the following - Exception and Inner Exception details                        
    //        errors.Add((e.InnerException != null) ? e.InnerException?.Message
    //            : "Inner Exception is null");

    //        return errors;
    //    }

    //    #endregion

    //    #region IDisposable Support

    //    private bool disposedValue = false;
    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            disposedValue = true;
    //        }
    //    }

    //    // This code added to correctly implement the disposable pattern.
    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    #endregion
    //}
}

