using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}


//using System;

//namespace PerfGuard.Core
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

//        /// <summary>
//        /// Compare Instance of MayBe Type to Undelying instance type.
//        /// Maybe<string> nullable = "abc";
//        /// string nonNullable = "abc";
//        /// bool equal = (nullable == nonNullable)
//        /// </summary>
//        /// <param name="maybe"></param>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public static bool operator ==(Maybe<T> maybe, T value)
//        {
//            if (maybe.HasNoValue) return false;
//            return maybe.Value.Equals(value);
//        }

//        /// <summary>
//        /// 
//        /// Same as Above
//        /// 
//        /// Compare Instance of MayBe Type to Undelying instance type.
//        /// Maybe<string> nullable = "abc";
//        /// string nonNullable = "abc";
//        /// bool equal = (nullable == nonNullable)
//        /// </summary>
//        /// <param name="maybe"></param>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public static bool operator !=(Maybe<T> maybe, T value)
//        {
//            return !(maybe == value);
//        }


//        /// <summary>
//        /// Compare Two Nullable Instances. - Use Equals Method.
//        /// </summary>
//        /// <param name="firstMaybe"></param>
//        /// <param name="secondMaybe"></param>
//        /// <returns></returns>
//        public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//        {
//            return firstMaybe.Equals(secondMaybe);
//        }

//        /// <summary>
//        /// Compare Two Nullable Instances. 
//        /// </summary>
//        /// <param name="firstMaybe"></param>
//        /// <param name="secondMaybe"></param>
//        /// <returns></returns>
//        public static bool operator !=(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//        {
//            return !(firstMaybe == secondMaybe);
//        }

//        /// <summary>
//        /// Used by: public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//        /// </summary>
//        /// <param name="obj"></param>
//        /// <returns></returns>
//        public override bool Equals(object obj)
//        {
//            if (!(obj is Maybe<T>)) return false;
//            var other = (Maybe<T>)obj;

//            return Equals(other);
//        }

//        /// <summary>
//        /// Used by: public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
//        /// </summary>
//        /// <param name="other"></param>
//        /// <returns></returns>
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


//using System;

//namespace PerfGuard.Core
//{
//    /// <summary>
//    /// 
//    /// Result is the Datastructure that represents a <b>"result of computing done"</b> in a business method.
//    /// Result 'does not' return a value/object back to the calling code.
//    /// 
//    /// Result DataStructure not only returns the State of the Operation but also the Result of the Operation.
//    /// State = IsSuccessful, Result = Object reflecting CRUD result.
//    /// 
//    /// Result DataStructure - 
//    /// 1. Helps keep methods honest.
//    /// 2. Incorporate the result of an operation with its status.
//    /// 3. Unified error model.
//    /// 4. Only for expected failures.
//    /// 
//    /// Applications must be designed on 2 Golden Principles.
//    /// 
//    /// 1. Immutable Core - Should be responsible for all the Business Rules in the Application.
//    /// 2. Mutable Shell - Should as Dumb as possible.
//    /// 
//    /// Other Rules:
//    /// 1. Always prefer "Return Values" <b>over</b> "Exceptions".
//    ///    Exceptions lead to less a maintainable codebase.
//    ///   
//    ///    Use Exceptions when in Exceptional Circumstances [Data Centre lpst Power Supply or got Nuked.]
//    ///    Validations ARE NOT Exceptions, as Validations by definition expect a Faulty Input/Incorrect Data. 
//    ///    
//    /// 2. Fail-Fast Principle: Interrept the code execution entirely. This will lead to stable codebase, 
//    ///    and better User experience.
//    ///    
//    /// 3. CQS - "Command-Query-Sepration" principle.
//    /// 
//    /// 4. DRY - Dont repeat yourself principle.
//    /// 
//    /// </summary>
//    public class Result : IDisposable
//    {
//        public bool IsSuccess { get; }
//        public bool IsFailure => !IsSuccess;

