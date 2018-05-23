using PerformancePunch.FP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerformancePunch
{
    /// <summary>
    /// 
    /// Welcome to - Performance Punch. 
    /// 
    /// This is the Asynchronous version of 'GenTask'
    /// And is hence rightly called 'GenTaskAsync'
    ///
    /// !Bow down to the Mighty AWAIT!     
    ///   
    /// 
    /// 
    /// *********************Gyann Vihar*********************
    /// Task == object representing an ongoing computation.
    /// Tasks are objects - you can check status, wait, harvest results, store exceptions (etc...).
    /// 
    /// EdTask denotes a unit of work, an ongoing computation.
    /// EdTask is a CODE TASK.
    /// 
    /// YOUR JOB as DEVELOPER - is to create EdTasks (well, tasks!)
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
    /// *****************************************************   
    /// 
    /// </summary>
    /// 
    /// <seealso cref="PerfGuard.Statics.EdUsing">
    ///     Wrap this class object in a Using Block.
    /// </seealso>
    public class GenTaskAsync : IDisposable
    {

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="action">The code as Action that will be executed as a Task.</param>
        /// <returns>True if the Task completed or False if the Task failed.</returns>
        public async Task<Result> RunAsTaskAsync(Action action)
        {
            // Equivalent, but slightly more efficent... StartNew().
            Task _task = Task.Factory.StartNew(() =>
            {
                action();
            });

            return await ProcessTaskAsync(_task);
        }

        /// <summary>
        /// Closure variables become shared variables - beware if those vars are read & written (race condition?).
        /// 
        /// </summary>        
        /// <param name="arg1">String argument one to pass to action lamda.</param>
        /// <param name="arg2">String argument two to pass to action lamda.</param>
        /// <param name="action">The code as Action that will be executed as a Task.</param>
        /// <returns>True if the Task completed or False if the Task failed.</returns>
        public async Task<Result> RunAsTaskAsync(string arg1, string arg2, Action<string, string> action)
        {
            // Equivalent, but slightly more efficent... StartNew().
            Task _task = Task.Factory.StartNew(() =>
            {
                action(arg1, arg2);
            });

            return await ProcessTaskAsync(_task);
        }


        public Task<Result> SampleKIllingAsync(string arg1, string arg2, Action<string, string> action)
        {
            // Equivalent, but slightly more efficent... StartNew().
            Task _task = Task.Factory.StartNew(() =>
            {
                action(arg1, arg2);
            });

            return ProcessTaskAsync(_task);
        }

        #region Patterns

        ///*
        // * 
        // * We need the following Pattern(s)
        // * 
        // * 1.1  Wait All Tasks (When All)
        // * 1.2  Wait All Tasks of Result<TResult> (When All)
        // * 1.3  Wait All Tasks (When All) - With Cancellation Token, Task Priorities, 
        // *      Parent-child tasks and Parametrer passing.
        // * 1.4  Wait All Tasks of Result<TResult> (When All) - With Cancellation Token, Task Priorities, 
        // *      Parent-child tasks and Parametrer passing.
        // * 
        // * 2.1  Wait Any Task (When Any)
        // * 2.2  Wait Any Task of Result<TResult> (When Any)
        // * 2.3   Wait Any Task (When Any) - With Cancellation Token, Task Priorities, 
        // *      Parent-child tasks and Parametrer passing.
        // * 2.4  Wait Any Task of Result<TResult> (When Any) - With Cancellation Token, Task Priorities, 
        // *      Parent-child tasks and Parametrer passing.
        // * 
        // * 3.1  Wait All Tasks One-by-One (When Any) [Remove from for-each]
        // * 3.2  Wait All Tasks One-by-One of Result<TResult> (When Any) [Remove from for-each]   
        // * 3.3  Wait All Tasks One-by-One (When Any) [Remove from for-each] - With Cancellation Token, Task Priorities, 
        // *      Parent-child tasks and Parametrer passing.
        // * 3.4  Wait All Tasks One-by-One of Result<TResult> (When Any) [Remove from for-each] - With Cancellation Token, 
        // *      Task Priorities, Parent-child tasks and Parametrer passing.
        // * 
        // * Continuation Tasks - Data Flow Tasks Pattern
        // * 1. Many-to-One
        // *    Task.Factory.ContinueWhenAll(tasks, (setOfTasks => { //Code here to run after the Array of tasks has completed });)
        // *    
        // * 2. Any-to-One
        // *    Task.Factory.ContinueWhenAny(tasks, (firstTask => { //Code here to run after the First has completed });)
        // * 
        // */


        #region Pattern Implementaion from: 1 to 1.4

        /// <summary>   
        /// 
        /// WaitForAllTasks_ToComplete - Pass a List of Tasks and Wait for them to finish.
        /// All Tasks will be executed Parallely. Code will return to calling method once all have completed.
        ///
        /// </summary>
        /// 
        /// <remarks>
        /// Pattern Implementation : 1.1 -> Wait All Tasks (When All).
        /// </remarks>
        public void WaitForAllTasks_ToComplete()
        {

        }

        #endregion 


        #region Pattern Implementaion from: 2 to 2.4 

        /// <summary>   
        /// 
        /// WaitForAllTasks_ToComplete - Pass a List of Tasks and Wait for them to finish.
        /// All Tasks will be executed Parallely. Code will return to calling method once all have completed.
        ///
        /// </summary>
        /// 
        /// <remarks>
        /// Pattern Implementation : 2.1 -> Wait Any Task (When Any)
        /// </remarks>
        public async Task<Result<TResult>> WaitForAnyTask_ToComplete<TResult>(List<Task<TResult>> tasks)
        {
            string[] _exceptions = new string[] { };

            if (tasks != null && tasks.Count > 0)
            {
                while (tasks.Count > 0)
                {
                    var completedTask = await Task.WhenAny(tasks); // No Exception thrown here @WhenAny()
                    try
                    {
                        if (completedTask.Exception == null)
                            return Result.Ok(completedTask.Result); // send Successfully Completed Task, don't get emotional.                        

                        tasks = tasks.Where(w => w != completedTask).ToList();
                    }
                    catch (AggregateException aggregateException)
                    {
                        // Record Exception using Diagnostics
                        _exceptions = Handle_AggregateException(aggregateException).ToArray();
                    }
                    catch (Exception exception)
                    {
                        // Record Exception using Diagnostics
                        _exceptions = Handle_Exception(exception).ToArray();
                    }
                    tasks.Remove(completedTask);
                }
            }
            // All Tasks Failed
            return Result.Fail<TResult>(string.Empty, "All tasks failed.");
        }

        #endregion

        #region Pattern Implementaion from: 3 to 3.4

        /// <summary>   
        /// 
        /// WaitForAllTasks_ToComplete - Pass a List of Tasks and Wait for them to finish.
        /// All Tasks will be executed Parallely. Code will return to calling method once all have completed.
        ///
        /// </summary>
        /// 
        /// <returns>
        /// List<Task> - the list of tasks that completed Successfully. 
        /// Failed Tasks are ignored, and there details are recorded via appropriate logging mechanism.        /// 
        /// </returns>
        /// 
        /// <remarks>
        /// Pattern Implementation : 3.1 -> Wait All Tasks One-by-One (When Any) [Remove from for-each]
        /// </remarks>
        public async Task<List<Task<Result<TResult>>>> WaitForAllTasks_OneByOne_ToComplete_Async<TResult>
            (List<Task<Result<TResult>>> tasks)
        {
            List<Task<Result<TResult>>> successfullyCompletedTasks = new List<Task<Result<TResult>>>();
            string[] _exceptions = new string[] { };
            if (tasks != null && tasks.Count > 0)
            {
                while (tasks.Count > 0)
                {
                    var completedTask = await Task.WhenAny(tasks); // No Exception thrown here @WhenAny()
                    try
                    {
                        completedTask.Wait(); // Exception will be re-thrown here, we are observing Exception.
                        successfullyCompletedTasks.Add(completedTask); // Add Successfully Completed Task, don't get emotional.                        
                    }
                    catch (AggregateException aggregateException)
                    {
                        // Record Exception using Diagnostics
                        _exceptions = Handle_AggregateException(aggregateException).ToArray();
                    }
                    catch (Exception exception)
                    {
                        // Record Exception using Diagnostics
                        _exceptions = Handle_Exception(exception).ToArray();
                    }
                    tasks.Remove(completedTask);
                }
            }
            return successfullyCompletedTasks;
        }

        #endregion

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
        /// Create single token and pass to multiple Task(s) if you wish to cancel them all.
        /// 
        /// If you cancel a Task or Task(s) using this Token - then - You must create a 
        /// new Token for following ask or Task(s). Tokens' are SticKYyYyYyYy and hence this remedy.
        /// 
        /// In you Function before comencing on a Heavy Computing Task - check for the token.
        /// ex. if(cancellationToken.IsCancellationRequested) 
        /// {
        ///     // Clean up code goes before
        ///     cancellationToken.ThrowIfCancellationRequested();
        /// }
        /// </param>
        /// <returns></returns>
        public async Task<Result<TResult>> RunAsTask<TInput, TResult>(TInput arg1,
            Func<TInput, CancellationToken, TResult> function,
            CancellationTokenSource cancellationTokenSource)
        {
            CancellationToken cancellationToken = Get_CancellationToken(cancellationTokenSource);

            Task<TResult> taskToRun = 
                Task.Factory.StartNew(() =>
                {
                    return function(arg1, cancellationToken);
                },
                cancellationToken);

            return await ProcessTaskAsync(taskToRun);
        }

        /// <summary>
        /// Do not use.
        /// </summary>
        /// <param name="tasks"></param>
        public void WaitForFirstTask_ToComplete(List<Task> tasks)
        {
            string[] _exceptions = new string[] { };
            if (tasks != null && tasks.Count > 0)
            {
                try
                {
                    Task.WhenAny(tasks);
                }
                catch (AggregateException aggregateException)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_AggregateException(aggregateException).ToArray();
                }
                catch (Exception exception)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_Exception(exception).ToArray();
                }
            }
        }


        /// <summary>
        /// From a list when you need Result of First Completed Task.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tasks"></param>
        /// <returns></returns>
        public Result<TResult> WaitForFirstTask_ToComplete<TResult>(List<Task<Result<TResult>>> tasks)
        {
            string[] _exceptions = new string[] { };
            Result<TResult> completedTask = null;

            if (tasks != null && tasks.Count > 0)
            {
                try
                {
                    var finishedTask = Task.WhenAny(tasks);
                    completedTask = finishedTask.Result.Result;
                }
                catch (AggregateException aggregateException)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_AggregateException(aggregateException).ToArray();
                }
                catch (Exception exception)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_Exception(exception).ToArray();
                }
            }
            return (completedTask == null)
                ? Result.Fail<TResult>
                    ("Opps! we dropped the ball. Our army of monkies is on this, meanwhile can you please try again soon.",
                    string.Concat(_exceptions))
                : Result.Ok<TResult>(completedTask.Value);
        }



        public async Task WaitForAllTasksToCompleteAsync(List<Task> tasks)
        {
            string[] _exceptions = new string[] { };
            if (tasks != null && tasks.Count > 0)
            {
                try
                {
                    await Task.WhenAll(tasks.ToArray());
                }
                catch (AggregateException aggregateException)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_AggregateException(aggregateException).ToArray();
                }
                catch (Exception exception)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_Exception(exception).ToArray();
                }

                // Here some code...
            }
        }

        /// <summary>
        /// WaitForAllTasks_OneByOne_ToComplete: Use this pattern when -
        /// 
        /// 1. Some may fail - discard/retry
        /// 2. Overlap computation with result processing - aka hide latency.
        /// 
        /// 
        /// </summary>
        /// <param name="tasks"></param>
        public void WaitForAllTasks_OneByOne_ToComplete1(List<Task> tasks)
        {
            string[] _exceptions = new string[] { };
            if (tasks != null && tasks.Count > 0)
            {
                try
                {
                    while (tasks.Count > 0)
                    {
                        var task = Task.WhenAny(tasks);

                        tasks.Remove(task);
                    }
                }
                catch (AggregateException aggregateException)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_AggregateException(aggregateException).ToArray();
                }
                catch (Exception exception)
                {
                    // Record Exception using Diagnostics
                    _exceptions = Handle_Exception(exception).ToArray();
                }


            }
        }

        #endregion

        #region Helper Methods

        private CancellationToken Get_CancellationToken(CancellationTokenSource cancellationTokenSource)
        {
            return cancellationTokenSource?.Token ?? new CancellationTokenSource().Token;
        }

        #endregion


        #region Waiting for Task(s) to Complete

        private async Task<Result> ProcessTaskAsync(Task t)
        {
            string[] _exceptions = new string[] { };
            try
            {
                await t;
                t.Wait();  // Make sure we have a result by now.
            }
            catch (AggregateException aggregateException)
            {
                // Record Exception using Diagnostics
                _exceptions = Handle_AggregateException(aggregateException).ToArray();
            }
            catch (Exception exception)
            {
                // Record Exception using Diagnostics
                _exceptions = Handle_Exception(exception).ToArray();
            }

            return (_exceptions.Length > 0)
                ? Result.Fail
                    ("Opps! we dropped the ball. Our army of monkies is on this, meanwhile can you please try again soon.",
                    string.Concat(_exceptions))
                : Result.Ok();
        }

        private async Task<Result<TResult>> ProcessTaskAsync<TResult>(Task<TResult> t)
        {
            string[] _exceptions = new string[] { };
            TResult taskResult = default(TResult);
            try
            {
                await t;
                taskResult = t.Result;  // Block till we get a Result or Exception.
            }
            catch (AggregateException aggregateException)
            {
                // Record Exception using Diagnostics
                _exceptions = Handle_AggregateException(aggregateException).ToArray();
            }
            catch (Exception exception)
            {
                // Record Exception using Diagnostics
                _exceptions = Handle_Exception(exception).ToArray();
            }

            return (_exceptions.Length > 0)
                ? Result.Fail<TResult>
                    ("Opps! we dropped the ball. Our army of monkies is on this, meanwhile can you please try again soon.",
                    string.Concat(_exceptions))
                : Result.Ok<TResult>(taskResult);
        }

        #endregion


        #region Exception Handling - AggregateException and Exception(Ss)

        private IList<string> Handle_AggregateException(AggregateException ae)
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
