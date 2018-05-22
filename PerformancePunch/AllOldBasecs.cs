using System;
using System.Collections.Generic;
using System.Text;

namespace PerformancePunch
{
    class AllOldBasecs
    {
    }


    //using System;

    //namespace Vantions.Extensions
    //{
    //    /// <summary>
    //    /// UsingBlockStatic - An extension method for Using block.
    //    /// </summary>
    //    public static class UsingBlockStatic
    //    {
    //        /// <summary>
    //        /// Use me instead of Using block.        
    //        /// Example usage - obj.Use(  x=> x.DoAction(); x.DoAllYouWantOfMe(); x.SummonSwitchBlockssss(); );
    //        /// 
    //        /// </summary>
    //        /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
    //        /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
    //        /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
    //        /// <example>obj.Use(  x=> x.DoAction();); where obj implements <see cref="IDisposable"/></example>
    //        public static void Use<T>(this T obj, Action<T> action) where T : IDisposable
    //        {
    //            using (obj)
    //            {
    //                action(obj);
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// UsingBlock - I am a class with method Use() which calls using block.
    //    /// My Use() calls Dispose(true) internally to mark myself for killing.
    //    /// You dont have to worry about anything. 
    //    /// Use me for cleaner code.
    //    /// 
    //    /// and yes I am CURSED. 
    //    /// </summary>
    //    public class UsingBlock : IDisposable
    //    {
    //        /// <summary>
    //        /// Use me instead of Using block.        
    //        /// Example usage - 
    //        /// new UsingBlock().Use(diag, diag => { diag.SummonSwitchBlockssss(); });
    //        /// 
    //        /// </summary>
    //        /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
    //        /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
    //        /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
    //        /// <example>new UsingBlock().Use(diag, diag => { diag.SummonSwitchBlockssss(); });
    //        /// where diag implements <see cref="IDisposable"/></example>
    //        public void Use<T>(T obj, Action<T> action) where T : IDisposable
    //        {
    //            using (this) // I am cursed.
    //            {
    //                using (obj)
    //                {
    //                    action(obj);
    //                }
    //            }
    //        }

    //        #region IDisposable Support
    //        private bool disposedValue = false; // To detect redundant calls

    //        protected virtual void Dispose(bool disposing)
    //        {
    //            if (!disposedValue)
    //            {
    //                disposedValue = true;
    //            }
    //        }

    //        // This code added to correctly implement the disposable pattern.
    //        public void Dispose()
    //        {
    //            Dispose(true);
    //            GC.SuppressFinalize(this);
    //        }
    //        #endregion
    //    }
    //}



    //using System;
    //using System.Collections.Generic;

    //namespace Vantions.FilterCollections
    //{
    //    public static class FilterDataStatic
    //    {
    //        /// <summary>
    //        /// Apply a function f to individual elements from T1 -> T2. 
    //        /// </summary>
    //        /// <typeparam name="T1">The data type to be worked on.</typeparam>
    //        /// <typeparam name="T2">the returned data. Filtered/sorted (etc...) based on function f.</typeparam>
    //        /// <param name="data">List of objects (etc...) crap to work on.</param>
    //        /// <param name="f">the Func that returns T2. T2 is the data that you want after applying the rules you want.</param>
    //        /// <returns></returns>
    //        public static IEnumerable<T2> MySelect<T1, T2>(this IEnumerable<T1> data, Func<T1, T2> f)
    //        {
    //            IList<T2> retVal = new List<T2>();
    //            foreach (T1 x in data) retVal.Add(f(x));
    //            return retVal;
    //        }


    //        static double Distance(double x, double y, double z)
    //        {
    //            return Math.Sqrt(x * x + y * y + z * z);
    //        }

    //        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2,
    //                    T3, TResult>(Func<T1, T2, T3, TResult> function)
    //        {
    //            return a => b => c => function(a, b, c);
    //        }

    //        //var curriedDistance = Curry<double, double, double, double>(Distance);
    //        //double d = curriedDistance(3)(4)(12);

    //    }

    //    public class FilterData : IDisposable
    //    {
    //        public IEnumerable<T2> MySelect<T1, T2>(IEnumerable<T1> data, Func<T1, T2> f)
    //        {
    //            using (this)
    //            {
    //                IList<T2> retVal = new List<T2>();
    //                foreach (T1 x in data) retVal.Add(f(x));
    //                return retVal;
    //            }
    //        }

    //        public Func<X, Z> Compose<X, Y, Z>(Func<X, Y> f, Func<Y, Z> g)
    //        {
    //            return (x) => g(f(x));
    //        }

    //        //Func<double, double> sin = Math.Sin;
    //        //Func<double, double> exp = Math.Exp;
    //        //Func<double, double> exp_sin = Compose(sin, exp);
    //        //double y = exp_sin(3);


    //        #region Asynchronous functions  


    //        #endregion


    //        #region IDisposable Support
    //        private bool disposedValue = false; // To detect redundant calls

    //        protected virtual void Dispose(bool disposing)
    //        {
    //            if (!disposedValue)
    //            {
    //                disposedValue = true;
    //            }
    //        }

    //        // This code added to correctly implement the disposable pattern.
    //        public void Dispose()
    //        {
    //            Dispose(true);
    //            GC.SuppressFinalize(this);
    //        }
    //        #endregion
    //    }
    //}



    //using Vantions.ReturnResult;

    //namespace Vantions.GetOverPrimitiveObsession.VanValueTypes
    //{
    //    public class Email : ValueObject<Email>
    //    {
    //        private readonly string _emailValue;

    //        private Email(string emailValue)
    //        {
    //            _emailValue = emailValue;
    //        }

    //        public static Result<Email> Create(string emailValue)
    //        {
    //            if (string.IsNullOrWhiteSpace(emailValue) || string.IsNullOrEmpty(emailValue))
    //                return Result.Fail<Email>("Email should not be empty");

    //            emailValue = emailValue.Trim();

    //            if (emailValue.Length > 256) return Result.Fail<Email>("Email is too long");
    //            if (!emailValue.Contains("@")) return Result.Fail<Email>("Email is invalid");

    //            return Result.Ok(new Email(emailValue));
    //        }

    //        protected override bool EqualsCore(Email other)
    //        {
    //            return _emailValue == other._emailValue;
    //        }

    //        protected override int GetHashCodeCore()
    //        {
    //            return _emailValue.GetHashCode();
    //        }

    //        /// <summary>
    //        /// Overloaded implicit conversion operator for Email Primitive Type.
    //        /// From Email Object to plain Email String (string object - wink wink)
    //        /// 
    //        /// Example of this implicit conversion -
    //        /// Email _email = GetEmail();
    //        /// sting _emailString = _email;
    //        /// </summary>
    //        /// <param name="email"></param>
    //        public static implicit operator string(Email email)
    //        {
    //            return email._emailValue;
    //        }

    //        /// <summary>
    //        /// Overloaded explicit conversion operator for Email Primitive Type.
    //        /// From Email string to Email Object
    //        /// 
    //        /// Example of this explicit conversion -
    //        /// string _emalString = "vanguard-validEmail@switch.gov.au"
    //        /// Email _emailObject= Email(_emalString); 
    //        /// </summary>
    //        /// <param name="email"></param>
    //        public static explicit operator Email(string email)
    //        {
    //            return Create(email).Value;
    //        }
    //    }
    //}



    //namespace Vantions.GetOverPrimitiveObsession
    //{
    //    /// <summary>
    //    /// "ValueObject" existSs to Vage(wage – used V to imply Pun) a war against Primitive Value types.
    //    /// You should use me to get over your obsession of value types.
    //    /// 
    //    /// Think before you use – string email in a method signature.
    //    /// 
    //    /// How about making a class called Email?
    //    /// The said class will house email specific validation, 
    //    /// vanguard specific validations(ex.Email should have @switch in them.) etc.
    //    /// 
    //    /// Method signature could be – SomeMethod(Email primaryEmail, Email secondaryEmail)
    //    /// And the Email class will take care that the passed string adheres to our requirements.
    //    ///
    //    /// What a way to avoid CODE DUPLICATION! 
    //    /// </summary>
    //    public abstract class ValueObject<T>
    //        where T : ValueObject<T>
    //    {
    //        #region Public Members, properties etc.