//        /// <summary>
//        /// Make an effort. Explain the Occured Error in Plain English.
//        /// DisplayError should be generic enough to end on UI, and still make sense to the end Users.
//        /// 
//        /// Be careful, as too much of information can lead to Security Flaws.
//        /// So, try and keep DisplayError message generic and simple.
//        /// 
//        /// DisplayError is basically, a polite apology plus some helful text.
//        /// </summary>
//        /// 
//        /// <example>
//        /// {Username}, seems like something went wrong while processing enrolements. 
//        /// Are army of monkeys is on this and hopefully this should be fixed, shortly.
//        /// How about you try again in a minute!
//        /// </example>
//        public string DisplayError { get; private set; }       

//        /// <summary>
//        /// This is an Error message, that is for Application Developers, BAs and other relevant parties.
//        /// This can be system level, detailed for indicationg the Exact Technical cause of the error.
//        /// </summary>
//        public string Error { get; private set; }

//        /// <summary>
//        /// Use of Static methods is encouraged to create an instance of this Result DataStructure.
//        /// </summary>
//        /// <param name="isSuccess"></param>
//        /// <param name="errorDescription"></param>
//        protected Result(bool isSuccess, string displayErrorDescription, string appLevelErrorDescription)
//        {
//            // Check Invariance
//            if (isSuccess && (displayErrorDescription != string.Empty || appLevelErrorDescription != string.Empty))
//            {
//                throw new InvalidOperationException("Error description property(s) should be null.");
//            }
//            if (!isSuccess && displayErrorDescription == string.Empty)
//            {
//                throw new InvalidOperationException("Error description property should not be null.");
//            }

//            IsSuccess = isSuccess;
//            DisplayError = displayErrorDescription;
//            Error = appLevelErrorDescription;
//        }

//        public static Result Ok()
//        {
//            return new Result(true, string.Empty, string.Empty);
//        }
//        public static Result<T> Ok<T>(T value)
//        {
//            return new Result<T>(value, true, string.Empty, string.Empty);
//        }

//        public static Result Fail(string displayMessage)
//        {
//            return new Result(false, displayMessage, string.Empty);
//        }
//        public static Result<T> Fail<T>(string displayMessage)
//        {
//            return new Result<T>(default(T), false, displayMessage, string.Empty);
//        }        

//        public static Result Fail(string displayMessage, string appLevelMessage)
//        {
//            return new Result(false, displayMessage, appLevelMessage);
//        }
//        public static Result<T> Fail<T>(string displayMessage, string appLevelMessage)
//        {
//            return new Result<T>(default(T), false, displayMessage, appLevelMessage);
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

//    /// <summary>
//    /// Result<T> is the Datastructure that represents a "result of computing done" in a business method.
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

//        protected internal Result(T value, bool isSuccess, string displayError, string appLevelErrorDesc)
//            : base(isSuccess, displayError, appLevelErrorDesc)
//        {
//            _value = value;
//        }
//    }
//}

//namespace PerfGuard.Core
//{
//    /// <summary>
//    /// ValueObject: is here to wage a WAR againt "Primitive Obsession".
//    /// 
//    /// You should use me to get over your obsession of value types.
//    /// 
//    /// Think before you use – string email in a method signature.
//    /// 
//    /// How about making a class called Email?
//    /// The said class will house email specific validation, 
//    /// Our Application specific validations (ex.Email should have @ in them.) etc.
//    /// 
//    /// Method signature could be – SomeMethod(Email primaryEmail, Email secondaryEmail)
//    /// And the Email class will take care that the passed string adheres to our requirements.
//    ///
//    /// What a way to avoid CODE DUPLICATION! 
//    /// 
//    /// Say no more, to primitives, that are unviversal in our application.
//    /// Example - string email, string userId.
//    /// email and userId in our application have validation rules.
//    /// So, let us just define those validations in one place only.
//    /// Avoid code duplication and also make sure the validation is in 
//    /// place as a standard throughout our application.
//    /// 
//    /// this adheres to DRY principle which is "Dont Repeat Yourself".
//    /// 
//    /// ValueObject is the base class for all ValueObject(s). Like email, userId.
//    /// 
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

//namespace PerfGuard.Statics
//{
//    public static class EdPredicate
//    {
//        /// <summary>
//        /// MatchCount : Returns the number of elements in a ARRAY that satify 
//        /// a given condition. This can be used for quick checks.
//        /// 
//        /// eg - 10 Customers in ARRAY of Customer(s) of 100 have 
//        /// email-addresses provided.
//        /// </summary>
//        /// 
//        /// <typeparam name="T"></typeparam>
//        /// 
//        /// <param name="arr"></param>
//        /// <param name="condition"></param>
//        /// <returns>int : Number of Matches found.</returns>
//        /// 
//        /// <example>
//        ///     int numberOfNegativeNumbers = MatchCount(numbers, x => x lt 0);
//        ///     
//        /// /*LINQ Equivalent */
//        ///     int numberOfNegativeNumbers = numbers.Count(x => x lt 0);
//        /// </example>
//        public static int MatchCount<T>(T[] arr, Predicate<T> condition)
//        {
//            int counter = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (condition(arr[i]))
//                {
//                    counter++;
//                }
//            }
//            return counter;
//        }
//    }
//}


//using System;

//namespace PerfGuard.Statics
//{
//    public static class EdUsing
//    {
//        /// <summary>
//        /// Use me instead of Using block.      
//        /// 
//        /// Example usage - obj.Use(  x=> x.DoAction(); x.DoAllYouWantOfMe(); x.SummonSwitchBlockssss(); );
//        /// 
//        /// </summary>
//        /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
//        /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
//        /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
//        /// 
//        /// <example>
//        ///     obj.Use(x => x.DoAction(); ); where obj implements <see cref="IDisposable"/>
//        /// </example>
//        public static void Use<T>(this T obj, Action<T> action) where T : IDisposable
//        {
//            using (obj)
//            {
//                action(obj);
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//namespace PerfGuard.Statics
//{
//    public static class FilterData
//    {

//        /// <summary>
//        /// Apply a function f to individual elements from T1 -> T2. 
//        /// 
//        /// <b>
//        /// 'MySelect' is a HOF. A Higher Order Function.
//        /// Treating functions as regular objects enables us to use 
//        /// them as arguments and results of other functions. 
//        /// Functions that handle other functions are 
//        /// called higher order functions.
//        /// </b>
//        /// 
//        /// </summary>
//        /// 
//        /// <typeparam name="T1">The data type to be worked on.
//        /// </typeparam>
//        /// <typeparam name="T2">the returned data. Filtered/sorted (etc...) 
//        /// based on function f.
//        /// </typeparam>
//        /// 
//        /// <param name="data">
//        /// List of objects (etc...) crap to work on.
//        /// </param>
//        /// <param name="f">
//        /// the Func that returns T2. 
//        /// T2 is the data that you want after applying the rules you want.
//        /// </param>
//        /// 
//        /// <returns>
//        /// New IEnumerable<T2> with elements of T1 after being applied the 
//        /// provided function f.
//        /// </returns>
//        /// 
//        /// <example>
//        /// In this example, the function iterates through the list, <b>applies 
//        /// the function f to each element, puts the result in the 
//        /// new list, and returns the collection.</b>
//        /// By changing function f, you can create various transformations 
//        /// of the original sequence using the same generic higher order function. 
//        /// 
//        /// </example>
//        public static IEnumerable<T2> MySelect<T1, T2>
//            (this IEnumerable<T1> data, Func<T1, T2> f)
//        {
//            IList<T2> retVal = new List<T2>();
//            foreach (T1 x in data) retVal.Add(f(x));
//            return retVal;
//        }