    //        public override bool Equals(object obj)
    //        {
    //            var valueObject = obj as T;

    //            if (ReferenceEquals(valueObject, null)) return false;

    //            return EqualsCore(valueObject);
    //        }

    //        public override int GetHashCode()
    //        {
    //            return GetHashCodeCore();
    //        }

    //        #endregion

    //        #region Best part - Operator Overloading! - Public Static Methods.

    //        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
    //        {
    //            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

    //            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

    //            return a.Equals(b);
    //        }

    //        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
    //        {
    //            return !(a == b);
    //        }

    //        #endregion


    //        #region Protected Members, properties etc.

    //        protected abstract bool EqualsCore(T other);
    //        protected abstract int GetHashCodeCore();

    //        #endregion        
    //    }
    //}




    //using System;

    //namespace Vantions.MayBeType
    //{
    //    /// <summary>
    //    /// FuncFact: "Tony Hoare" the inventer of NULL calls it a Billion-Dollar mistake!
    //    /// 
    //    /// "Tony Hoare"Ss exact words: "I call it my billion-dollar mistake. It has caused
    //    /// a billion dollars of pain and damage in the last forty years". 
    //    /// 
    //    /// - and COUNTING may I add. but, Not anymore...
    //    /// so here we are, fixing Tonys' Billion-Dollar mistake.
    //    /// 
    //    /// Maybe Type works with REFERENVE TYPES only.
    //    /// 
    //    /// A Maybe varaiable is a Value Type itself a STRUCT and not a reference Type and so it will never be NULL.
    //    /// 
    //    /// Goal is:
    //    /// 1. To address dishonesty of method signatures which take or return reference types.
    //    /// 2. Enforce the use of the Maybe Type, so Null Pointer Exceptions are things of the PAST. 
    //    /// </summary>
    //    public struct Maybe<T> : IEquatable<Maybe<T>> where T : class
    //    {
    //        private readonly T _value;

    //        public T Value
    //        {
    //            get
    //            {
    //                if (HasNoValue)
    //                    throw new InvalidOperationException
    //                        ($"Expected reference type is null. {typeof(T).ToString()} is Null.");
    //                return _value;
    //            }
    //        }

    //        public bool HasValue => _value != null;
    //        public bool HasNoValue => !HasValue;

    //        private Maybe(T value)
    //        {
    //            _value = value;
    //        }

    //        /// <summary>
    //        /// Use me to create a Maybe Type.
    //        /// 
    //        /// Example - 
    //        /// Maybe<string> nullableString = "abscefghijklmnopqrstuvwxyz";
    //        /// instead of: Maybe<string> nullableString = new Maybe<string>("abscefghijklmnopqrstuvwxyz");
    //        /// 
    //        /// Also, the following will be automatically translated to Maybe Type!
    //        /// Maybe<string> nullableString = null;
    //        /// 
    //        /// This will work fine as well!!
    //        /// int? someNumber = null;
    //        /// someNumber.ToString(); // -- No Null Pointers Exception thrown here.   
    //        /// </summary>
    //        /// <param name="value">The Type that can be a Null,</param>
    //        public static implicit operator Maybe<T>(T value)
    //        {
    //            return new Maybe<T>(value);
    //        }

    //        public static bool operator ==(Maybe<T> maybe, T value)
    //        {
    //            if (maybe.HasNoValue) return false;
    //            return maybe.Value.Equals(value);
    //        }

    //        public static bool operator !=(Maybe<T> maybe, T value)
    //        {
    //            return !(maybe == value);
    //        }

    //        public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
    //        {
    //            return firstMaybe.Equals(secondMaybe);
    //        }

    //        public static bool operator !=(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
    //        {
    //            return !(firstMaybe == secondMaybe);
    //        }

    //        public override bool Equals(object obj)
    //        {
    //            if (!(obj is Maybe<T>)) return false;
    //            var other = (Maybe<T>)obj;

    //            return Equals(other);
    //        }
    //        public bool Equals(Maybe<T> other)
    //        {
    //            if (HasNoValue && other.HasNoValue) return true;
    //            if (HasNoValue || other.HasNoValue) return false;

    //            return _value.Equals(other._value);
    //        }

    //        public override int GetHashCode()
    //        {
    //            return _value.GetHashCode();
    //        }

    //        public override string ToString()
    //        {
    //            if (HasNoValue) return "No Value";
    //            return Value.ToString();
    //        }

    //        public T Unwrap(T defaultValue = default(T))
    //        {
    //            if (HasValue) return Value;
    //            return defaultValue;
    //        }

    //        public Maybe<TO> Bind<TO>(Func<T, Maybe<TO>> func) where TO : class
    //        {
    //            return _value != null ? func(_value) : new Maybe<TO>();
    //        }
    //    }
    //}



    //namespace Vantions.ReturnResult
    //{
    //    public enum ErrorDetail
    //    {
    //        ExceptionHasBeenEncountered,
    //        MethodFailedBusinessValidation
    //    }
    //}



    //using System;
    //using System.Linq;

    //namespace Vantions.ReturnResult
    //{
    //    /// <summary>
    //    /// Result is the Datastructure that represents a "result of computing done" in a Vanguard business method.
    //    /// Result 'does not' return a value/object back to the calling code.
    //    /// </summary>
    //    public class Result
    //    {
    //        public bool IsSuccess { get; }
    //        public string Error { get; private set; }
    //        public bool IsFailure => !IsSuccess;

    //        /// <summary>
    //        /// Use of Static methods is encouraged to create an instance of this Result DataStructure.
    //        /// </summary>
    //        /// <param name="isSuccess"></param>
    //        /// <param name="errorDescription"></param>
    //        protected Result(bool isSuccess, string errorDescription)
    //        {
    //            // Check Invariance
    //            if (isSuccess && errorDescription != string.Empty) throw new InvalidOperationException("Error description property should be null.");
    //            if (!isSuccess && errorDescription == string.Empty) throw new InvalidOperationException("Error description property should not be null.");

    //            IsSuccess = isSuccess;
    //            Error = errorDescription;
    //        }

    //        public static Result Ok()
    //        {
    //            return new Result(true, string.Empty);
    //        }

    //        public static Result Fail(string message)
    //        {
    //            return new Result(false, message);
    //        }

    //        public static Result<T> Ok<T>(T value)
    //        {
    //            return new Result<T>(value, true, string.Empty);
    //        }

    //        public static Result<T> Fail<T>(string message)
    //        {
    //            return new Result<T>(default(T), false, message);
    //        }

    //        /// <summary>
    //        /// Call me to inspect multiple Result objects.
    //        /// After invoking multiple business methods pass me there respective array of Result objects.
    //        /// 
    //        /// I will loop through and do the needful.
    //        /// One point of logging events - such as Diagnostic Event, Auditing etc.
    //        /// 
    //        /// </summary>
    //        /// <param name="results">
    //        /// Instances of result objects. 
    //        /// Representing multiple business operations results.
    //        /// </param>
    //        /// <returns>Result - Ok - If all supplied Results were completed successfully.</returns>
    //        public static Result Combine(params Result[] results)
    //        {
    //            foreach (Result result in results)
    //                if (result.IsFailure) return result;

    //            return Ok();
    //        }
    //    }

    //    /// <summary>
    //    /// Result<T> is the Datastructure that represents a "result of computing done" in a Vanguard business method.
    //    /// Result<T> 'does return' a value/object back to the calling code.
    //    /// </summary>
    //    public class Result<T> : Result
    //    {
    //        private readonly T _value;

    //        public T Value
    //        {
    //            get
    //            {
    //                if (!IsSuccess) throw new InvalidOperationException();

    //                return _value;
    //            }
    //        }

    //        protected internal Result(T value, bool isSuccess, string error)
    //            : base(isSuccess, error)
    //        {
    //            _value = value;
    //        }
    //    }
    //}


    //using System;
    //using Vantions.MayBeType;

    //namespace Vantions.ReturnResult
    //{
    //    public static class ResultOrchestratorStatic
    //    {
    //        public static Result<T> ToResult<T>(this Maybe<T> maybe, string errorMessage)
    //            where T : class
    //        {
    //            if (maybe.HasNoValue) return Result.Fail<T>(errorMessage);
    //            return Result.Ok<T>(maybe.Value);
    //        }

    //        /// <summary>
    //        /// Extension method OnSuccess() - This method executes a action thta doesnt take any arguments and
    //        /// returns Results.Ok() regardless, of what happened in action delegate.
    //        /// 
    //        /// Rarely, will be used.
    //        /// </summary>
    //        /// <param name="result">The result object resceived from previous business method call</param>
    //        /// <param name="action">Code to execute, if the previous result (of code executed) was all good.</param>
    //        /// <returns></returns>
    //        public static Result OnSuccess(this Result result, Action action)
    //        {
    //            if (result.IsFailure) return result;

    //            action();

    //            return Result.Ok();
    //        }

    //        /// <summary>
    //        /// Extension method OnSuccess() - This method executes a action thta returns a Result object
    //        /// which determines what happened in execution of Function delegate.
    //        /// 
    //        /// Prefered Method.
    //        /// 
    //        /// </summary>
    //        /// <param name="result">The result object resceived from previous business method call</param>
    //        /// <param name="action">Code to execute, if the previous result (of code executed) was all good.</param>
    //        /// <returns></returns>
    //        public static Result OnSuccess(this Result result, Func<Result> function)
    //        {
    //            if (result.IsFailure) return result;

    //            return function();
    //        }

    //        /// <summary>
    //        /// Execute compensation logic.
    //        /// 
    //        /// </summary>
    //        /// <param name="result">The result object received from previous business method call, that Failed.</param>
    //        /// <param name="action">Code to Log the above Failed Result.</param>
    //        /// <returns></returns>
    //        public static Result OnFaliure(this Result result, Action action)
    //        {
    //            if (result.IsFailure) action();

    //            // return previous Failed Result as it is.
    //            return result;
    //        }

    //        public static Result OnBoth(this Result result, Action<Result> action)
    //        {
    //            action(result);
    //            return result;
    //        }

    //        public static T OnBoth<T>(this Result result, Func<Result, T> function)
    //        {
    //            return function(result);
    //        }
    //    }


    //    public class ResultOrchestrator : IDisposable
    //    {
    //        public Result<T> ToResult<T>(Maybe<T> maybe, string errorMessage)
    //            where T : class
    //        {
    //            using (this)
    //            {
    //                if (maybe.HasNoValue) return Result.Fail<T>(errorMessage);
    //                return Result.Ok<T>(maybe.Value);
    //            }
    //        }

    //        /// <summary>
    //        /// Instance method OnSuccess() - This method executes a action thta doesnt take any arguments and
    //        /// returns Results.Ok() regardless, of what happened in action delegate.
    //        /// 
    //        /// Rarely, will be used.
    //        /// </summary>
    //        /// <param name="result">The result object resceived from previous business method call</param>
    //        /// <param name="action">Code to execute, if the previous result (of code executed) was all good.</param>
    //        /// <returns></returns>
    //        public Result OnSuccess(Result result, Action action)
    //        {
    //            using (this)
    //            {
    //                if (result.IsFailure) return result;

    //                action();

    //                return Result.Ok();
    //            }
    //        }

    //        /// <summary>
    //        /// Instance method OnSuccess() - This method executes a action thta returns a Result object
    //        /// which determines what happened in execution of Function delegate.
    //        /// 
    //        /// Prefered Method.
    //        /// 
    //        /// </summary>
    //        /// <param name="result">The result object resceived from previous business method call</param>
    //        /// <param name="action">Code to execute, if the previous result (of code executed) was all good.</param>
    //        /// <returns></returns>
    //        public Result OnSuccess(Result result, Func<Result> function)
    //        {
    //            using (this)
    //            {
    //                if (result.IsFailure) return result;

    //                return function();
    //            }
    //        }

    //        /// <summary>
    //        /// Execute compensation logic.
    //        /// 
    //        /// </summary>
    //        /// <returns></returns>
    //        public Result OnFaliure(Result result, Action action)
    //        {
    //            using (this)
    //            {
    //                if (result.IsFailure) action();

    //                // return previous Failed Result as it is.
    //                return result;
    //            }
    //        }

    //        public Result OnBoth(Result result, Action<Result> action)
    //        {
    //            using (this)
    //            {
    //                action(result);
    //                return result;
    //            }
    //        }

    //        public T OnBoth<T>(Result result, Func<Result, T> function)
    //        {
    //            using (this)
    //            {
    //                return function(result);
    //            }
    //        }


    //        #region IDisposable Support

    //        private bool disposedValue = false;
    //        protected virtual void Dispose(bool disposing)
    //        {
    //            if (!disposedValue)
    //            {
    //                disposedValue = true;
    //            }
    //        }

    //        // This code added to correctly implement the disposable pattern.
    //        public void Dispose()
    //        {
    //            Dispose(true);
    //            GC.SuppressFinalize(this);
    //        }

    //        #endregion
    //    }
    //}



    //using System;
    //using System.Threading.Tasks;

    //namespace Vantions.Tasks
    //{
    //    /// <summary>
    //    /// Facade Tasks - Pronounced as FASssAaDE Tasks.
    //    /// Facade Task lack of Explicit code during task creation. 
    //    /// It is assumed that the computation is specified elsewhere and is already running such as a Network request.
    //    /// 
    //    /// Why provide a Facade Task?
    //    /// To provide a common object model (a.k.a TASK) for interfacing with both Asynchronous and Parallel Operations.
    //    /// 
    //    /// VanFacadeTask is a Facade Task.
    //    /// This will wrap all calls going out of Vanguards applications to 3rd parties REST APIs. 
    //    /// </summary>
    //    public class VanFacadeTask : IDisposable
    //    {

    //        /// <summary>
    //        /// 
    //        /// 
    //        /// </summary> 
    //        /// <param name="action">The code as Action that will be executed as a Task.</param>
    //        /// <returns>TResult - Object of TResult.</returns>
    //        public Task RunAsFacadeTask<TResult>(object state)
    //        {
    //            using (this)
    //            {
    //                TaskCompletionSource<TResult> tc = new TaskCompletionSource<TResult>(state);
    //                return tc.Task;
    //            }
    //        }


    //        #region IDisposable Support

    //        private bool disposedValue = false;
    //        protected virtual void Dispose(bool disposing)
    //        {
    //            if (!disposedValue)
    //            {
    //                disposedValue = true;
    //            }
    //        }

    //        // This code added to correctly implement the disposable pattern.
    //        public void Dispose()
    //        {
    //            Dispose(true);
    //            GC.SuppressFinalize(this);
    //        }

    //        #endregion
    //    }
    //}




    //using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Threading;
    //using System.Threading.Tasks;

    //namespace Vantions.Tasks
    //{
    //    /// <summary>
    //    /// Task == object representing an ongoing computation.
    //    /// Tasks are objects - you can check status, wait, harvest results, store exceptions (etc...).
    //    /// 
    //    /// VanTask denotes a unit of work, an ongoing computation.
    //    /// VanTask is a CODE TASK.
    //    /// 
    //    /// YOUR JOB as DEVELOPER - is to create VanTasks (well, tasks!)
    //    /// .NET's JOB is to execute tasks as efficiently as possible.
    //    /// 
    //    /// This class has been designed based on the work of Dr. Joe Hummel, PhD.
    //    /// PhD in field of high-performance computing (.NET Platform).
    //    /// 
    //    /// Async and Parallel components of .NET 4 [ "->" denotes derived from or based on top off.]
    //    /// Resource Manager -> Task Scheduler -> Task Parallel Library(TPL) -> Concurrent Data Structures/ Parallel LINQ etc.
    //    /// 
    //    /// Key Notes: (For Asynchronous programming: https://docs.microsoft.com/en-us/dotnet/csharp/async)
    //    /// 1. Use await instead of Task.Wait or Task.Result
    //    /// 2. Use await Task.WhenAny	instead of Task.WaitAny
    //    /// 3. Use await Task.WhenAll	instead of Task.WaitAll
    //    /// 
    //    /// When a Task throws an Exception E - that goes unhandeled
    //    /// 1. Task is terminated
    //    /// 2. E is caught, saved as part of an AggregateException AE, and stored in task object's Exception property
    //    /// 3. AE is re-thrown wuopn - .Wait, .Result or .WaitAll
    //    /// 
    //    /// </summary>
    //    public class VanTask : IDisposable
    //    {
    //        #region Run Tasks