//        /// <summary>
//        /// Compose - will convert Type 1 straight to Type 3.
//        /// 
//        /// The caller need not worry about the transformation.
//        /// Caller can simply request compose to convert objects 
//        /// of Type 1 to Type 3 straight.
//        /// 
//        /// The User - doesnt care: when Marketing turns into sales, 
//        /// but they might care about marketing converting 
//        /// into after sales service.
//        /// 
//        /// The chain here would be: Marketing/Lead -> Sales -> After Sales Service.
//        /// 
//        /// </summary>
//        /// 
//        /// <typeparam name="T1">Type 1</typeparam>
//        /// <typeparam name="T2">Type 2</typeparam>
//        /// <typeparam name="T3">Type 3</typeparam>
//        /// 
//        /// <param name="f">function f: that converts Type 1 to Type 2</param>
//        /// <param name="g">function g: that converts Type 2 to Type 3</param>
//        /// 
//        /// <returns>
//        /// Func<T1, T3>: Which means - This function simply converts 
//        /// Objects of Type T1 to T3. 
//        /// </returns>
//        public static Func<T1, T3> Compose<T1, T2, T3>
//            (Func<T1, T2> f, Func<T2, T3> g)
//        {
//            return (x) => g(f(x));
//        }
        

//        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2,
//                    T3, TResult>(Func<T1, T2, T3, TResult> function)
//        {
//            return a => b => c => function(a, b, c);
//        }

//        //var curriedDistance = Curry<double, double, double, double>(Distance);
//        //        //double d = curriedDistance(3)(4)(12);

//        //static double Distance(double x, double y, double z)
//        //{
//        //    return Math.Sqrt(x * x + y * y + z * z);
//        //}


//        //public static Func<X, Z> Compose<X, Y, Z>(Func<X, Y> f, Func<Y, Z> g)
//        //{
//        //    return (x) => g(f(x));
//        //}
//        //Func<double, double> sin = Math.Sin;
//        //Func<double, double> exp = Math.Exp;
//        //Func<double, double> exp_sin = Compose(sin, exp);
//        //double y = exp_sin(3);

//    }
//}

//using System;

//namespace PerfGuard.Statics
//{
//    public static class Utilities
//    {


//        /// <summary>
//        /// 
//        /// </summary>
//        /// <typeparam name="T">
//        /// The type of Object to be returned.
//        /// </typeparam>
//        /// <param name="func">
//        /// The code that returns Type T.
//        /// </param>
//        /// <param name="cacheInterval">
//        /// Time interval in <b>Seconds</b>.
//        /// Function <b>func</b> will be executed again after the cacheInterval 
//        /// has elapsed.
//        /// </param>
//        /// <returns></returns>
//        /// 
//        /// <example>
//        /// 
//        /// Func<DateTime> now = () => DateTime.Now;
//        /// Func<DateTime> nowCached = now.Cache(4);
//        ///
//        /// Console.WriteLine("\tCurrent time\tCached time");
//        /// for (int i = 0; i lt 20; i++)
//        /// {
//        ///     Console.WriteLine("{0}.\t{1:T}\t{2:T}", i+1, now(), nowCached());
//        ///     Thread.Sleep(1000);
//        /// }
//        /// 
//        /// </example>
//        public static Func<T> Cache<T>(this Func<T> func, int cacheInterval)
//        {
//            var cachedValue = func();
//            var timeCached = DateTime.Now;

//            Func<T> cachedFunc = 
//                () => {
//                            if ((DateTime.Now - timeCached).Seconds >= cacheInterval)
//                            {
//                                timeCached = DateTime.Now;
//                                cachedValue = func();
//                            }
//                            return cachedValue;
//                       };

//            return cachedFunc;
//        }

//        // Recursion is the ability that function can call itself
//        // https://www.codeproject.com/Articles/375166/Functional-programming-in-Csharp




//    }
//}



//using PerfGuard.Core;

//namespace PerfGuard.ValueObjects
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
//        /// string _emalString = "schools-validEmail@education.gov.au"
//        /// Email _emailObject= Email(_emalString); 
//        /// </summary>
//        /// <param name="email"></param>
//        public static explicit operator Email(string email)
//        {
//            return Create(email).Value;
//        }
//    }
//}