    //        /// <summary>
    //        /// 
    //        /// 
    //        /// </summary>
    //        /// <param name="action">The code as Action that will be executed as a Task.</param>
    //        /// <returns>True if the Task completed or False if the Task failed.</returns>
    //        public bool RunAsTask(Action action)
    //        {
    //            using (this)
    //            {
    //                // Equivalent, but slightly more efficent... StartNew().
    //                Task _task = Task.Factory.StartNew(() =>
    //                {
    //                    action();
    //                });

    //                return WaitForTaskToCompleteAndHandleException(_task)
    //                    .IsCompleted ? true : false;
    //            }
    //        }

    //        /// <summary>
    //        /// Closure variables become shared variables - beware if those vars are read & written (race condition?)
    //        /// 
    //        /// </summary>        
    //        /// <param name="arg1">String argument one to pass to action lamda.</param>
    //        /// <param name="arg2">String argument two to pass to action lamda.</param>
    //        /// <param name="action">The code as Action that will be executed as a Task.</param>
    //        /// <returns>True if the Task completed or False if the Task failed.</returns>
    //        public bool RunAsTask(string arg1, string arg2, Action<string, string> action)
    //        {
    //            using (this)
    //            {
    //                // Equivalent, but slightly more efficent... StartNew().
    //                Task _task = Task.Factory.StartNew(() =>
    //                {
    //                    action(arg1, arg2);
    //                });

    //                return WaitForTaskToCompleteAndHandleException(_task)
    //                    .IsCompleted ? true : false;
    //            }
    //        }

    //        /// <summary>
    //        /// Dont Use this method much.
    //        /// 
    //        /// </summary> 
    //        /// <param name="action">The code as Action that will be executed as a Task.</param>
    //        /// <returns>TResult - Object of TResult.</returns>
    //        //public TResult RunAsTask<TInput, TResult>(TInput arg, Func<TInput, TResult> action)
    //        //{
    //        //    using (this)
    //        //    {
    //        //        // Equivalent, but slightly more efficent... StartNew().
    //        //        //return Task.Factory.StartNew(() =>
    //        //        //{
    //        //        //    return action(arg);                    
    //        //        //}).Result;         

    //        //        return WaitForTaskWithResultToCompleteAndHandleException(
    //        //            Task.Factory.StartNew(() =>
    //        //        {
    //        //            return action(arg);                    
    //        //        })).Result; 
    //        //    }
    //        //}

    //        public Task<TResult> RunAsTask<TInput, TResult>(TInput arg, Func<TInput, TResult> function)
    //        {
    //            using (this)
    //            {
    //                return WaitForTaskWithResultToCompleteAndHandleException(
    //                    Task.Factory.StartNew(() =>
    //                    {
    //                        return function(arg);
    //                    }));
    //            }
    //        }

    //        public async Task<TResult> RunAsTaskAsync<TInput, TResult>(TInput arg, Func<TInput, TResult> function)
    //        {
    //            using (this)
    //            {
    //                // Equivalent, but slightly more efficent... StartNew().
    //                Task<TResult> _task = Task.Factory.StartNew(() =>
    //                {
    //                    return function(arg);
    //                });
    //                return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //            }
    //        }

    //        /// <summary>
    //        /// 
    //        /// </summary>
    //        /// <typeparam name="TInput"></typeparam>
    //        /// <typeparam name="TResult"></typeparam>
    //        /// <param name="arg"></param>
    //        /// <param name="function"></param>
    //        /// <param name="cancellationTokenSource">
    //        /// Creation of Token will be done as below:
    //        /// ex. CancellationTokenSource source = new CancellationTokenSource();     
    //        /// 
    //        /// Token associated with this Task. 
    //        /// Create single token and pass to multiple VanTask(s) if you wish to cancel them all.
    //        /// 
    //        /// If you cancel a VanTask or VanTask(s) using this Token - then - You must create a 
    //        /// new Token for following VanTask or VanTask(s). Tokens' are SticKYyYyYyYy and hence this remedy.
    //        /// 
    //        /// In you Function before comencing on a Heavy Computing Task - check for the token.
    //        /// ex. if(cancellationToken.IsCancellationRequested) 
    //        /// {
    //        ///     // Clean up code goes before
    //        ///     cancellationToken.ThrowIfCancellationRequested();
    //        /// }
    //        /// </param>
    //        /// <returns></returns>
    //        public Task<TResult> RunAsTask<TInput, TResult>(TInput arg,
    //            Func<TInput, CancellationToken, TResult> function,
    //            CancellationTokenSource cancellationTokenSource)
    //        {
    //            using (this)
    //            {
    //                CancellationToken cancellationToken = cancellationTokenSource != null
    //                        ? cancellationTokenSource.Token
    //                        : new CancellationTokenSource().Token;

    //                return WaitForTaskWithResultToCompleteAndHandleException(
    //                    Task.Factory.StartNew(() =>
    //                    {
    //                        return function(arg, cancellationToken);
    //                    },
    //                    cancellationToken));
    //            }
    //        }

    //        /// <summary>
    //        /// 
    //        /// </summary>
    //        /// <typeparam name="TInput"></typeparam>
    //        /// <typeparam name="TResult"></typeparam>
    //        /// <param name="arg"></param>
    //        /// <param name="function"></param>
    //        /// <param name="cancellationTokenSource">
    //        /// Creation of Token will be done as below:
    //        /// ex. CancellationTokenSource source = new CancellationTokenSource();     
    //        /// 
    //        /// Token associated with this Task. 
    //        /// Create single token and pass to multiple VanTask(s) if you wish to cancel them all.
    //        /// 
    //        /// If you cancel a VanTask or VanTask(s) using this Token - then - You must create a 
    //        /// new Token for following VanTask or VanTask(s). Tokens' are SticKYyYyYyYy and hence this remedy.
    //        /// 
    //        /// In you Function before comencing on a Heavy Computing Task - check for the token.
    //        /// ex. if(cancellationToken.IsCancellationRequested) 
    //        /// {
    //        ///     // Clean up code goes before
    //        ///     cancellationToken.ThrowIfCancellationRequested();
    //        /// }
    //        /// </param>
    //        /// <returns></returns>
    //        public async Task<TResult> RunAsTaskAsync<TInput, TResult>(TInput arg,
    //            Func<TInput, CancellationToken, TResult> function,
    //            CancellationTokenSource cancellationTokenSource)
    //        {
    //            using (this)
    //            {
    //                CancellationToken cancellationToken = cancellationTokenSource != null
    //                        ? cancellationTokenSource.Token
    //                        : new CancellationTokenSource().Token;

    //                // Equivalent, but slightly more efficent... StartNew().
    //                Task<TResult> _task = Task.Factory.StartNew(() =>
    //                {
    //                    return function(arg, cancellationToken);
    //                },
    //                cancellationToken);

    //                return await WaitForTaskWithResultToCompleteAndHandleException(_task);
    //            }
    //        }

    //        #endregion


    //        #region Create Tasks and return Tasks - Section: 'Run created tasks - manage results etc' - takes care of tasks created.   

    //        public Task StartTask(Action action)
    //        {
    //            using (this)
    //            {
    //                // Equivalent, but slightly more efficent... StartNew().
    //                return Task.Factory.StartNew(() =>
    //                {
    //                    action();
    //                });
    //            }
    //        }

    //        public Task<TResult> StartTask<TInput, TResult>(TInput arg, Func<TInput, TResult> function)
    //        {
    //            using (this)
    //            {
    //                // Equivalent, but slightly more efficent... StartNew().
    //                return Task.Factory.StartNew(() =>
    //                {
    //                    return function(arg);
    //                });
    //            }
    //        }

    //        // Wait for all - Wait any - Tasks.

    //        public List<Task> WaitForAllTasksToComplete_WaitAll<TResult>(List<Task> tasks)
    //        {
    //            using (this)
    //            {
    //                if (tasks != null && tasks.Count > 0)
    //                {
    //                    Task[] _tasks = tasks.ToArray();
    //                    try
    //                    {
    //                        Task.WaitAll(_tasks);
    //                    }
    //                    catch (AggregateException ae)
    //                    {
    //                        Handle_AggregateException(ae);
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Handle_Exception(e);
    //                    }
    //                    return _tasks.ToList();
    //                }
    //                return tasks;
    //            }
    //        }

    //        /// <summary>
    //        /// 
    //        /// </summary>
    //        /// <typeparam name="TResult"></typeparam>
    //        /// <param name="tasks"></param>
    //        /// <param name="cancellationTokenSource">One Call to dotCANCEL to cancel them all.</param>
    //        /// <returns></returns>
    //        public List<Task> WaitForAllTasksToComplete_WaitAll<TResult>(List<Task> tasks,
    //            CancellationTokenSource cancellationTokenSource)
    //        {
    //            using (this)
    //            {
    //                if (tasks != null && tasks.Count > 0
    //                && cancellationTokenSource != null && cancellationTokenSource.Token != null)
    //                {
    //                    Task[] _tasks = tasks.ToArray();
    //                    try
    //                    {
    //                        Task.WaitAll(_tasks, cancellationTokenSource.Token);
    //                    }
    //                    catch (AggregateException ae)
    //                    {
    //                        Handle_AggregateException(ae);
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Handle_Exception(e);
    //                    }
    //                    return _tasks.ToList();
    //                }
    //                return tasks;
    //            }
    //        }

    //        public Task<TInput> FetchFirstTaskToComplete_WaitAny<TInput>(List<Task<TInput>> tasks)
    //        {
    //            using (this)
    //            {
    //                if (tasks != null && tasks.Count > 0)
    //                {
    //                    Task<TInput>[] _tasks = tasks.ToArray();
    //                    try
    //                    {
    //                        while (_tasks.Length > 0)
    //                        {
    //                            CancellationTokenSource tokenSource = new CancellationTokenSource();

    //                            int index = Task.WaitAny(_tasks, tokenSource.Token);
    //                            Task<TInput> finishedTask = _tasks[index];

    //                            // Exception property sets the Exception to observed 
    //                            //and hence Exception will not be thrown durin GC time.
    //                            if (finishedTask.Exception == null)
    //                            {
    //                                tokenSource.Cancel();
    //                                return finishedTask;
    //                            }

    //                            _tasks = _tasks.Where(t => t != finishedTask).ToArray();
    //                        }
    //                        // All Tasks Failed
    //                        return Task.FromException<TInput>
    //                            (new InvalidOperationException("Exception occured executing all tasks. All tasks failed."));
    //                    }
    //                    catch (AggregateException ae)
    //                    {
    //                        Handle_AggregateException(ae);
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Handle_Exception(e);
    //                    }
    //                }
    //                return null; // Returning null because code at the other end has supplied this method call with a null. 
    //            }
    //        }

    //        public Task<TInput> FetchFirstTaskToComplete_WaitAny<TInput>(List<Task<TInput>> tasks,
    //            CancellationTokenSource cancellationTokenSource)
    //        {
    //            using (this)
    //            {
    //                if (tasks != null && tasks.Count > 0
    //                && cancellationTokenSource != null && cancellationTokenSource.Token != null)
    //                {
    //                    Task<TInput>[] _tasks = tasks.ToArray();
    //                    try
    //                    {
    //                        while (_tasks.Length > 0)
    //                        {
    //                            int index = Task.WaitAny(_tasks, cancellationTokenSource.Token);
    //                            Task<TInput> finishedTask = _tasks[index];

    //                            // Exception property sets the Exception to observed 
    //                            // and hence Exception will not be thrown durin GC time.
    //                            if (finishedTask.Exception == null)
    //                                return finishedTask;

    //                            _tasks = _tasks.Where(t => t != finishedTask).ToArray();
    //                        }
    //                        // All Tasks Failed
    //                        return Task.FromException<TInput>
    //                            (new InvalidOperationException("Exception occured executing all tasks. All tasks failed."));
    //                    }
    //                    catch (AggregateException ae)
    //                    {
    //                        Handle_AggregateException(ae);
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Handle_Exception(e);
    //                    }
    //                }
    //                return null; // Returning null because code at the other end has supplied this method call with a null.  
    //                             // Or Cancellation token is not provided.       
    //            }
    //        }


    //        #endregion


    //        #region Run created tasks - manage results etc.




    //        #endregion




    //        // Run this as awaitable task        

    //        // run task with One object - Operation result

    //        // run task with one object - Operation result awaitable


    //        private Task WaitForTaskToCompleteAndHandleException(Task t)
    //        {
    //            try
    //            {
    //                t.Wait();
    //            }
    //            catch (AggregateException ae)
    //            {
    //                Handle_AggregateException(ae);
    //            }
    //            catch (Exception e)
    //            {
    //                // Record Exception using Diagnostics
    //                Handle_Exception(e);
    //            }
    //            return t;
    //        }

    //        private Task<TResult> WaitForTaskWithResultToCompleteAndHandleException<TResult>(Task<TResult> t)
    //        {
    //            try
    //            {
    //                t.Wait();
    //            }
    //            catch (AggregateException ae)
    //            {
    //                Handle_AggregateException(ae);
    //            }
    //            catch (Exception e)
    //            {
    //                // Record Exception using Diagnostics
    //                Handle_Exception(e);
    //            }
    //            return t;
    //        }


    //        #region Exception Handling - AggregateException and Exception (Ss)

    //        private void Handle_AggregateException(AggregateException ae)
    //        {
    //            ae.Flatten();
    //            //string mainMessage = ae.InnerException?.Message + ae.InnerException?.StackTrace;

    //            foreach (Exception ex in ae.InnerExceptions)
    //            {
    //                string taskWasCancelled = string.Empty;
    //                if (ex.InnerException is OperationCanceledException)
    //                    taskWasCancelled = "Task was cancelled";

    //                string msg = ex.Message;
    //                // Record string in Windows Event Log via Diagnostics.
    //            }
    //        }

    //        private void Handle_Exception(Exception e)
    //        {
    //            // Record the following - Exception and Inner Exception details                        
    //            string innerExceptionMsg = e.InnerException != null
    //                ?
    //                    e.InnerException?.Message
    //                : "Inner Exception is null";
    //        }

    //        #endregion


    //        // Wait for a task to finish
    //        // return a value from a task
    //        // Compose tasks
    //        // handle exceptions
    //        // cancel a task

    //        #region IDisposable Support

    //        private bool disposedValue = false;
    //        protected virtual void Dispose(bool disposing)
    //        {
    //            if (!disposedValue)
    //            {
    //                disposedValue = true;
    //            }
    //        }

    //        // This code added to correctly implement the disposable pattern.
    //        public void Dispose()
    //        {
    //            Dispose(true);
    //            GC.SuppressFinalize(this);
    //        }

    //        #endregion
    //    }
    //}



    //using System;

    //namespace Vantions.Validations
    //{
    //    public class VaderValidator : IDisposable
    //    {

    //        public void deletemelater(string str1, string str2, object obj1, object obj2)
    //        {

    //        }

    //        #region Accesible members 

    //        //this.ValidateArgument<ArgumentException>(() => string.IsNullOrEmpty(relyingpartyid), "relyingpartyid must be supplied");

    //        #endregion

    //        #region Private - Top Secret Code. Stay Away.

    //        private void ValidateArgument<exceptionType>(Func<bool> validation, string errorMessage)
    //            where exceptionType : Exception
    //        {
    //            if (validation())
    //            {
    //                throw Activator.CreateInstance(typeof(exceptionType), errorMessage) as exceptionType;
    //            }
    //        }

    //        #endregion

    //        #region IDisposable Support

    //        private bool disposedValue = false;
    //        protected virtual void Dispose(bool disposing)
    //        {
    //            if (!disposedValue)
    //            {
    //                disposedValue = true;
    //            }
    //        }

    //        // This code added to correctly implement the disposable pattern.
    //        public void Dispose()
    //        {
    //            Dispose(true);
    //            GC.SuppressFinalize(this);
    //        }

    //        #endregion
    //    }
    //}


    // New Back up ---------------------------











//    using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Vantions.Examples
//    {
//        /// <summary>
//        /// I may be replaced by VanTask Package someday. 
//        /// If not then I am efficient enough to take care of this package and its tasks.
//        /// </summary>
//        public class TaskManager : IDisposable
//        {
//            public async Task<Result<TResult>> RunAsTaskAsync<TResult>(Func<TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function();
//                    });
//                    return await WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            public async Task<Result<TResult>> RunAsTaskAsync<TInput, TResult>(TInput arg,
//                Func<TInput, TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function(arg);
//                    });
//                    return await WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            public Task<Result<TResult>> RunAsTask<TInput1, TResult>
//                (TInput1 arg1, Func<TInput1, TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function(arg1);
//                    });
//                    return WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TResult>
//                (TInput1 arg1, TInput2 arg2, Func<TInput1, TInput2, TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function(arg1, arg2);
//                    });
//                    return await WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TInput3, TResult>
//                (TInput1 arg1, TInput2 arg2, TInput3 arg3, Func<TInput1, TInput2, TInput3, TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function(arg1, arg2, arg3);
//                    });
//                    return await WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TInput3, TInput4, TResult>
//                (TInput1 arg1, TInput2 arg2, TInput3 arg3, TInput4 arg4,
//                Func<TInput1, TInput2, TInput3, TInput4, TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function(arg1, arg2, arg3, arg4);
//                    });
//                    return await WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            public async Task<Result<TResult>> RunAsTaskAsync<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>
//                (TInput1 arg1, TInput2 arg2, TInput3 arg3, TInput4 arg4, TInput5 arg5,
//                Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult> function)
//            {
//                using (this)
//                {
//                    // Equivalent, but slightly more efficent... StartNew().
//                    Task<TResult> _task = Task.Factory.StartNew(() =>
//                    {
//                        return function(arg1, arg2, arg3, arg4, arg5);
//                    });
//                    return await WaitForTaskWithResultToCompleteAndHandleException(_task);
//                }
//            }

//            private Task<Result<TResult>> WaitForTaskWithResultToCompleteAndHandleException<TResult>(Task<TResult> t)
//            {
//                try
//                {
//                    t.Wait();
//                }
//                catch (AggregateException aggregateException)
//                {
//                    string[] _exceptions = Handle_AggregateException(aggregateException).ToArray();
//                    return Task.FromResult(new Result<TResult>(aggregateException, false, _exceptions));
//                }
//                catch (Exception exception)
//                {
//                    // Record Exception using Diagnostics
//                    string[] _exceptions = Handle_Exception(exception).ToArray();
//                    return Task.FromResult(new Result<TResult>(exception, false, _exceptions));
//                }
//                // ehh! return a completed task now with required data
//                return Task.FromResult(new Result<TResult>(true, t.Result));
//            }

//            #region Exception Handling - AggregateException and Exception (Ss)

//            private IList<string> Handle_AggregateException(AggregateException ae)
//            {
//                IList<string> errors = new List<string>();

//                ae.Flatten();
//                foreach (var ex in ae.InnerExceptions)
//                {
//                    // string taskWasCancelled = string.Empty;
//                    //if (ex.InnerException is OperationCanceledException)
//                    //    taskWasCancelled = "Task was cancelled";

//                    errors.Add(ex.Message != null ? ex.Message : "No exception message found/set.");
//                    // Record string in Windows Event Log via Diagnostics.
//                }

//                if (errors.Count == 0)
//                    errors.Add("No exception message found/set.");

//                return errors;
//            }

//            private IList<string> Handle_Exception(Exception e)
//            {
//                IList<string> errors = new List<string>();

//                // Record the following - Exception and Inner Exception details                        
//                errors.Add((e.InnerException != null) ? e.InnerException?.Message
//                    : "Inner Exception is null");

//                return errors;
//            }

//            #endregion

//            #region IDisposable Support

//            private bool disposedValue = false;
//            protected virtual void Dispose(bool disposing)
//            {
//                if (!disposedValue)
//                {
//                    disposedValue = true;
//                }
//            }

//            // This code added to correctly implement the disposable pattern.
//            public void Dispose()
//            {
//                Dispose(true);
//                GC.SuppressFinalize(this);
//            }

//            #endregion
//        }
//    }


//using System;

//namespace Vantions.Examples
//    {
//        /// <summary>
//        /// Result is the Datastructure that represents a "result of computing done" in a Vanguard business method.
//        /// Result 'does not' return a value/object back to the calling code.
//        /// </summary>
//        public class Result : IDisposable
//        {
//            public bool IsSuccess { get; }
//            public string Error { get; private set; }
//            public bool IsFailure => !IsSuccess;

//            /// <summary>
//            /// Use of Static methods is encouraged to create an instance of this Result DataStructure.
//            /// </summary>
//            /// <param name="isSuccess"></param>
//            /// <param name="errorDescription"></param>
//            protected Result(bool isSuccess, string errorDescription)
//            {
//                // Check Invariance
//                if (isSuccess && errorDescription != string.Empty) throw new InvalidOperationException("Error description property should be null.");
//                if (!isSuccess && errorDescription == string.Empty) throw new InvalidOperationException("Error description property should not be null.");

//                IsSuccess = isSuccess;
//                Error = errorDescription;
//            }

//            public static Result Ok()
//            {
//                return new Result(true, string.Empty);
//            }

//            public static Result Fail(string message)
//            {
//                return new Result(false, message);
//            }

//            public static Result<T> Ok<T>(T value)
//            {
//                return new Result<T>(value, true, string.Empty);
//            }

//            public static Result<T> Fail<T>(string message)
//            {
//                return new Result<T>(default(T), false, message);
//            }

//            /// <summary>
//            /// Call me to inspect multiple Result objects.
//            /// After invoking multiple business methods pass me there respective array of Result objects.
//            /// 
//            /// I will loop through and do the needful.
//            /// One point of logging events - such as Diagnostic Event, Auditing etc.
//            /// 
//            /// </summary>
//            /// <param name="results">
//            /// Instances of result objects. 
//            /// Representing multiple business operations results.
//            /// </param>
//            /// <returns>Result - Ok - If all supplied Results were completed successfully.</returns>
//            public static Result Combine(params Result[] results)
//            {
//                foreach (Result result in results)
//                    if (result.IsFailure) return result;

//                return Ok();
//            }

//            #region IDisposable Support
//            private bool disposedValue = false; // To detect redundant calls

//            protected virtual void Dispose(bool disposing)
//            {
//                if (!disposedValue)
//                {
//                    disposedValue = true;
//                }
//            }

//            // This code added to correctly implement the disposable pattern.
//            public void Dispose()
//            {
//                Dispose(true);
//                GC.SuppressFinalize(this);
//            }
//            #endregion
//        }

//        /// <summary>
//        /// Result<T> is the Datastructure that represents a "result of computing done" in a Vanguard business method.
//        /// Result<T> 'does return' a value/object back to the calling code.
//        /// </summary>
//        public class Result<T> : Result
//        {
//            private readonly T _value;

//            public T Value
//            {
//                get
//                {
//                    if (!IsSuccess) throw new InvalidOperationException();

//                    return _value;
//                }
//            }

//            protected internal Result(T value, bool isSuccess, string error)
//                : base(isSuccess, error)
//            {
//                _value = value;
//            }
//        }
//    }



//    namespace Vantions.Examples
//    {
//        /// <summary>
//        /// "ValueObject" existSs to Vage(wage – used V to imply Pun) a war against Primitive Value types.
//        /// You should use me to get over your obsession of value types.
//        /// 
//        /// Think before you use – string email in a method signature.
//        /// 
//        /// How about making a class called Email?
//        /// The said class will house email specific validation, 
//        /// vanguard specific validations(ex.Email should have @switch in them.) etc.
//        /// 
//        /// Method signature could be – SomeMethod(Email primaryEmail, Email secondaryEmail)
//        /// And the Email class will take care that the passed string adheres to our requirements.
//        ///
//        /// What a way to avoid CODE DUPLICATION! 
//        /// </summary>
//        public abstract class ValueObject<T>
//            where T : ValueObject<T>
//        {
//            #region Public Members, properties etc.

//            public override bool Equals(object obj)
//            {
//                var valueObject = obj as T;

//                if (ReferenceEquals(valueObject, null)) return false;

//                return EqualsCore(valueObject);
//            }

//            public override int GetHashCode()
//            {
//                return GetHashCodeCore();
//            }

//            #endregion

//            #region Best part - Operator Overloading! - Public Static Methods.

//            public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
//            {
//                if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

//                if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

//                return a.Equals(b);
//            }

//            public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
//            {
//                return !(a == b);
//            }

//            #endregion


//            #region Protected Members, properties etc.

//            protected abstract bool EqualsCore(T other);
//            protected abstract int GetHashCodeCore();

//            #endregion
//        }
//    }


//    namespace Vantions.Examples
//    {
//        public class Email : ValueObject<Email>
//        {
//            private readonly string _emailValue;

//            private Email(string emailValue)
//            {
//                _emailValue = emailValue;
//            }

//            public static Result<Email> Create(string emailValue)
//            {
//                if (string.IsNullOrWhiteSpace(emailValue) || string.IsNullOrEmpty(emailValue))
//                    return Result.Fail<Email>("Email should not be empty");

//                emailValue = emailValue.Trim();

//                if (emailValue.Length > 256) return Result.Fail<Email>("Email is too long");
//                if (!emailValue.Contains("@")) return Result.Fail<Email>("Email is invalid");

//                return Result.Ok(new Email(emailValue));
//            }

//            protected override bool EqualsCore(Email other)
//            {
//                return _emailValue == other._emailValue;
//            }

//            protected override int GetHashCodeCore()
//            {
//                return _emailValue.GetHashCode();
//            }

//            /// <summary>
//            /// Overloaded implicit conversion operator for Email Primitive Type.
//            /// From Email Object to plain Email String (string object - wink wink)
//            /// 
//            /// Example of this implicit conversion -
//            /// Email _email = GetEmail();
//            /// sting _emailString = _email;
//            /// </summary>
//            /// <param name="email"></param>
//            public static implicit operator string(Email email)
//            {
//                return email._emailValue;
//            }

//            /// <summary>
//            /// Overloaded explicit conversion operator for Email Primitive Type.
//            /// From Email string to Email Object
//            /// 
//            /// Example of this explicit conversion -
//            /// string _emalString = "vanguard-validEmail@switch.gov.au"
//            /// Email _emailObject= Email(_emalString); 
//            /// </summary>
//            /// <param name="email"></param>
//            public static explicit operator Email(string email)
//            {
//                return Create(email).Value;
//            }
//        }
//    }


//using System;

//namespace Vantions.Examples
//    {
//        /// <summary>
//        /// FuncFact: "Tony Hoare" the inventer of NULL calls it a Billion-Dollar mistake!
//        /// 
//        /// "Tony Hoare"Ss exact words: "I call it my billion-dollar mistake. It has caused
//        /// a billion dollars of pain and damage in the last forty years". 
//        /// 
//        /// - and COUNTING may I add. but, Not anymore...
//        /// so here we are, fixing Tonys' Billion-Dollar mistake.
//        /// 
//        /// Maybe Type works with REFERENVE TYPES only.
//        /// 
//        /// A Maybe varaiable is a Value Type itself a STRUCT and not a reference Type and so it will never be NULL.
//        /// 
//        /// Goal is:
//        /// 1. To address dishonesty of method signatures which take or return reference types.
//        /// 2. Enforce the use of the Maybe Type, so Null Pointer Exceptions are things of the PAST. 
//        /// </summary>
//        public struct Maybe<T> : IEquatable<Maybe<T>> where T : class
//        {
//            private readonly T _value;

//            public T Value
//            {
//                get
//                {
//                    if (HasNoValue)
//                        throw new InvalidOperationException
//                            ($"Expected reference type is null. {typeof(T).ToString()} is Null.");
//                    return _value;
//                }
//            }

//            public bool HasValue => _value != null;
//            public bool HasNoValue => !HasValue;

//            private Maybe(T value)
//            {
//                _value = value;
//            }

//            /// <summary>
//            /// Use me to create a Maybe Type.
//            /// 
//            /// Example - 
//            /// Maybe<string> nullableString = "abscefghijklmnopqrstuvwxyz";
//            /// instead of: Maybe<string> nullableString = new Maybe<string>("abscefghijklmnopqrstuvwxyz");
//            /// 
//            /// Also, the following will be automatically translated to Maybe Type!
//            /// Maybe<string> nullableString = null;
//            /// 
//            /// This will work fine as well!!
//            /// int? someNumber = null;
//            /// someNumber.ToString(); // -- No Null Pointers Exception thrown here.   
//            /// </summary>
//            /// <param name="value">The Type that can be a Null,</param>
//            public static implicit operator Maybe<T>(T value)
//            {
//                return new Maybe<T>(value);
//            }

//            /// <summary>
//            /// Compare Instance of MayBe Type to Undelying instance type.
//            /// Maybe<string> nullable = "abc";
//            /// string nonNullable = "abc";
//            /// bool equal = (nullable == nonNullable)
//            /// </summary>
//            /// <param name="maybe"></param>
//            /// <param name="value"></param>
//            /// <returns></returns>
//            public static bool operator ==(Maybe<T> maybe, T value)
//            {
//                if (maybe.HasNoValue) return false;
//                return maybe.Value.Equals(value);
//            }

//            /// <summary>
//            /// 
//            /// Same as Above
//            /// 
//            /// Compare Instance of MayBe Type to Undelying instance type.
//            /// Maybe<string> nullable = "abc";
//            /// string nonNullable = "abc";
//            /// bool equal = (nullable == nonNullable)
//            /// </summary>
//            /// <param name="maybe"></param>
//            /// <param name="value"></param>
//            /// <returns></returns>
//            public static bool operator !=(Maybe<T> maybe, T value)
//            {
//                return !(maybe == value);
//            }


//            /// <summary>
//            /// Compare Two Nullable Instances. - Use Equals Method.
//            /// </summary>
//            /// <param name="firstMaybe"></param>
//            /// <param name="secondMaybe"></param>
//            /// <returns></returns>
//            public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//            {
//                return firstMaybe.Equals(secondMaybe);
//            }

//            /// <summary>
//            /// Compare Two Nullable Instances. 
//            /// </summary>
//            /// <param name="firstMaybe"></param>
//            /// <param name="secondMaybe"></param>
//            /// <returns></returns>
//            public static bool operator !=(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//            {
//                return !(firstMaybe == secondMaybe);
//            }

//            /// <summary>
//            /// Used by: public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//            /// </summary>
//            /// <param name="obj"></param>
//            /// <returns></returns>
//            public override bool Equals(object obj)
//            {
//                if (!(obj is Maybe<T>)) return false;
//                var other = (Maybe<T>)obj;

//                return Equals(other);
//            }

//            /// <summary>
//            /// Used by: public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//            /// </summary>
//            /// <param name="other"></param>
//            /// <returns></returns>
//            public bool Equals(Maybe<T> other)
//            {
//                if (HasNoValue && other.HasNoValue) return true;
//                if (HasNoValue || other.HasNoValue) return false;

//                return _value.Equals(other._value);
//            }

//            public override int GetHashCode()
//            {
//                return _value.GetHashCode();
//            }

//            public override string ToString()
//            {
//                if (HasNoValue) return "No Value";
//                return Value.ToString();
//            }

//            public T Unwrap(T defaultValue = default(T))
//            {
//                if (HasValue) return Value;
//                return defaultValue;
//            }

//            public Maybe<TO> Bind<TO>(Func<T, Maybe<TO>> func) where TO : class
//            {
//                return _value != null ? func(_value) : new Maybe<TO>();
//            }
//        }
//    }


//using System;

//namespace Vantions.Extensions
//    {
//        /// <summary>
//        /// UsingBlockStatic - An extension method for Using block.
//        /// </summary>
//        public static class UsingBlockStatic
//        {
//            /// <summary>
//            /// Use me instead of Using block.        
//            /// Example usage - obj.Use(  x=> x.DoAction(); x.DoAllYouWantOfMe(); x.SummonSwitchBlockssss(); );
//            /// 
//            /// </summary>
//            /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
//            /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
//            /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
//            /// <example>obj.Use(  x=> x.DoAction();); where obj implements <see cref="IDisposable"/></example>
//            public static void Use<T>(this T obj, Action<T> action) where T : IDisposable
//            {
//                using (obj)
//                {
//                    action(obj);
//                }
//            }
//        }

//        /// <summary>
//        /// UsingBlock - I am a class with method Use() which calls using block.
//        /// My Use() calls Dispose(true) internally to mark myself for killing.
//        /// You dont have to worry about anything. 
//        /// Use me for cleaner code.
//        /// 
//        /// and yes I am CURSED. 
//        /// </summary>
//        public class UsingBlock : IDisposable
//        {
//            /// <summary>
//            /// Use me instead of Using block.        
//            /// Example usage - 
//            /// new UsingBlock().Use(diag, diag => { diag.SummonSwitchBlockssss(); });
//            /// 
//            /// </summary>
//            /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
//            /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
//            /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
//            /// <example>new UsingBlock().Use(diag, diag => { diag.SummonSwitchBlockssss(); });
//            /// where diag implements <see cref="IDisposable"/></example>
//            public void Use<T>(T obj, Action<T> action) where T : IDisposable
//            {
//                using (this) // I am cursed.
//                {
//                    using (obj)
//                    {
//                        action(obj);
//                    }
//                }
//            }

//            #region IDisposable Support
//            private bool disposedValue = false; // To detect redundant calls

//            protected virtual void Dispose(bool disposing)
//            {
//                if (!disposedValue)
//                {
//                    disposedValue = true;
//                }
//            }

//            // This code added to correctly implement the disposable pattern.
//            public void Dispose()
//            {
//                Dispose(true);
//                GC.SuppressFinalize(this);
//            }
//            #endregion
//        }
//    }



//using System;

//namespace Vantions.Examples
//    {
//        public static class ResultOrchestrator
//        {
//            public static Result<T> ToResult<T>(this Maybe<T> maybe, string errorMessage)
//                where T : class
//            {
//                if (maybe.HasNoValue) return Result.Fail<T>(errorMessage);
//                return Result.Ok<T>(maybe.Value);
//            }

//            /// <summary>
//            /// Extension method OnSuccess() - This method executes a action thta doesnt take any arguments and
//            /// returns Results.Ok() regardless, of what happened in action delegate.
//            /// 
//            /// Rarely, will be used.
//            /// </summary>
//            /// <param name="result">The result object resceived from previous business method call</param>
//            /// <param name="action">Code to execute, if the previous result (of code executed) was all good.</param>
//            /// <returns></returns>
//            public static Result OnSuccess(this Result result, Action action)
//            {
//                if (result.IsFailure) return result;

//                action();

//                return Result.Ok();
//            }

//            /// <summary>
//            /// Extension method OnSuccess() - This method executes a action thta returns a Result object
//            /// which determines what happened in execution of Function delegate.
//            /// 
//            /// Prefered Method.
//            /// 
//            /// </summary>
//            /// <param name="result">The result object resceived from previous business method call</param>
//            /// <param name="action">Code to execute, if the previous result (of code executed) was all good.</param>
//            /// <returns></returns>
//            public static Result OnSuccess(this Result result, Func<Result> function)
//            {
//                if (result.IsFailure) return result;

//                return function();
//            }

//            /// <summary>
//            /// Execute compensation logic.
//            /// 
//            /// </summary>
//            /// <param name="result">The result object received from previous business method call, that Failed.</param>
//            /// <param name="action">Code to Log the above Failed Result.</param>
//            /// <returns></returns>
//            public static Result OnFaliure(this Result result, Action action)
//            {
//                if (result.IsFailure) action();

//                // return previous Failed Result as it is.
//                return result;
//            }

//            public static Result OnBoth(this Result result, Action<Result> action)
//            {
//                action(result);
//                return result;
//            }

//            public static T OnBoth<T>(this Result result, Func<Result, T> function)
//            {
//                return function(result);
//            }
//        }
//    }



//using System;

//namespace Vantions.Examples
//    {
//        public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }
//        public struct FoodItem : IEquatable<FoodItem>
//        {
//            private readonly string _name;
//            private readonly FoodGroup _group;

//            public string Name { get { return _name; } }
//            public FoodGroup Group { get { return _group; } }

//            public FoodItem(string name, FoodGroup group)
//            {
//                this._name = name;
//                this._group = group;
//            }

//            public override string ToString()
//            {
//                return _name;
//            }

//            // Override - object.Equals() to improve performance by avoiding Reflection. Need to avoid Boxing too.
//            // Implementing IEquatable<FoodItem> = Avoid Boxing and Get Type Safety.
//            // Implementing object.Equals() = Avoid reflection
//            // Implementing == -> Allow Using ==
//            // Implementing != -> Required by C# as we have implemeneted ==
//            // Implementing object.GetHashCode() = Good Practice

//            public bool Equals(FoodItem other)
//            {
//                return this._name == other._name && this._group == other._group;
//            }

//            // Because of Boxing and Casting, IEquatable<FoodItem>.Equals() will still be more efficient.
//            // Avoid using this where possible.
//            public override bool Equals(object obj)
//            {
//                if (obj is FoodItem)
//                    return Equals((FoodItem)obj);

//                return false;
//            }

//            public static bool operator ==(FoodItem lhs, FoodItem rhs)
//            {
//                return lhs.Equals(rhs); // Calling IEquatable.Equals(FoodItem other)
//            }

//            public static bool operator !=(FoodItem lhs, FoodItem rhs)
//            {
//                return !lhs.Equals(rhs); // Calling IEquatable.Equals(FoodItem other)
//            }

//            // Thios returns a 32 bit Integer - 32 bit hash of the value of the object
//            // This allows the type to be used as KEY in collections that use HashTables 
//            // (Allows putting the object in Hash tables) ex. Dictionary<TKey, TValue>() Contains a Hash Table.
//            // Hash Table requires that - if x.Equals(y) then we must have - x.GetHashCode() == y.GetHashCode()
//            public override int GetHashCode()
//            {
//                return _name.GetHashCode() ^ _group.GetHashCode();
//            }
//        }
//    }



//    #region Avoid in Gen App
//    namespace Vantions.Examples
//    {
//        public class FoodObject
//        {
//            private readonly string _name;
//            private readonly FoodGroup _group;

//            public string Name { get { return _name; } }
//            public FoodGroup Group { get { return _group; } }

//            public FoodObject(string name, FoodGroup group)
//            {
//                this._name = name;
//                this._group = group;
//            }

//            public override string ToString()
//            {
//                return _name;
//            }



//            #region IEquatableComparor can replace below code
//            public override bool Equals(object obj)
//            {
//                if (obj == null)
//                    return false;

//                if (ReferenceEquals(obj, this))
//                    return true;

//                if (obj.GetType() != this.GetType())
//                    return false;

//                FoodObject rhs = obj as FoodObject;
//                return this._name == rhs._name && this._group == rhs._group;
//            }

//            public override int GetHashCode()
//            {
//                return this._name.GetHashCode() ^ this._group.GetHashCode();
//            }

//            public static bool operator ==(FoodObject x, FoodObject y)
//            {
//                return object.Equals(x, y);
//            }

//            public static bool operator !=(FoodObject x, FoodObject y)
//            {
//                return !(object.Equals(x, y));
//            }
//            #endregion

//        }
//    }


//    namespace Vantions.Examples
//    {
//        // Being Sealded affects how we implement equality.
//        public sealed class CookedFoodObject : FoodObject
//        {
//            private string _cookingMethod;

//            public string CookingMethod { get { return _cookingMethod; } }

//            public CookedFoodObject(string cookingMethod, string name, FoodGroup group)
//                : base(name, group)
//            {
//                this._cookingMethod = cookingMethod;
//            }


//            public override string ToString()
//            {
//                return string.Format("{0} {1}", _cookingMethod, Name);
//            }

//            public override bool Equals(object obj)
//            {
//                if (ReferenceEquals(obj, this))
//                    return true;

//                if (!base.Equals(obj))
//                    return false;

//                CookedFoodObject rhs = (CookedFoodObject)obj;
//                return this._cookingMethod == rhs._cookingMethod;
//            }

//            public override int GetHashCode()
//            {
//                return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
//            }

//            public static bool operator ==(CookedFoodObject x, CookedFoodObject y)
//            {
//                return object.Equals(x, y);
//            }

//            public static bool operator !=(CookedFoodObject x, CookedFoodObject y)
//            {
//                return !(object.Equals(x, y));
//            }

//        }
//    }
}
