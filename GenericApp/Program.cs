using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GenericApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run(); // some comment. some more. and more. check
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}


namespace PerfGuard.Constants
{
	using System;
	using System.Text;

    public static class Messages
    {
        #region Message(s).

        public const string TASK_FAILED_FUNNY =
            "Opps! we dropped the ball. Our army of monkeys is on this, meanwhile can you please try again soon.";

        public const string ERROR_DESCRIPTION_PROPERTIES_SHOULD_BE_NULL = 
            "Error description property(s) should be null.";

        public const string ERROR_DESCRIPTION_PROPERTIES_SHOULD_NOT_BE_NULL =
            "Error description property(s) should not be null.";

        public const string TASK_WAS_CANCELLED = "Task was cancelled.";

        public const char SPACE = ' ';
        public const char PERIOD = '.';
        public const char COMMA = ',';

        public const string UNDER_SCORE = "_";
        public const string FORWARD_SLASH = "/";
        public const string SPACE_IN_STRING = " ";

        public const string ALL_TASKS_FAILED = "All tasks failed.";

        public const string FAILED_TO_INITIALISE_FROM_CONFIGURATION = "Initialising from configuration has failed. Configuration string provided is:";

        public const string CONFIGURATION_KEY_PROVIDED = "Configuration KEY provided:";
        public const string CONFIGURATION_VALUE_IS_NULL_FOR_KEY = "Configuration value is null for KEY:";


        public const string NotNullStringProperty_Is_NULL = "NotNullStringProperty should not be null/empty.";
        public const string NotNullStringProperty_No_Details_Provided = "No details have been provided as to why the property is null. The location where its set etc. Nothing is provided.";
        
        public const string EMAIL_IS_NULL = "Email should not be null/empty.";
        public const string EMAIL_IS_TOO_LONG = "Email is too long";
        public const string EMAIL_INVALID = "Email is invalid";

        public const string KEY_MASK = "--::--";
        public readonly static string KEY_MASK_Base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY_MASK));

        public const string AUTHENTICATION_FAILED = "Authentication failed.";

        public const string SchoolHubApi_Jwt_Audience_AppKey = "SchoolHubApi_Jwt_ValidAudience";
        public const string SchoolHubApi_Jwt_Issuer_AppKey = "SchoolHubApi_Jwt_ValidIssuer";
        public const string Jwt_Token_Validation_Limit_In_Minutes = "SchoolHubApi_Jwt_Token_Validation_Limit_In_Minutes";

        public const string CalledFromMethod = "Called from method: ";
        public const string FilePathOfCalledCode = "File path: ";
        public const string LineNumberOfCalledCode = "Called from line number: ";

        #endregion


        #region Exception related message(s).

        public const string INNER_EXCEPTION_IS_NULL = "Inner Exception is null.";
        public const string NO_EXCEPTIONS_FOUND = "No exception message found/set.";

        public const string DETAILED_MESSAGE_RETURNED_BY_SEMIS_SERVICE = 
            "Exception message(s) returned by SEMIS service:";

        public const string NO_MESSAGES_FOUND = "No message(s) found/set.";

        public const string INTERNAL_SERVER_ERROR = "Internal server error. Please try again later.";

        public const string APPEND_PLEASE_TRY_AGAIN = ". Please try again.";

        public const string FAILED_TO_MARSHAL_PTR_TO_STRING = "Failed to marshal supplied string, system exception.";
        public const string FAILED_TO_MARSHAL_PTR_TO_STRING_USER_DISPLAY_MESSAGE = "We have encountered something special, we are looking into the issue occurred. Please, try again in a while.";
        public const string FAILED_TO_MARSHAL_SECURESTRING_TO_CHAR_ARRAY = "Failed to marshal supplied secure string, system exception.";

        public const string EXCEPTION_ALREADY_RECORDED = "Exception has been or should be recorded in valid place by now. Moving on.";

        #endregion

        #region Maybe Type 

        public const string NO_VALUE = "No Value";

        public const string EXPECTED_REFERENCE_IS_NULL = 
            "Expected reference type is null.";

        public const string IS_NULL = "is Null.";

        #endregion


    }
}

namespace PerfGuard.Constants
{
    public static class Misc
    {
        public const int HMAC_KEY_SIZE_32_BYTES = 32;

        public const int DIGIT_ZERO = 0;
        public const int DIGIT_ONE = 1;

        public const int BEARER_PLUS_SPACE_LENGTH = 7;

        public const int PBKDF2_MIN_ROUNDS = 150;
        public const int PBKDF2_ROUNDS = 500; // This should be 50,000 or so, but giving it a go with less rounds. This should alos comply with Moores Law.
        public const int PSEUDO_RANDOM_BYTES_TO_GENERATE = 32;

        public const int KEY_OF_8_BYTES = 8;
        public const int KEY_OF_24_BYTES_FOR_TripleDES = 24;

        public const int INITIALIZATION_VECTOR_OF_8_BYTES = 8;

        public const int KEY_OF_32_BYTES_FOR_AES = 32;
        public const int INITIALIZATION_VECTOR_16_BYTES_FOR_AES = 16;

        public const int RSA_2048_BITS_KEY = 2048;
        public const int RSA_4096_BITS_KEY = 4096;

        public const string SHA_256_HASH_ALGORITHM = "SHA256";

        public const string STRING_NOVALUE_POVIDED = "NVP";

        public const int List_IndexOf_WhenValueNotFound = -1;

        public const int EMAIL_ALLOWED_LENGTH = 256;
        public const string EMAIL_SHOULD_CONTAIN_AT = "@";

        public const bool TRUE = true;
        public const bool FALSE = false;

        public const char OPENING_SQUARE_BRACKET = '[';
        public const char CLOSING_SQUARE_BRACKET = ']';

        public const char OPENING_LOOP = '{';
        public const char CLOSING_LOOP = '}';

        public const char COLON = ':';

        #region - Reading a Configuration String from a Configuration file or from [Granted].[Core].[Configuration] Database Table - XML Format.

        /*
         * Sample Pattern is: 
         * example of value from [Granted].[Core].[Configuration] Database Table       
         */

        public const string X_PATH_CATEGORIES_PATH_TAG = "/category"; 
        public const string X_PATH_MASTER_CATEGORY_TAG_IN_CATEGORY = "masterCategory";
        public const string X_PATH_MASTER_CATEGORY_HEADER_NAME_PATH_IN_CATEGORY = "headerName";
        public const string X_PATH_MASTER_CATEGORY_ORIGINAL_ROW_NAME_TAG_IN_CATEGORY = "name";
        public const string X_PATH_SUB_CATEGORIES_PATH_IN_CATEGORY = "subCategory";
        public const string X_PATH_SUB_CATEGORY_HEADER_NAME_PATH_IN_CATEGORY = "headerName";
        public const string X_PATH_SUB_CATEGORY_LISTS_TAG_PATH_IN_CATEGORY = "list/name";

        #endregion 
    }
}



namespace PerfGuard.Core
{
	using PerfGuard.Constants;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	
    public class ExecuteMyCode : IDisposable
    {
        public string[] InTryBlock(Action codeToRun)
        {
            string[] _exceptions = new string[] { };
            try
            {
                codeToRun();
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
            return _exceptions;
        }

        public string[] ProcessInTryCatch(Action codeToRun, 
            Action<AggregateException> _handleAggregateException,
            Action<Exception>_handleException)
        {
            string[] _exceptions = new string[] { };
            try
            {
                codeToRun();
            }
            catch (AggregateException aggregateException)
            {
                // Record Exception using Diagnostics
                _exceptions = Handle_AggregateException(aggregateException).ToArray();
                _handleAggregateException(aggregateException);
            }
            catch (Exception exception)
            {
                // Record Exception using Diagnostics
                _exceptions = Handle_Exception(exception).ToArray();
                _handleException(exception);
            }
            return _exceptions;
        }

        #region Tasks Exception Handling - AggregateException and Exception(Ss)

        /*
         * How to observe? Task Exceptions -
         * 1. call .wait or touch .Result - exception re-thrown at this point
         * 2. call Task.WaitAll - exceptions re-thrown when all have finished
         * 3. touch task's ,Exception property *after* task has completed
         * 4. subscribe to TaskScheduler.UnobservedTaskException     
         * 
         * If you do not do any of the above - the GC will throw the exception for you.
         * So, you better handle it while it lasts.
         */

        private IList<string> Handle_AggregateException(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {
                // string taskWasCancelled = string.Empty;
                //if (ex.InnerException is OperationCanceledException)
                //    taskWasCancelled = Messages.TASK_WAS_CANCELLED;

                errors.Add(ex.Message != null
                    ? ex.Message : Messages.NO_EXCEPTIONS_FOUND);
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add(Messages.NO_EXCEPTIONS_FOUND);

            return errors;
        }

        private IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException.Message
                : Messages.INNER_EXCEPTION_IS_NULL);

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


namespace PerfGuard.Core
{
	using PerfGuard.Constants;
	using System;
	
    /// <summary>
    /// FuncFact: "Tony Hoare" the inventer of NULL calls it a Billion-Dollar mistake!
    /// 
    /// "Tony Hoare"Ss exact words: "I call it my billion-dollar mistake. It has caused
    /// a billion dollars of pain and damage in the last forty years". 
    /// 
    /// - and COUNTING may I add. but, Not anymore...
    /// so here we are, fixing Tonys' Billion-Dollar mistake.
    /// 
    /// Maybe Type works with REFERENVE TYPES only.
    /// 
    /// A Maybe varaiable is a Value Type itself a STRUCT and not a reference Type and so it will never be NULL.
    /// 
    /// Goal is:
    /// 1. To address dishonesty of method signatures which take or return reference types.
    /// 2. Enforce the use of the Maybe Type, so Null Pointer Exceptions are things of the PAST. 
    /// </summary>
    public struct Maybe<T> : IEquatable<Maybe<T>> where T : class
    {
        private readonly T _value;

        public T Value
        {
            get
            {
                if (HasNoValue)
                    throw new InvalidOperationException
                        (Messages.EXPECTED_REFERENCE_IS_NULL + Messages.SPACE + 
                            typeof(T).ToString() + Messages.SPACE + Messages.IS_NULL);
                return _value;
            }
        }

        //public bool HasValue => _value != null;
        //public bool HasNoValue => !HasValue;

        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public bool HasNoValue
        {
            get
            {
                return !HasValue;
            }
        }

        private Maybe(T value)
        {
            _value = value;
        }

        /// <summary>
        /// Use me to create a Maybe Type.
        /// 
        /// Example - 
        /// Maybe<string> nullableString = "abscefghijklmnopqrstuvwxyz";
        /// instead of: Maybe<string> nullableString = new Maybe<string>("abscefghijklmnopqrstuvwxyz");
        /// 
        /// Also, the following will be automatically translated to Maybe Type!
        /// Maybe<string> nullableString = null;
        /// 
        /// This will work fine as well!!
        /// int? someNumber = null;
        /// someNumber.ToString(); // -- No Null Pointers Exception thrown here.   
        /// </summary>
        /// <param name="value">The Type that can be a Null,</param>
        public static implicit operator Maybe<T>(T value)
        {
            return new Maybe<T>(value);
        }

        /// <summary>
        /// Compare Instance of MayBe Type to Undelying instance type.
        /// Maybe<string> nullable = "abc";
        /// string nonNullable = "abc";
        /// bool equal = (nullable == nonNullable)
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool operator ==(Maybe<T> maybe, T value)
        {
            if (maybe.HasNoValue) return false;
            return maybe.Value.Equals(value);
        }

        /// <summary>
        /// 
        /// Same as Above
        /// 
        /// Compare Instance of MayBe Type to Undelying instance type.
        /// Maybe<string> nullable = "abc";
        /// string nonNullable = "abc";
        /// bool equal = (nullable == nonNullable)
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool operator !=(Maybe<T> maybe, T value)
        {
            return !(maybe == value);
        }


        /// <summary>
        /// Compare Two Nullable Instances. - Use Equals Method.
        /// </summary>
        /// <param name="firstMaybe"></param>
        /// <param name="secondMaybe"></param>
        /// <returns></returns>
        public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
        {
            return firstMaybe.Equals(secondMaybe);
        }

        /// <summary>
        /// Compare Two Nullable Instances. 
        /// </summary>
        /// <param name="firstMaybe"></param>
        /// <param name="secondMaybe"></param>
        /// <returns></returns>
        public static bool operator !=(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
        {
            return !(firstMaybe == secondMaybe);
        }

        /// <summary>
        /// Used by: public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Maybe<T>)) return false;
            var other = (Maybe<T>)obj;

            return Equals(other);
        }

        /// <summary>
        /// Used by: public static bool operator ==(Maybe<T> firstMaybe, Maybe<T> secondMaybe)
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Maybe<T> other)
        {
            if (HasNoValue && other.HasNoValue) return true;
            if (HasNoValue || other.HasNoValue) return false;

            return _value.Equals(other._value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            if (HasNoValue) return Messages.NO_VALUE;
            return Value.ToString();
        }

        public T Unwrap(T defaultValue = default(T))
        {
            if (HasValue) return Value;
            return defaultValue;
        }

        public Maybe<TO> Bind<TO>(Func<T, Maybe<TO>> func) where TO : class
        {
            return _value != null ? func(_value) : new Maybe<TO>();
        }
    }
}



namespace PerfGuard.Core
{

	using PerfGuard.Constants;
	using System;
	using System.Collections.Generic;
	
    /// <summary>
    /// 
    /// Result is the Datastructure that represents a <b>"result of computing done"</b> in a business method.
    /// Result 'does not' return a value/object back to the calling code.
    /// 
    /// Result DataStructure not only returns the State of the Operation but also the Result of the Operation.
    /// State = IsSuccessful, Result = Object reflecting CRUD result.
    /// 
    /// Result DataStructure - 
    /// 1. Helps keep methods honest.
    /// 2. Incorporate the result of an operation with its status.
    /// 3. Unified error model.
    /// 4. Only for expected failures.
    /// 
    /// Applications must be designed on 2 Golden Principles.
    /// 
    /// 1. Immutable Core - Should be responsible for all the Business Rules in the Application.
    /// 2. Mutable Shell - Should be as Dumb as possible.
    /// 
    /// Other Rules:
    /// 1. Always prefer "Return Values" <b>over</b> "Exceptions".
    ///    Exceptions lead to less a maintainable codebase.
    ///   
    ///    Use Exceptions when in Exceptional Circumstances [Data Centre lpst Power Supply or got Nuked.]
    ///    Validations ARE NOT Exceptions, as Validations by definition expect a Faulty Input/Incorrect Data. 
    ///    
    /// 2. Fail-Fast Principle: Interrept the code execution entirely. This will lead to stable codebase, 
    ///    and better User experience.
    ///    
    /// 3. CQS - "Command-Query-Sepration" principle.
    /// 
    /// 4. DRY - Dont repeat yourself principle.
    /// 
    /// </summary>
    public class Result : IDisposable
    {
        private bool isSuccess;
        private string displayError;
        private string error;

        public bool IsSuccess
        {
            get { return isSuccess; }            
        }

        //public bool IsFailure => !IsSuccess;

        public bool IsFailure
        {
            get
            {
                return !IsSuccess;
            }
        }

        /// <summary>
        /// Make an effort. Explain the Occured Error in Plain English.
        /// DisplayError should be generic enough to end on UI, and still make sense to the end Users.
        /// 
        /// Be careful, as too much of information can lead to Security Flaws.
        /// So, try and keep DisplayError message generic and simple.
        /// 
        /// DisplayError is basically, a polite apology plus some helful text.
        /// </summary>
        /// 
        /// <example>
        /// {Username}, seems like something went wrong while processing enrolements. 
        /// Our army of monkeys is on this and hopefully this should be fixed, shortly.
        /// How about you try again in a minute!
        /// </example>
        public string DisplayError { get { return displayError; } }        

        /// <summary>
        /// This is an Error message, that is for Application Developers, BAs and other relevant parties.
        /// This can be system level, detailed for indicationg the Exact Technical cause of the error.
        /// </summary>
        public string Error { get { return error; } }        

        /// <summary>
        /// Use of Static methods is encouraged to create an instance of this Result DataStructure.
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="errorDescription"></param>
        protected Result(bool isSuccess, string displayErrorDescription, string appLevelErrorDescription)
        {
            // Check Invariance
            if (isSuccess && (displayErrorDescription != string.Empty || appLevelErrorDescription != string.Empty))
            {
                throw new InvalidOperationException(Messages.ERROR_DESCRIPTION_PROPERTIES_SHOULD_BE_NULL);
            }
            if (!isSuccess && displayErrorDescription == string.Empty)
            {
                throw new InvalidOperationException(Messages.ERROR_DESCRIPTION_PROPERTIES_SHOULD_NOT_BE_NULL);
            }

            this.isSuccess = isSuccess;
            this.displayError = displayErrorDescription;
            this.error = appLevelErrorDescription;
        }

        public static Result Ok()
        {
            return new Result(true, string.Empty, string.Empty);
        }
        public static Result<T> Ok<T>(T value)
        {
            return new Result<T>(value, true, string.Empty, string.Empty);
        }

        public static Result Fail(string displayMessage)
        {
            return new Result(false, displayMessage, string.Empty);
        }
        public static Result<T> Fail<T>(string displayMessage)
        {
            return new Result<T>(default(T), false, displayMessage, string.Empty);
        }

        public static Result Fail(string displayMessage, string appLevelMessage)
        {
            return new Result(false, displayMessage, appLevelMessage);
        }
        public static Result<T> Fail<T>(string displayMessage, string appLevelMessage)
        {
            return new Result<T>(default(T), false, displayMessage, appLevelMessage);
        }

        /// <summary>
        /// Call me to inspect multiple Result objects.
        /// After invoking multiple business methods pass me there respective array of Result objects.
        /// 
        /// I will loop through and do the needful.
        /// One point of logging events - such as Diagnostic Event, Auditing etc.
        /// 
        /// </summary>
        /// <param name="results">
        /// Instances of result objects. 
        /// Representing multiple business operations results.
        /// </param>
        /// <returns>Result - Ok - If all supplied Results were completed successfully.</returns>
        public static Result Combine(params Result[] results)
        {
            foreach (Result result in results)
                if (result.IsFailure) return result;

            return Ok();
        }

        /// <summary>
        /// Call me to inspect multiple Result objects.
        /// After invoking multiple business methods pass me there respective array of Result objects.
        /// 
        /// I will loop through and do the needful.
        /// One point of logging events - such as Diagnostic Event, Auditing etc.
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="results">
        /// Instances of result objects. 
        /// Representing multiple business operations results.
        /// </param>
        /// <returns>Result - Ok - If all supplied Results were completed successfully.</returns>
        public static Result<TResult> Combine<TResult>(IList<Result<TResult>> results)
        {
            foreach (Result<TResult> result in results)
                if (result.IsFailure) return result;

            return Ok<TResult>(default(TResult));
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

    /// <summary>
    /// Result<T> is the Datastructure that represents a "result of computing done" in a business method.
    /// Result<T> 'does return' a value/object back to the calling code.
    /// </summary>
    public class Result<T> : Result
    {
        private readonly T _value;

        public T Value
        {
            get
            {
                if (!IsSuccess) throw new InvalidOperationException(this.DisplayError);

                return _value;
            }
        }

        protected internal Result(T value, bool isSuccess, string displayError, string appLevelErrorDesc)
            : base(isSuccess, displayError, appLevelErrorDesc)
        {
            _value = value;
        }

        protected internal Result(T value, bool isSuccess)
            : this(value, isSuccess, string.Empty, string.Empty)
        { }
    }
}



namespace PerfGuard.Core
{
	using System;
	
    public static class ResultExtensions
    {
        /// <summary>
        /// Convert Maybe to Result type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="maybe"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static Result<T> ToResult<T>(this Maybe<T> maybe, string errorMessage) 
            where T : class
        {
            if(maybe.HasNoValue)
            {
                return Result.Fail<T>(errorMessage);
            }

            return Result.Ok(maybe.Value);
        }

        /// <summary>
        /// Runs the specified action if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Result OnSuccess(this Result result, Action action)
        {
            if(result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute further action
            action();

            // all good
            return Result.Ok();
        }       

        /// <summary>
        /// Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnSuccess(this Result result, Func<Result> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func();           
        }        

        /// <summary>
        /// (Takes result in Func) Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnSuccess(this Result result, Func<Result, Result> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func(result);
        }        

        /// <summary>
        /// (Takes result<T> in Func) Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result<T> OnSuccess<T>(this Result<T> result, Func<Result<T>, Result<T>> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func(result);
        }        

        /// <summary>
        /// This is useful for specific Fetch Value and Then Update Operations.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnSuccess<T>(this Result<T> result, Func<Result<T>, Result> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func(result);
        }

        /// <summary>
        /// (Takes result<T> in Func) Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnSuccess<T, TResult>(this Result<T> result, Func<Result<T>, Result<TResult>> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func(result);
        }

        /// <summary>
        /// (Takes result<T> in Func) Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnFailureRunFunc<TResult>(this Result result, Func<Result, Result<TResult>> func)
        {
            if (result.IsFailure)
            {                
                // execute func code, this will return a Result.
                return func(result);
            }
           
            return result;
        }

        /// <summary>
        /// (Takes result<T> in Func) Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnSuccessProcessFurther<T, TResult>(this Result<T> result, Func<Result<T>, Result<TResult>> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func(result);
        }

        /// <summary>
        /// (Takes result<T> in Func) Runs the specified func code if executed operation is a Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnSuccessOfPreviousResult<T>(this Result<T> result, 
            Func<Result<T>, Result> func)
        {
            if (result.IsFailure)
            {
                // return previous result
                return result;
            }

            // execute func code, this will return a Result.
            return func(result);
        }

        /// <summary>
        /// Runs the specified action if executed operation is a Faliure.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Result OnFaliure(this Result result, Action action)
        {
            if (result.IsFailure)
            {
                // execute further action
                action();                
            }

            // return previous result
            return result;
        }

        /// <summary>
        /// Runs the specified func code if executed operation is a Faliure.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnFaliure(this Result result, Func<Result> func)
        {
            if (result.IsFailure)
            {
                // execute func code, this will return a Result.
                return func();
            }

            return result;
        }

        /// <summary>
        /// (Takes result in Func) Runs the specified func code if executed operation is a Success.
        /// or returns the failed result object as-is.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnFaliure(this Result result, Func<Result,Result> func)
        {
            if (result.IsFailure)
            {
                // execute func code, this will return a Result.
                return func(result);
            }

            return result;
        }

        /// <summary>
        /// (Takes result in Func) Runs the specified func code if executed operation is a Success.
        /// or returns the failed result object as-is.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result<T> OnFaliure<T>(this Result<T> result, Func<Result<T>, Result<T>> func)
        {
            if (result.IsFailure)
            {
                // execute func code, this will return a Result.
                return func(result);
            }

            return result;
        }      

        /// <summary>
        /// Runs the specified func regardless of the fact that executed operation was a Faliure or Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Result OnFaliure<T>(this Result result, Func<Result, Result<T>> func)
        {
            if (result.IsFailure)
            {
                // execute func code, this will return a Result.
                return func(result);
            }
            // execute func and return
            return result;
        }        

        /// <summary>
        /// Runs the specified action regardless of the fact that executed operation was a Faliure or Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Result OnSuccessOrFaliure(this Result result, Action action)
        {
             // execute action
             action();   

            return result;
        }

        /// <summary>
        /// Runs the specified func regardless of the fact that executed operation was a Faliure or Success.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T OnSuccessOrFaliure<T>(this Result result, Func<Result, T> func)
        {
            // execute func and return
            return func(result);           
        }

        public static TOut OnSuccessOrFaliure<T, TOut>(this Result<T> result, Func<Result<T>, TOut> func)
        {
            // execute func and return
            return func(result);
        }

        /// <summary>
        /// Success Func -> (Takes result in Func) Runs the specified func code if (previously) executed operation is a Success.
        /// Faliure Func -> (Takes result in Func) Runs the specified func code if (previously) executed operation is a Faliure.
        /// </summary>
        /// <param name="result">The Result of the prevviously executed operation.</param>
        /// <param name="func_OnSuccess">Runs the specified func code if (previously) executed operation is a Success.</param>
        /// <param name="func_OnFaliure">Runs the specified func code if (previously) executed operation is a Faliure.</param>
        /// <returns></returns>
        public static TResult ConcludeResult<TResult>(this Result result, 
            Func<Result, TResult> func_OnSuccess, 
            Func<Result, TResult> func_OnFaliure)
        {
            if (result.IsFailure)
            {
                // return previous result
                return func_OnFaliure(result);
            }

            // execute func code, this will return a Result.
            return func_OnSuccess(result);
        }

        public static TResult ConcludeResult<TInput, TResult>(this Result<TInput> result,
            Func<Result<TInput>, TResult> func_OnSuccess,
            Func<Result<TInput>, TResult> func_OnFaliure)
        {
            if (result.IsFailure)
            {
                // return previous result
                return func_OnFaliure(result);
            }

            // execute func code, this will return a Result.
            return func_OnSuccess(result);
        }

        public static async System.Threading.Tasks.Task<TResult> ConcludeResultAsync<TInput, TResult>(this Result<TInput> result,
            Func<Result<TInput>, System.Threading.Tasks.Task<TResult>> func_OnSuccess,
            Func<Result<TInput>, System.Threading.Tasks.Task<TResult>> func_OnFaliure)
        {
            if (result.IsFailure)
            {
                // return previous result
                return await func_OnFaliure(result);
            }

            // execute func code, this will return a Result.
            return await func_OnSuccess(result);
        }
    }
}

namespace PerfGuard.Core
{
    /// <summary>
    /// ValueObject: is here to wage a WAR againt "Primitive Obsession".
    /// 
    /// You should use me to get over your obsession of value types.
    /// 
    /// Think before you use – string email in a method signature.
    /// 
    /// How about making a class called Email?
    /// The said class will house email specific validation, 
    /// Our Application specific validations (ex.Email should have @ in them.) etc.
    /// 
    /// Method signature could be – SomeMethod(Email primaryEmail, Email secondaryEmail)
    /// And the Email class will take care that the passed string adheres to our requirements.
    ///
    /// What a way to avoid CODE DUPLICATION! 
    /// 
    /// Say no more, to primitives, that are unviversal in our application.
    /// Example - string email, string userId.
    /// email and userId in our application have validation rules.
    /// So, let us just define those validations in one place only.
    /// Avoid code duplication and also make sure the validation is in 
    /// place as a standard throughout our application.
    /// 
    /// this adheres to DRY principle which is "Dont Repeat Yourself".
    /// 
    /// ValueObject is the base class for all ValueObject(s). Like email, userId.
    /// 
    /// </summary>
    public abstract class ValueObject<T>
        where T : ValueObject<T>
    {
        #region Public Members, properties etc.

        public override bool Equals(object obj)
        {
            var valueObject = obj as T;

            if (ReferenceEquals(valueObject, null)) return false;

            return EqualsCore(valueObject);
        }

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        #endregion

        #region Best part - Operator Overloading! - Public Static Methods.

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            return !(a == b);
        }

        #endregion


        #region Protected Members, properties etc.

        protected abstract bool EqualsCore(T other);
        protected abstract int GetHashCodeCore();

        #endregion  
    }
}


namespace PerfGuard.Cryptography
{

	using PerfGuard.Constants;
	using System;
	using System.IO;
	using System.Security.Cryptography;
	using System.Text;
	
    /// <summary>
    /// Asymmetric encryption is more Mathematical whereas Symmetric encryption is more Algorithmic. 
    /// 
    /// Important** Make sure the Keys are also saved in DB - for Backup and Audit Purposes.     
    /// </summary>
    public class RSA : IDisposable
    {
        #region Variable(s).

        private const string ContainerName = "MyContainerSEMIS";
        private const string ProviderName = "Microsoft Strong Cryptographic Provider";
        private const int KindOfProviderToCreate = 1;

        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        private string _publicKeyXmlStr;
        private string _privateKeyXmlStr;

        #endregion

        #region Keys Managed in DB.

        #region Assign Keys - Keys managed in DB. 

        public void Assign_2048_Bits_NewKey_SaveKeysAsXmlStrInDb()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKeyXmlStr = rsa.ToXmlString(Misc.FALSE);
                _privateKeyXmlStr = rsa.ToXmlString(Misc.TRUE);
            }
        }

        public void Assign_4096_Bits_NewKey_SaveKeysAsXmlStrInDb()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKeyXmlStr = rsa.ToXmlString(Misc.FALSE);
                _privateKeyXmlStr = rsa.ToXmlString(Misc.TRUE);
            }
        }

        #endregion

        #region Fetch/Set Keys.

        public string Fetch_PrivateKeyInXmlString()
        {
            return _privateKeyXmlStr;
        }

        public string Fetch_PublicKeyInXmlString()
        {
            return _publicKeyXmlStr;
        }

        public void Set_PrivateKeyInXmlString(string _priKey)
        {
            _privateKeyXmlStr = _priKey;
        }

        public void Set_PublicKeyInXmlString(string _pubKey)
        {
            _publicKeyXmlStr = _pubKey;
        }

        #endregion

        #region Encrypt data using RSA - Keys managed in DB.

        public byte[] SavedKeysInDb_EncryptData_Using_2048_Bit_Keys(string dataToEncrypt)
        {
            return SavedKeysInDb_EncryptData_Using_2048_Bit_Keys(FetchByteArray(dataToEncrypt));
        }

        public byte[] SavedKeysInDb_EncryptData_Using_4096_Bit_Keys(string dataToEncrypt)
        {            
            return SavedKeysInDb_EncryptData_Using_4096_Bit_Keys(FetchByteArray(dataToEncrypt));
        }

        public byte[] SavedKeysInDb_EncryptData_Using_2048_Bit_Keys(byte[] dataToEncrypt)
        {
            byte[] _cipherBytes;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(_publicKeyXmlStr);

                _cipherBytes = rsa.Encrypt(dataToEncrypt, Misc.FALSE);
            }
            return _cipherBytes;
        }

        public byte[] SavedKeysInDb_EncryptData_Using_4096_Bit_Keys(byte[] dataToEncrypt)
        {
            byte[] _cipherBytes;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(_publicKeyXmlStr);

                _cipherBytes = rsa.Encrypt(dataToEncrypt, Misc.FALSE);
            }
            return _cipherBytes;
        }

        #endregion

        #region Decrypt data using RSA - Keys managed in Db.

        public byte[] SavedKeysInDb_DecryptData_Using_2048_Bit_Keys(byte[] dataToDecrypt)
        {
            byte[] _plain;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(_privateKeyXmlStr);

                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        public byte[] SavedKeysInDb_DecryptData_Using_4096_Bit_Keys(byte[] dataToDecrypt)
        {
            byte[] _plain;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(_privateKeyXmlStr);

                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        #endregion        

        #endregion

        #region Keys Managed Locally! In Local Variables. 

        #region Assign Keys - Keys managed in Local Variables. 

        public void Assign_2048_Bits_NewKey_SaveKeysInLocalVariables()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(Misc.FALSE);
                _privateKey = rsa.ExportParameters(Misc.TRUE);
            }
        }

        public void Assign_4096_Bits_NewKey_SaveKeysInLocalVariables()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(Misc.FALSE);
                _privateKey = rsa.ExportParameters(Misc.TRUE);
            }
        }

        #endregion

        #region Encrypt data using RSA - Keys managed in Local Variables. 

        public byte[] SavedKeysInLocalVariables_EncryptData_Using_2048_Bit_Keys(string dataToEncrypt)
        {
            return this.SavedKeysInLocalVariables_EncryptData_Using_2048_Bit_Keys(FetchByteArray(dataToEncrypt));
        }

        public byte[] SavedKeysInLocalVariables_EncryptData_Using_2048_Bit_Keys(byte[] dataToEncrypt)
        {
            byte[] _cipherBytes;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_publicKey);

                _cipherBytes = rsa.Encrypt(dataToEncrypt, Misc.FALSE);
            }
            return _cipherBytes;
        }

        public byte[] SavedKeysInLocalVariables_EncryptData_Using_4096_Bit_Keys(string dataToEncrypt)
        {
            byte[] _cipherBytes;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_publicKey);

                _cipherBytes = rsa.Encrypt(FetchByteArray(dataToEncrypt), Misc.FALSE);
            }
            return _cipherBytes;
        }

        #endregion

        #region Decrypt data using RSA - Keys managed in Local Variables. 

        public byte[] SavedKeysInLocalVariables_DecryptData_Using_2048_Bit_Keys(byte[] dataToDecrypt)
        {
            byte[] _plain;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);

                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        public byte[] SavedKeysInLocalVariables_DecryptData_Using_4096_Bit_Keys(byte[] dataToDecrypt)
        {
            byte[] _plain;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);

                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        #endregion

        #endregion        

        #region Keys Managed in XML Files! [Unlikely to be Used.]

        #region Assign Keys - Keys managed in XML Files. [Unlikely to be Used.]

        public void Assign_2048_Bits_NewKey_SaveKeysInXmlFile(string _publicKeyPath, string _privateKeyPath)
        {
            ManageXmlFiles(_publicKeyPath, _privateKeyPath);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                File.WriteAllText(_publicKeyPath, rsa.ToXmlString(Misc.FALSE));
                File.WriteAllText(_privateKeyPath, rsa.ToXmlString(Misc.TRUE));
            }
        }

        public void Assign_4096_Bits_NewKey_SaveKeysInXmlFile(string _publicKeyPath, string _privateKeyPath)
        {
            ManageXmlFiles(_publicKeyPath, _privateKeyPath);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                File.WriteAllText(_publicKeyPath, rsa.ToXmlString(Misc.FALSE));
                File.WriteAllText(_privateKeyPath, rsa.ToXmlString(Misc.TRUE));
            }
        }

        #endregion

        #region Encrypt data using RSA - Keys managed in XML Files. [Unlikely to be Used.]

        public byte[] SavedKeysInXmlFile_EncryptData_Using_2048_Bit_Keys(string _publicKeyPath, string dataToEncrypt)
        {
            byte[] _cipherBytes;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(File.ReadAllText(_publicKeyPath));

                _cipherBytes = rsa.Encrypt(FetchByteArray(dataToEncrypt), Misc.FALSE);
            }
            return _cipherBytes;
        }

        public byte[] SavedKeysInXMLFIle_EncryptData_Using_4096_Bit_Keys(string _publicKeyPath, string dataToEncrypt)
        {
            byte[] _cipherBytes;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {                
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(File.ReadAllText(_publicKeyPath));

                _cipherBytes = rsa.Encrypt(FetchByteArray(dataToEncrypt), Misc.FALSE);
            }
            return _cipherBytes;
        }

        #endregion

        #region Decrypt data using RSA - Keys managed in XML Files. [Unlikely to be Used.]

        public byte[] SavedKeysInXmlFile_DecryptData_Using_2048_Bit_Keys(string _privateKeyPath, byte[] dataToDecrypt)
        {
            byte[] _plain;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(File.ReadAllText(_privateKeyPath));

                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        public byte[] SavedKeysInXmlFile_DecryptData_Using_4096_Bit_Keys(string _privateKeyPath, byte[] dataToDecrypt)
        {
            byte[] _plain;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(File.ReadAllText(_privateKeyPath));

                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        #endregion

        #endregion
        
        #region Keys Managed in CSP!

        #region Assign/Delete Keys - Keys managed in CSP

        public void Assign_NewKeys_SaveKeysInCsp()
        {
            CspParameters cspParams = new CspParameters(KindOfProviderToCreate);
            cspParams.KeyContainerName = ContainerName;
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParams.ProviderName = ProviderName;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParams)
            {
                PersistKeyInCsp = false
            };
        }

        public void Delete_KeysInCsp()
        {
            CspParameters cspParams = new CspParameters()
            {
                KeyContainerName = ContainerName
            };          

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspParams)
            {
                PersistKeyInCsp = false
            };

            rsa.Clear();
        }

        #endregion

        #region Encrypt data using RSA - Keys managed in CSP

        public byte[] EncryptData_Using2048_BitKey_SavedKeysInCsp(string dataToEncrypt)
        {
            byte[] _cipherBytes;
            CspParameters cspParams = new CspParameters()
            {
                KeyContainerName = ContainerName
            };

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY, cspParams))
            {
                _cipherBytes = rsa.Encrypt(FetchByteArray(dataToEncrypt), Misc.FALSE);
            }
            return _cipherBytes;
        }

        public byte[] EncryptData_Using4096_BitKey_SavedKeysInCsp(string dataToEncrypt)
        {
            byte[] _cipherBytes;
            CspParameters cspParams = new CspParameters()
            {
                KeyContainerName = ContainerName
            };

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY, cspParams))
            {
                _cipherBytes = rsa.Encrypt(FetchByteArray(dataToEncrypt), Misc.FALSE);
            }
            return _cipherBytes;
        }

        #endregion

        #region Decrypt data using RSA - Keys managed in CSP

        public byte[] DecryptData_Using2048_BitKey_SavedKeysInCsp(byte[] dataToDecrypt)
        {
            byte[] _plain;
            CspParameters cspParams = new CspParameters()
            {
                KeyContainerName = ContainerName
            };
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY, cspParams))
            {
                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        public byte[] DecryptData_Using4096_BitKey_SavedKeysInCsp(byte[] dataToDecrypt)
        {
            byte[] _plain;
            CspParameters cspParams = new CspParameters()
            {
                KeyContainerName = ContainerName
            };
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY, cspParams))
            {
                _plain = rsa.Decrypt(dataToDecrypt, Misc.FALSE);
            }
            return _plain;
        }

        #endregion

        #endregion

        #region Private Method(s).      

        private void ManageXmlFiles(string _pathOne, string _pathTwo)
        {
            if(File.Exists(_pathOne))
            {
                File.Delete(_pathOne);
            }

            if (File.Exists(_pathTwo))
            {
                File.Delete(_pathTwo);
            }

            var pathOneFolder = Path.GetDirectoryName(_pathOne);
            var pathTwoFolder = Path.GetDirectoryName(_pathTwo);

            if(!Directory.Exists(pathOneFolder))
            {
                Directory.CreateDirectory(pathOneFolder);
            }

            if (!Directory.Exists(pathTwoFolder))
            {
                Directory.CreateDirectory(pathTwoFolder);
            }
        }

        private byte[] FetchByteArray(string _data)
        {
            return Encoding.UTF8.GetBytes(_data);
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




namespace PerfGuard.Cryptography
{
	using PerfGuard.Constants;
	using System;
	using System.Security.Cryptography;
	
    public class DigitalSignature : IDisposable
    {
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        private string _publicKeyXmlStr;
        private string _privateKeyXmlStr;

        #region Keys Managed in DB.

        #region Assign Keys - Keys managed in DB. 

        public void Assign_2048_Bits_NewKey_SaveKeysAsXmlStrInDb()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKeyXmlStr = rsa.ToXmlString(Misc.FALSE);
                _privateKeyXmlStr = rsa.ToXmlString(Misc.TRUE);
            }
        }

        public void Assign_4096_Bits_NewKey_SaveKeysAsXmlStrInDb()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKeyXmlStr = rsa.ToXmlString(Misc.FALSE);
                _privateKeyXmlStr = rsa.ToXmlString(Misc.TRUE);
            }
        }

        #endregion

        #region Fetch/Set Keys - Save them in DB.

        public string Fetch_PrivateKeyInXmlString()
        {
            return _privateKeyXmlStr;
        }

        public string Fetch_PublicKeyInXmlString()
        {
            return _publicKeyXmlStr;
        }

        public void Set_PrivateKeyInXmlString(string _priKey)
        {
            _privateKeyXmlStr = _priKey;
        }

        public void Set_PublicKeyInXmlString(string _pubKey)
        {
            _publicKeyXmlStr = _pubKey;
        }

        #endregion

        #endregion

        #region Assign Keys - Keys managed in Local Variables. 

        public void Assign_2048_Bits_NewKey_SaveKeysInLocalVariables()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(Misc.FALSE);
                _privateKey = rsa.ExportParameters(Misc.TRUE);
            }
        }

        public void Assign_4096_Bits_NewKey_SaveKeysInLocalVariables()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_4096_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(Misc.FALSE);
                _privateKey = rsa.ExportParameters(Misc.TRUE);
            }
        }

        #endregion

        #region Sign Data

        /// <summary>
        /// Signs and rerurn the Digital Signature.
        /// </summary>
        /// <param name="hashOfDataToSign"></param>
        /// <returns></returns>
        public byte[] SignData(byte[] hashOfDataToSign, string _privateKeyFromDb = null)
        {          
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                rsa.PersistKeyInCsp = false;

                if (_privateKeyFromDb == null)
                {
                    rsa.ImportParameters(_privateKey);
                }
                else
                {
                    rsa.FromXmlString(_privateKeyFromDb);
                }

                var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm(Misc.SHA_256_HASH_ALGORITHM);

                return rsaFormatter.CreateSignature(hashOfDataToSign);                
            }
        }

        #endregion

        #region Verify Signature

        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature, string _publicKeyFromDb = null)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Misc.RSA_2048_BITS_KEY))
            {
                if (_publicKeyFromDb == null)
                {
                    rsa.ImportParameters(_publicKey);
                }
                else
                {
                    rsa.FromXmlString(_publicKeyFromDb);
                }

                var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm(Misc.SHA_256_HASH_ALGORITHM);

                return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
            }
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


namespace PerfGuard.Cryptography
{

	using System;
	using System.Security.Cryptography;
	using System.Text;

    /// <summary>
    /// "The message to be hashed"  --> Hashing Function i.e., ME [EdHash]  -->  232ds23d2s3d23sd23sd2s3d2s3d2s3d2s3d2s3d2s3d
    /// 
    /// MD 5  --> Do not use anymore. Only for Legacy Application Support.
    /// SHA Family - SHA-1, SHA256 and SHA-512 a.k.a Secure Hash Family.
    /// 
    /// SHA-256: uses 32 bit Words.
    /// SHA-512: uses 64 bit Words.
    /// SHA-3: Non NSA designer, supports SHA-256 hash length.
    /// </summary>
    public class EdHash : IDisposable
    {
        #region Hashing Method(s).

        #region MD5
        /// <summary>
        /// MD5 = Use me only for Legacy Support.        
        /// Produces a 128 bit(16 byte) hash value.
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <returns>the HASH.</returns>
        public byte[] ComputeHashMD5(string _tobeHashed)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion

        #region SHA1
        /// <summary>
        /// SHA1 = Use me only for Legacy Support.         
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <returns>the HASH.</returns>
        public byte[] ComputeHashSha1(string _tobeHashed)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion
        
        #region SHA256
        /// <summary>
        /// SHA256 = I should be your second preference for hashing after SHA512.      
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <returns>the HASH.</returns>
        public byte[] ComputeHashSha256(string _tobeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion

        #region SHA512
        /// <summary>
        /// SHA512 = I should be your TOP Preference for Hashing.       
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <returns>the HASH.</returns>
        public byte[] ComputeHashSha512(string _tobeHashed)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion

        #endregion

        #region Private Method(s).
        private byte[] FetchByteArray(string _message)
        {
            return Encoding.UTF8.GetBytes(_message);
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


namespace PerfGuard.Cryptography
{

	using PerfGuard.Constants;
	using System;
	using System.Security.Cryptography;
	using System.Text;
	
    /// <summary>
    /// HMAC a.k.a EdHmac - Hashed Message Authentication Codes.
    /// When we combine Hashing and a Secret Key to generate a HASH. We get HMAC or in our case - EdHmac.
    /// 
    /// Only Sources who are 'aware of the Key' can compute the same Hashes. 
    /// The 'Key' also adds entropy to the operation thus making the hashes more unique.
    /// </summary>
    public class EdHmac : IDisposable
    {
        #region Generate Key 

        public byte[] Generate32ByteHmacKey()
        {
            return RealRandomNumber.GenerateRandomNumber(Misc.HMAC_KEY_SIZE_32_BYTES);
        }

        #endregion

        #region Hashed Message Authentication Codes Method(s).

        #region HMACMD5
        /// <summary>
        /// HMACMD5 = Use me only for Legacy Support.         
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <param name = "key" > The cryptographic key to use for hashing. 32 bytes or 256 bits in length.</param>
        /// <returns>the HMAC a.k.a Hashed Message Authentication Code.</returns>
        public byte[] ComputeHmacMD5(string _tobeHashed, byte[] key = null)
        {
            using (var md5 = new HMACMD5(CheckKey(key)))
            {
                return md5.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion

        #region HMACSHA1
        /// <summary>
        /// HMACSHA1 = Use me only for Legacy Support.         
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <param name="key">The cryptographic key to use for hashing. 32 bytes or 256 bits in length.</param>
        /// <returns>the HMAC a.k.a Hashed Message Authentication Code.</returns>
        public byte[] ComputeHmacSha1(string _tobeHashed, byte[] key = null)
        {
            using (var sha1 = new HMACSHA1(CheckKey(key)))
            {                
                return sha1.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion        

        #region HMACSHA256

        public byte[] ComputeHmacSha256(string _tobeHashed, byte[] key = null)
        {
            return this.ComputeHmacSha256(FetchByteArray(_tobeHashed), key);
        }

        /// <summary>
        /// HMACSHA256 = I should be your second preference for hashing after SHA512.      
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <param name = "key" > The cryptographic key to use for hashing. 32 bytes or 256 bits in length.</param>
        /// <returns>the HMAC a.k.a Hashed Message Authentication Code.</returns>
        public byte[] ComputeHmacSha256(byte[] _tobeHashed, byte[] key = null)
        {
            using (var sha256 = new HMACSHA256(CheckKey(key)))
            {
                return sha256.ComputeHash(_tobeHashed);
            }
        }
        #endregion

        #region HMACSHA512
        /// <summary>
        /// HMACSHA512 = I should be your TOP Preference for Hashing.       
        /// </summary>
        /// <param name="_tobeHashed">Message/Text - who's Hash we Want.</param>
        /// <param name = "key" > The cryptographic key to use for hashing. 32 bytes or 256 bits in length.</param>
        /// <returns>the HMAC a.k.a Hashed Message Authentication Code.</returns>
        public byte[] ComputeHmacSha512(string _tobeHashed, byte[] key = null)
        {
            using (var sha512 = new HMACSHA512(CheckKey(key)))
            {
                return sha512.ComputeHash(FetchByteArray(_tobeHashed));
            }
        }
        #endregion

        #endregion

        #region Private Method(s).

        private byte[] CheckKey(byte[] _key)
        {
            return _key == null ? Generate32ByteHmacKey() : _key;
        }

        private byte[] FetchByteArray(string _message)
        {
            return Encoding.UTF8.GetBytes(_message);
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



namespace PerfGuard.Cryptography
{
	using System;
	
    public class EncryptedPacket : IDisposable
    {
        public byte[] EncryptedSessionKey { get; set; }
        public byte[] EncryptedData { get; set; }
        public byte[] InitializationVector_IV { get; set; }
        public byte[] Hmac { get; set; }
        public byte[] Signature { get; set; }

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


namespace PerfGuard.Cryptography
{

	using PerfGuard.Constants;
	using PerfGuard.Statics;
	using System;
	using System.Text;

    /// <summary>
    /// HMAC are also incorporated in this Encryption.
    /// </summary>
    public class HybridEncryption : IDisposable
    {
        private readonly AES _aesEncryption = new AES();

        #region Encrypt Data

        public EncryptedPacket EncryptData(string original, RSA rsaParams, DigitalSignature digitalSignature)
        {
            return EncryptData(FetchByteArray(original), rsaParams, digitalSignature);
        }

        public EncryptedPacket EncryptData(byte[] original, RSA rsaParams, DigitalSignature digitalSignature)
        {
            // Generate our Session Key -- Save this DB.
            byte[] sessionKey = _aesEncryption.GenerateRandomNumberForKey(Misc.KEY_OF_32_BYTES_FOR_AES);

            // Create the Encrypted Packet and generate the Initialization Vector IV
            EncryptedPacket encryptedPacket = new EncryptedPacket
            {
                // Save this in DB.
                InitializationVector_IV =
                        _aesEncryption.GenerateRandomNumberForKey(Misc.INITIALIZATION_VECTOR_16_BYTES_FOR_AES)
            };

            // Encrypt our data with AES
            encryptedPacket.EncryptedData = 
                _aesEncryption.Encrypt(original, sessionKey, encryptedPacket.InitializationVector_IV);

            // Encrypt the session key with RSA
            encryptedPacket.EncryptedSessionKey = 
                rsaParams.SavedKeysInDb_EncryptData_Using_2048_Bit_Keys(sessionKey);

            // Create the HMAC
            using (EdHmac hmac = new EdHmac())
            {
                encryptedPacket.Hmac = hmac.ComputeHmacSha256(encryptedPacket.EncryptedData, sessionKey);
            }

            // Sign the Packet
            encryptedPacket.Signature = digitalSignature.SignData(encryptedPacket.Hmac, rsaParams.Fetch_PrivateKeyInXmlString());

            return encryptedPacket;
        }

        #endregion

        #region Decrypt Data

        public byte[] DecryptData(EncryptedPacket encryptedPacket, RSA rsaParams, DigitalSignature digitalSignature)
        {
            // Decrypt AES Key with RSA
            byte[] decryptedSessionKey = 
                rsaParams.SavedKeysInDb_DecryptData_Using_2048_Bit_Keys(encryptedPacket.EncryptedSessionKey);

            // Verify HMAC
            using (EdHmac hmac = new EdHmac())
            {
                byte[] hmacToCheck = hmac.ComputeHmacSha256(encryptedPacket.EncryptedData, decryptedSessionKey);

                if (!new CompareBytes().Use(obj => { return obj.Compare(encryptedPacket.Hmac, hmacToCheck); }))
                {
                    // Match Failed - Raise Alarm, Reject.
                }

                // Verify the Signature
                if(!digitalSignature.VerifySignature(encryptedPacket.Hmac, encryptedPacket.Signature, rsaParams.Fetch_PublicKeyInXmlString()))
                {
                    // Error - Signature did not MATCH. Digital Signature cannot be VERIFIED.
                }
            }

            // Decrypt our data with AES using the decrypted session key
            byte[] decryptedData =
                _aesEncryption.Decrypt(encryptedPacket.EncryptedData,
                    decryptedSessionKey,
                    encryptedPacket.InitializationVector_IV);

            return decryptedData;
        }

        #endregion

        #region Private Method(s).       

        private byte[] FetchByteArray(string _message)
        {
            return Encoding.UTF8.GetBytes(_message);
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



namespace PerfGuard.Cryptography
{

	using PerfGuard.Statics;
	using System;

    public class RSAOrchestrator : IDisposable
    {       

        #region Initialise RSA

        /// <summary>
        /// Initialise RSA Algorithm.
        /// </summary>
        /// <returns></returns>
        public RSA InitialiseRSA_Generate_Keys()
        {
            return new RSA()
                .Use((rsa) =>
                {
                    rsa.Assign_2048_Bits_NewKey_SaveKeysAsXmlStrInDb();
                    return rsa;
                });          
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




namespace PerfGuard.Cryptography
{
	using PerfGuard.Constants;
	using System;
	using System.IO;
	using System.Security.Cryptography;
	using System.Text;

    /// <summary>
    /// AES uses .Net Frameworks AesCryptoServiceProvider 
    /// which in turn uses WINDOWS CRYPTOGRAPHY LIBRARIES. 
    /// 
    /// This is "FIPS 140-2 CERTIFIED".
    /// </summary>
    public class AES : IDisposable
    {
        #region Generate Random Number

        /// <summary>
        /// Save Randomn Number in Db.
        /// </summary>
        /// <returns></returns>
        public byte[] GenerateRandomNumberForKey(int keySizeInBytes)
        {
            return RealRandomNumber.GenerateRandomNumber(keySizeInBytes);
        }

        #endregion

        #region Encrypt Using AES.

        public byte[] Encrypt(string dataToEncrypt, byte[] key, byte[] initVector)
        {
            return this.Encrypt(FetchByteArray(dataToEncrypt),key, initVector);
        }

        public byte[] Encrypt(byte[] dataToEncrypt, byte[] key, byte[] initVector)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC; // Cipher block chaining (CBC)
                aes.Padding = PaddingMode.PKCS7; // Each byte is padded with the number of padded bytes

                aes.Key = CheckValidBytes(key, Misc.KEY_OF_32_BYTES_FOR_AES); // 256 Bits - maximum size of AES Key.
                aes.IV = CheckValidBytes(initVector, Misc.INITIALIZATION_VECTOR_16_BYTES_FOR_AES);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream =
                        new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);                    

                    cryptoStream.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        #endregion

        #region Decrypt Using AES.

        public byte[] Decrypt(byte[] dataToDecrypt, byte[] key, byte[] initVector)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC; // Cipher block chaining (CBC)
                aes.Padding = PaddingMode.PKCS7; // Each byte is padded with the number of padded bytes

                aes.Key = CheckValidBytes(key, Misc.KEY_OF_32_BYTES_FOR_AES); // 256 Bits - maximum size of AES Key.
                aes.IV = CheckValidBytes(initVector, Misc.INITIALIZATION_VECTOR_16_BYTES_FOR_AES);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream =
                        new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        #endregion

        #region Private Method(s).

        private byte[] CheckValidBytes(byte[] _key, int keySizeInBytes)
        {
            // Save the Key in DB.
            return _key == null ? GenerateRandomNumberForKey(keySizeInBytes) : _key;
        }

        private byte[] FetchByteArray(string _message)
        {
            return Encoding.UTF8.GetBytes(_message);
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



namespace PerfGuard.Cryptography
{

	using PerfGuard.Constants;
	using System;
	using System.IO;
	using System.Security.Cryptography;
	using System.Text;

    public class DES : IDisposable
    {
        #region Generate Random Number

        /// <summary>
        /// Save Randomn Number in Db.
        /// </summary>
        /// <returns></returns>
        public byte[] GenerateRandomNumberForKey()
        {
            return RealRandomNumber.GenerateRandomNumber(Misc.KEY_OF_8_BYTES);
        }

        #endregion

        #region Encrypt Using DES.

        public byte[] Encrypt(string dataToEncrypt, byte[] key, byte[] initVector)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC; // Cipher block chaining (CBC)
                des.Padding = PaddingMode.PKCS7; // Each byte is padded with the number of padded bytes

                des.Key = CheckValidBytes(key);
                des.IV = CheckValidBytes(initVector);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = 
                        new CryptoStream(memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write);

                    byte[] _dataToEncrypt = FetchByteArray(dataToEncrypt);

                    cryptoStream.Write(_dataToEncrypt, 0, _dataToEncrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        #endregion

        #region Decrypt Using DES.

        public byte[] Decrypt(byte[] dataToDecrypt, byte[] key, byte[] initVector)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC; // Cipher block chaining (CBC)
                des.Padding = PaddingMode.PKCS7; // Each byte is padded with the number of padded bytes

                des.Key = CheckValidBytes(key);
                des.IV = CheckValidBytes(initVector);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream =
                        new CryptoStream(memoryStream, des.CreateDecryptor(), CryptoStreamMode.Write);                   

                    cryptoStream.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        #endregion

        #region Private Method(s).

        private byte[] CheckValidBytes(byte[] _number)
        {
            return _number == null ? GenerateRandomNumberForKey() : _number;
        }

        private byte[] FetchByteArray(string _message)
        {
            return Encoding.UTF8.GetBytes(_message);
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



namespace PerfGuard.Cryptography
{
	using PerfGuard.Constants;
	using System;
	using System.IO;
	using System.Security.Cryptography;
	using System.Text;

    public class TripleDES : IDisposable
    {
        #region Generate Random Number

        /// <summary>
        /// Save Randomn Number in Db.
        /// </summary>
        /// <returns></returns>
        public byte[] GenerateRandomNumberForKey(int keySizeInBytes)
        {
            return RealRandomNumber.GenerateRandomNumber(keySizeInBytes);
        }

        #endregion

        #region Encrypt Using TripleDES.

        public byte[] Encrypt(string dataToEncrypt, byte[] key, byte[] initVector)
        {
            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC; // Cipher block chaining (CBC)
                des.Padding = PaddingMode.PKCS7; // Each byte is padded with the number of padded bytes

                des.Key = CheckValidBytes(key, Misc.KEY_OF_24_BYTES_FOR_TripleDES); // What this represents? 3 64 Bits Key OR 3 8 Byte Keys (Only 56 Bits will be used for Key - remember.)
                des.IV = CheckValidBytes(initVector, Misc.INITIALIZATION_VECTOR_OF_8_BYTES);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream =
                        new CryptoStream(memoryStream, des.CreateEncryptor(), CryptoStreamMode.Write);

                    byte[] _dataToEncrypt = FetchByteArray(dataToEncrypt);

                    cryptoStream.Write(_dataToEncrypt, 0, _dataToEncrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        #endregion

        #region Decrypt Using TripleDES.

        public byte[] Decrypt(byte[] dataToDecrypt, byte[] key, byte[] initVector)
        {
            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                des.Mode = CipherMode.CBC; // Cipher block chaining (CBC)
                des.Padding = PaddingMode.PKCS7; // Each byte is padded with the number of padded bytes

                des.Key = CheckValidBytes(key, Misc.KEY_OF_24_BYTES_FOR_TripleDES); // What this represents? 3 64 Bits Key OR 3 8 Byte Keys (Only 56 Bits will be used for Key - remember.)
                des.IV = CheckValidBytes(initVector, Misc.INITIALIZATION_VECTOR_OF_8_BYTES);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream =
                        new CryptoStream(memoryStream, des.CreateDecryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        #endregion

        #region Private Method(s).

        private byte[] CheckValidBytes(byte[] _key, int keySizeInBytes)
        {
            // Save the Key in DB.
            return _key == null ? GenerateRandomNumberForKey(keySizeInBytes) : _key;
        }

        private byte[] FetchByteArray(string _message)
        {
            return Encoding.UTF8.GetBytes(_message);
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



namespace PerfGuard.Cryptography
{
	using System;
	
    /// <summary>
    /// When dealing with Cryptographic Process - Use this Byte Comparing Class.
    /// 
    /// This will save us from 'Side Channel Timing Attack'. 
    /// </summary>
    public class CompareBytes : IDisposable
    {
        #region Compare Bytes

        /// <summary>
        /// When dealing with Cryptographic Process - Use this Byte Comparing Method.
        /// This will save us from 'Side Channel Timing Attack'. 
        /// 
        /// This method will execute in the same time 'no matter how equal or not the fed arrays' are.
        /// 
        /// This method will take the same amount of time to process and therefore will NOT LEAK timing related information to an attacker.
        /// 
        /// </summary>
        /// <param name="array1">array one</param>
        /// <param name="array2">array two</param>
        /// <returns>bool</returns>
        public bool Compare(byte[] array1, byte[] array2)
        {
            bool result = (array1.Length == array2.Length);

            for(int i = 0; i < array1.Length && i < array2.Length; ++i)
            {
                result &= array1[i] == array2[i];
            }
            return result;
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


namespace PerfGuard.Cryptography
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using PerfGuard.Statics;
	using System;
	using System.Runtime.InteropServices;
	using System.Security;

    public class EdSecureString : IDisposable
    {
        #region Convert Character Array To Secure String

        /// <summary>
        /// Convert to 'SecureString'.
        /// </summary>
        /// <param name="str">String to be converted to Secure String.</param>
        /// <returns>A SecureString</returns>
        public SecureString ToSecureString(char[] str)
        {
            SecureString secureString = new SecureString();

            // Append each character onto the SecureString
            Array.ForEach(str, secureString.AppendChar);

            return secureString;
        }

        #endregion

        #region Convert Secure String To Character Array

        public Result<Char[]> CharacterData(SecureString secureString)
        {            
            var ptr = IntPtr.Zero;

            return TryCatch.Process(
                () => // The Code to Run in Try
                {
                    // Allocate a BSTR and copy contents of SecureString into it
                    ptr = Marshal.SecureStringToBSTR(secureString);

                    char[]  bytes = new char[secureString.Length];

                    // Copy Data from Unmanaged Memory into Managed Char Array
                    Marshal.Copy(ptr, bytes, 0, secureString.Length);
                                     
                    return Result.Ok(bytes);
                },
                (_exception) => // Handle Exception - Record Exception etc.
                {                    
                    return Result.Fail<Char[]>(Messages.FAILED_TO_MARSHAL_PTR_TO_STRING_USER_DISPLAY_MESSAGE, Messages.FAILED_TO_MARSHAL_SECURESTRING_TO_CHAR_ARRAY);
                },
                () => // The Finally Block.
                {
                    if (ptr != IntPtr.Zero)
                    {
                        // Free Unmanaged Memory
                        Marshal.ZeroFreeBSTR(ptr);
                    }
                });
        }

        #endregion

        #region Convert Secure String to Unsecure String - Use this Sparingly

        /// <summary>
        /// Important** This should be sparingly/seldom Used.
        /// 
        /// Convert a Secure String to Unsecure String.
        /// </summary>
        /// <param name="secureString">The Secure String.</param>
        /// <returns>Unsecured String wrapped in our precious RESULT Object.</returns>
        public Result<string> ConvertToUnsecureString(SecureString secureString)
        {
            IntPtr unmanagedString = IntPtr.Zero;

            return TryCatch.Process(
                () => // The Code to Run in Try
                {
                    // Copy the contents of the SecureString to Unmanaged Memory                    
                    unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);

                    // Allocate a Managed String and COPY the contents of the Unmanaged string data into it
                    return Result.Ok(Marshal.PtrToStringUni(unmanagedString));
                }, 
                (_exception) => // Handle Exception - Record Exception etc.
                {                        
                        return Result.Fail<string>(Messages.FAILED_TO_MARSHAL_PTR_TO_STRING_USER_DISPLAY_MESSAGE, Messages.FAILED_TO_MARSHAL_PTR_TO_STRING);
                }, 
                () => // The Finally Block. 
                {
                    // Free the Unmanaged String Pointer
                    Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
                });            
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



namespace PerfGuard.Cryptography
{
	using System;
	using System.IdentityModel.Tokens.Jwt;
	using System.Security.Claims;

    public class JwtToken : IDisposable
    {
        /// <summary>
        /// New JWT Token is created and returned as  a string.         
        /// Pass in claims you want in token.
        /// 
        /// A Symmetric Key is used to Encrypt the Token.
        /// </summary>
        /// <param name="_claimsIdentity">Claims Required in Token.</param>
        /// <param name="_expires">Token Expiry Time.</param>
        /// <param name="_securityKey">The Security Key to be used for Digitally Signing this Joy of JWT.</param>
        /// <param name="_issuer">The Issuer.</param>
        /// <param name="_audience">The audience(s).</param>
        /// <returns>The Jwt Token as a String.</returns>
        public string Create(ClaimsIdentity _claimsIdentity, DateTime _expires, 
            byte[] _securityKey, string _issuer, string _audience)
        {
            //Set issued at date
            DateTime issuedAt = DateTime.UtcNow;

            //set the time when it expires
            DateTime expires = _expires; // DateTime.UtcNow.AddDays(7);

            // http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
            var tokenHandler = new JwtSecurityTokenHandler();             

            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(_securityKey);

            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);

            //create the jwt -- http://localhost:50191
            var token = (JwtSecurityToken)
                    tokenHandler.CreateJwtSecurityToken(issuer: _issuer, 
                        audience: _audience, 
                        subject: _claimsIdentity,
                        notBefore: issuedAt,
                        expires: expires,
                        signingCredentials: signingCredentials);

            var tokenString = tokenHandler.WriteToken(token);         

            return tokenString;
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



namespace PerfGuard.Cryptography
{
	using PerfGuard.Constants;
	using System;
	using System.Security.Cryptography;
	using System.Text;
	
    /// <summary>
    /// Password Based Key Derivation Functions (PBKDF2)
    /// 
    /// - RSA Public Key Cryptographic Standards(PKCS #5 Version 2.0)
    /// - Internet Engineering Task Force RFC 2898 Specification
    /// : Good default is 50,000 iterations
    /// : Ideally double number of iterations every 2 years
    /// 
    /// </summary>
    public class PBKDF2 : IDisposable
    {
        #region Public Method(s).

        #region Generate Salt

        /// <summary>
        /// Save SALT in Db.
        /// </summary>
        /// <returns></returns>
        public byte[] GenerateSalt()
        {            
            return RealRandomNumber.GenerateRandomNumber(Misc.HMAC_KEY_SIZE_32_BYTES);
        }

        #endregion

        public byte[] HashPassword(string password, string salt = null, int iterationRounds = 0)
        {
            return this.HashContent(password, salt, iterationRounds);       
        }

        /// <summary>
        /// Hash content securely. 
        /// Include as much entrpy as possible, well as much as possible without hampering performance.
        /// </summary>
        /// <param name="theContentToHash">Content to be Hashed.</param>
        /// <param name="salt">salty salty salt. Save this in DB</param>
        /// <param name="iterationRounds">The WORK Factor.</param>
        /// <returns></returns>
        public byte[] HashContent(string theContentToHash, string salt = null, int iterationRounds = 0)
        {
            // Save SALT in DB.            
            return HashContent
                (FetchByteArray(theContentToHash),
                    ((salt == null ? GenerateSalt() : FetchByteArray(salt))), 
                    CheckRounds(iterationRounds));            
        }

        /// <summary>
        /// Hash content securely.
        /// Include as much entrpy as possible, well as much as possible without hampering performance.
        /// </summary>
        /// <param name="theContentToHash">Content to be Hashed.</param>
        /// <param name="salt">salty salty salt. Save this in DB.</param>
        /// <param name="iterationRounds">The WORK Factor.</param>
        /// <returns></returns>
        public byte[] HashContent(byte[] theContentToHash, byte[] salt, int iterationRounds = 0)
        {
            // Save SALT in DB.
            using (Rfc2898DeriveBytes rfc2898 =
                new Rfc2898DeriveBytes(theContentToHash, salt, CheckRounds(iterationRounds)))
            {
                return rfc2898.GetBytes(Misc.PSEUDO_RANDOM_BYTES_TO_GENERATE);
            }
        }

        #endregion

        #region Private Method(s).

        private int CheckRounds(int _rounds)
        {
            return _rounds < Misc.PBKDF2_MIN_ROUNDS ? Misc.PBKDF2_ROUNDS : _rounds;
        }

        private byte[] FetchByteArray(string _content)
        {
            return Encoding.UTF8.GetBytes(_content);
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



namespace PerfGuard.Cryptography
{
	using System.Security.Cryptography;
	
    /// <summary>
    /// Use RealRandomNumber to actually generate a real randomly generated random number.
    /// - The random number then can be used for encryption/hashing.
    /// - I am bit slow - but the trade off should be fine as I am much better than SYSTEM.RANDOM 
    /// 
    /// Remember - System.Random is not Truely Random.
    /// </summary>
    public static class RealRandomNumber
    {
        #region GenerateRandomNumber Method.

        /// <summary>
        /// Employs RNGCryptoServiceProvider to generate a really random random number.                  
        /// </summary>
        /// 
        /// <example>
        /// If you want generate a random number to use as a 256 BIT Key for AES Encryption Algorithm.
        /// You will have create a Byte Array that is 32 Bytes in Length. As, 32 * 8 = 256 bits!
        /// </example>
        /// 
        /// <param name="length">Pass the length of Bytes you want etc.</param>
        /// 
        /// <returns>Random byte[]</returns>
        public static byte[] GenerateRandomNumber(int length)
        {
            using (RNGCryptoServiceProvider randonNumberGenerator = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[length];
                randonNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        #endregion
    }
}



namespace PerfGuard.Dynamic
{
	using System;
	
    public class DynamoReflection : IDisposable
    {

        private static void ExampleOfReflection()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.GetType().InvokeMember("AppendLine", 
                System.Reflection.BindingFlags.InvokeMethod,
                null, 
                sb, 
                new object[] {"Append this line!"});

            //Writeline(sb);
        }

        public static void ExampleOfDynamic()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            ((dynamic)sb).AppendLine("Hello from Dynamic");

            //Writeline(sb);


            /* 
             * 
             *   Sample Code!
             *   Working with Excel! - Without reference to Interop Assemblies.
             *   Type excelType = Type.GetTypeFromProgID("Excel.Application", true);
             *   dynamic excel = Activator.CreateInstance(excelType);
             *
             *   excel.Visible = true;
             *
             *   excel.Workbooks.Add();
             *
             *   // Default Sheet
             *   dynamic defaultWorksheet = excel.ActiveSheet;
             *
             *   // Add values to cell
             *   defaultWorksheet.Cells[1, "A"] = "This is the Name Column";
             *   defaultWorksheet.Column[1].AutoFit();
             *
             */
        }


        public static T DynamicAdd<T>(T a, T b)
        {
            dynamic _result = (dynamic)a + b;
            return (T)_result;
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


namespace PerfGuard.HouseKeeping
{
	using System.Collections.Generic;
	
    public static class ConcatStringList
    {
        public static string ConcatMessages<T>(this List<T> theList)
            where T : class
        {
            if (theList != null)
            {
                string messages = string.Empty;
                theList.ForEach(m => messages += m.ToString());

                return (messages == string.Empty)
                    ? PerfGuard.Constants.Messages.NO_MESSAGES_FOUND
                    : messages;
            }
            return PerfGuard.Constants.Messages.NO_MESSAGES_FOUND;
        }        
    }
}


namespace PerfGuard.HouseKeeping
{
	using PerfGuard.ValueObjects;
	
    public static class Grinder
    {
        /// <summary>
        /// This extension method will Trim the provided string from both ends and convert it to lower.
        /// 
        /// This method uses the typical methods of System.Trim() and System.ToLower().
        /// </summary>
        /// <param name="_stringBeforeTranformation"></param>
        /// <returns>string: that is trimmed from both ends and has been converted to lower case</returns>
        public static string TrimBothEndsAndConvertToLower(this string _stringBeforeTranformation)
        {
            return _stringBeforeTranformation.Trim().ToLower();
        }

        public static string TrimBothEndsAndConvertToLower_Return_NewString(this NotNullStringProperty _stringBeforeTranformation)
        {
            string _value = _stringBeforeTranformation;
            return _value.Trim().ToLower();
        }

        public static NotNullStringProperty TrimBothEndsAndConvertToLower_Return_NotNullStringProperty(this NotNullStringProperty _stringBeforeTranformation)
        {
            string _value = _stringBeforeTranformation;
            return NotNullStringProperty.Create(_value.Trim().ToLower()).Value;
        }
    }
}


namespace PerfGuard.Models
{

	using PerfGuard.Constants;
	using PerfGuard.Core;
	using PerfGuard.HouseKeeping;
	using PerfGuard.ValueObjects;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml;

    #region Model of a Object derived from configuration.

    public class DerivedByConfiguration : IDisposable
    {
        private readonly string _keyFromConfiguration = string.Empty;
        private readonly string _valueFromConfiguration = string.Empty;

        private readonly string _mainCatergoryName = string.Empty;
        private readonly IList<NotNullStringProperty> _subCatergoryNames 
            = new List<NotNullStringProperty>();

        private IList<MainCategory> _mainCategorys = new List<MainCategory>();        

        private DerivedByConfiguration(string _key, string _configurationXML)
        {
            this._keyFromConfiguration = _key;
            this._valueFromConfiguration = _configurationXML;
        }

        public static Result<DerivedByConfiguration> Create(NotNullStringProperty _key, 
            NotNullStringProperty _configurationXml)
        {
            #region Build all required Object(s) using provided Configuration.          

            var classObj = new DerivedByConfiguration(_key, _configurationXml);
            Maybe<DerivedByConfiguration> derivedByConfiguration = 
                classObj.DecipherConfiguration(ref classObj);

            #endregion

            return derivedByConfiguration.ToResult
                ((derivedByConfiguration != null)
                ? string.Empty
                : Constants.Messages.FAILED_TO_INITIALISE_FROM_CONFIGURATION + Constants.Messages.SPACE +
                 _configurationXml + Constants.Messages.PERIOD +
                 Constants.Messages.CONFIGURATION_KEY_PROVIDED + 
                 Constants.Messages.SPACE + _key + Constants.Messages.PERIOD);      
        }

        public IList<MainCategory> Get_AllCategories
        {
            get { return _mainCategorys; }
        }

        public Maybe<IList<MainCategory>> SearchForCategoriesWith_MainCategoryValueProvided_InConfiguration
            (NotNullStringProperty categoryNameInConfiguration)
        {
            Maybe<IList<MainCategory>> _foundCategoryOrCategories = null;
            if (_mainCategorys != null)
            {
                _foundCategoryOrCategories = _mainCategorys
                            .Where(x => 
                                x.MainCategoryName_Provided_InConfiguration.TrimBothEndsAndConvertToLower() 
                                    == categoryNameInConfiguration.TrimBothEndsAndConvertToLower_Return_NewString())
                            .ToList();
            }
            return _foundCategoryOrCategories;
        }

        public Maybe<IList<MainCategory>> SearchForCategoriesWith_SubCategoryValueProvided_InConfiguration
            (NotNullStringProperty searchForSubCategoryByThisHeaderName, NotNullStringProperty subCategoryValueThatExists)
        {
            Maybe<IList<MainCategory>> _foundCategoryOrCategories = null;
            if (_mainCategorys != null)
            {
                _mainCategorys.ToList()
                    .ForEach(_main =>
                        {
                            Maybe<SubCategory> _sub = _main.SearchForSubCategoryByHeaderName(searchForSubCategoryByThisHeaderName);
                            if(_sub.HasValue)
                            {
                                if (_sub.Value
                                    .Search_ForMatchingValue_In_ValuesFromConfiguration_ForSubCategory(subCategoryValueThatExists))
                                {
                                    _foundCategoryOrCategories.Value.Add(_main);
                                }
                            }
                        });
            }
            return _foundCategoryOrCategories;
        }

        public Maybe<IList<SubCategory>> SearchConfigurationAndFetchSubCategory(NotNullStringProperty mainCategoryValueInConfiguration,
            NotNullStringProperty subCatergoryHeaderName, NotNullStringProperty subCategoryValueThatExists, 
            IList<NotNullStringProperty> toBeReturnedSubCategoriesHeaderNames)
        {
            List<SubCategory> _subCategories = new List<SubCategory>();
            var categoryOrCategories = SearchForCategoriesWith_MainCategoryValueProvided_InConfiguration(mainCategoryValueInConfiguration);

            if(categoryOrCategories.HasValue)
            {
                categoryOrCategories.Value.ToList()
                    .ForEach(x =>
                        {
                        Maybe<SubCategory> _foundSubCategory =
                            x.SearchForSubCategoryByHeaderName(subCatergoryHeaderName);

                        if (_foundSubCategory.HasValue)
                        {
                            if (_foundSubCategory.Value
                                .Search_ForMatchingValue_In_ValuesFromConfiguration_ForSubCategory(subCategoryValueThatExists))
                            {
                                //_subCategories = x.SearchForSubCategoryByHeaderName(toBeReturnedSubCategoryHeaderName);
                                toBeReturnedSubCategoriesHeaderNames.ToList()
                                .ForEach(e =>
                                {
                                    var fetchedCategory = x.SearchForSubCategoryByHeaderName(e);
                                    if(fetchedCategory.HasValue)
                                    {
                                        _subCategories.Add(fetchedCategory.Value);
                                    }
                                });
                            }
                        }                           
                        });
            }
            return _subCategories;
        }

        public Maybe<IList<SubCategory>> SearchConfigurationBasedOnTwoSubCategoryValues(
            NotNullStringProperty subCatergoryHeaderNameOne, NotNullStringProperty subCategoryValueThatExistsOne,
            NotNullStringProperty subCatergoryHeaderNameTwo, NotNullStringProperty subCategoryValueThatExistsTwo,
            IList<NotNullStringProperty> toBeReturnedSubCategoriesHeaderNames)
        {
            List<SubCategory> _subCategories = new List<SubCategory>();           

            if (_mainCategorys != null)
            {
                _mainCategorys.ToList()
                    .ForEach(_main =>
                    {
                        Maybe<SubCategory> _foundSubCategoryOne =
                            _main.SearchForSubCategoryByHeaderName(subCatergoryHeaderNameOne);

                        Maybe<SubCategory> _foundSubCategoryTwo =
                            _main.SearchForSubCategoryByHeaderName(subCatergoryHeaderNameTwo);

                        if(_foundSubCategoryOne.HasValue && _foundSubCategoryTwo.HasValue)
                        {
                            if (_foundSubCategoryOne.Value.Search_ForMatchingValue_In_ValuesFromConfiguration_ForSubCategory(subCategoryValueThatExistsOne)
                                && _foundSubCategoryTwo.Value.Search_ForMatchingValue_In_ValuesFromConfiguration_ForSubCategory(subCategoryValueThatExistsTwo))
                            {
                                #region Got the Match - Pack and Load DATA.

                                toBeReturnedSubCategoriesHeaderNames.ToList()
                                .ForEach(e =>
                                {
                                    var fetchedCategory = _main.SearchForSubCategoryByHeaderName(e);
                                    if (fetchedCategory.HasValue)
                                    {
                                        _subCategories.Add(fetchedCategory.Value);
                                    }
                                });

                                #endregion
                            }
                        }
                    });
            }
            return _subCategories;
        }

        private IList<MainCategory> Add_MainCategory(MainCategory newCategory)
        {
            if (_mainCategorys.IndexOf(newCategory) == Constants.Misc.List_IndexOf_WhenValueNotFound)
                _mainCategorys.Add(newCategory);

            return _mainCategorys;
        }

        #region Private(s)

        private Maybe<DerivedByConfiguration> DecipherConfiguration(ref DerivedByConfiguration _objRef)
        {
            #region Decipher Configuration         

            XmlDocument _xmlConfigurationDoc = new XmlDocument();
            _xmlConfigurationDoc.LoadXml(_valueFromConfiguration);     

            string rootElementName = _xmlConfigurationDoc.DocumentElement.Name;

            var categoryNodes = _xmlConfigurationDoc.SelectNodes
                (rootElementName + Misc.X_PATH_CATEGORIES_PATH_TAG);

            #region Loop - Through all Categories:
            foreach (XmlNode rootCategoryNode in categoryNodes)
            {
                var master = rootCategoryNode.SelectNodes(Misc.X_PATH_MASTER_CATEGORY_TAG_IN_CATEGORY);
                var subCategories = rootCategoryNode.SelectNodes(Misc.X_PATH_SUB_CATEGORIES_PATH_IN_CATEGORY);

                string masterHeaderName = string.Empty, masterOriginalName = string.Empty,
                    currentSubCategoryHeaderName = string.Empty, currentSubCategoryOriginalName = string.Empty;

                #region Loop - Through MasterRecord: Accessing XmlNode from XmlNodeList              
                foreach (XmlNode _master in master)
                {
                    masterHeaderName = 
                        _master.SelectSingleNode(Misc.X_PATH_MASTER_CATEGORY_HEADER_NAME_PATH_IN_CATEGORY).InnerText;
                    masterOriginalName = 
                        _master.SelectSingleNode(Misc.X_PATH_MASTER_CATEGORY_ORIGINAL_ROW_NAME_TAG_IN_CATEGORY).InnerText;
                }
                #endregion

                #region Create Master Category
                MainCategory _currentMainCategory = new MainCategory(masterHeaderName, masterOriginalName);               
                #endregion

                #region Loop - Through SubCategories:
                foreach (XmlNode _subCategory in subCategories)
                {
                    currentSubCategoryHeaderName = 
                        _subCategory.SelectSingleNode(Misc.X_PATH_SUB_CATEGORY_HEADER_NAME_PATH_IN_CATEGORY).InnerText;

                    var listOfItems = _subCategory.SelectNodes(Misc.X_PATH_SUB_CATEGORY_LISTS_TAG_PATH_IN_CATEGORY);

                    #region Create Sub Category
                    SubCategory _currentSubCategory = new SubCategory(currentSubCategoryHeaderName);                   
                    #endregion

                    #region Loop - Through each Items:
                    foreach (XmlNode _v in listOfItems)
                    {
                        _currentSubCategory.Set_ValuesFromConfiguration_ForSubCategory(_v.InnerText);
                    }
                    #endregion

                    #region Add Sub Category to Main Category
                    _currentMainCategory.Set_SubCategorys_ForMainCategory(_currentSubCategory);
                    #endregion
                }
                #endregion

                #region Add Main category to DerivedByConfiguration List
                _objRef.Add_MainCategory(_currentMainCategory);
                #endregion
            }
            #endregion

            #endregion

            return _objRef;
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

    #endregion

    #region Model of Main category.

    public class MainCategory : IDisposable
    {
        private string _headerName = string.Empty;
        private string _mainCategoryNameValue = string.Empty;               

        private IList<SubCategory> _subCategorys = new List<SubCategory>();

        public IList<SubCategory> Set_SubCategorys_ForMainCategory(SubCategory addThisCategory)
        {
            if (_subCategorys.IndexOf(addThisCategory) == Constants.Misc.List_IndexOf_WhenValueNotFound)
                _subCategorys.Add(addThisCategory);
            
            return _subCategorys;
        }

        public Maybe<SubCategory> SearchForSubCategoryByHeaderName
            (string subCategoryHeaderNameInConfiguration)
        {
            Maybe<SubCategory> _foundSubCategoryOrSubCategories = null;
            if (_subCategorys != null)
            {
                _foundSubCategoryOrSubCategories = _subCategorys
                            .Where(x =>
                                x.SubCategoryName_Header.TrimBothEndsAndConvertToLower()
                                    == subCategoryHeaderNameInConfiguration.TrimBothEndsAndConvertToLower())
                            .FirstOrDefault();
            }
            return _foundSubCategoryOrSubCategories;
        }        

        public IList<SubCategory> Get_SubCategorys_ForMainCategory
        {
            get { return _subCategorys; }
        }

        public string MainCategoryName_Header
        {
            get { return _headerName; }
        }

        public string MainCategoryName_Provided_InConfiguration
        {
            get { return _mainCategoryNameValue; }
        }

        /// <summary>
        /// Initialise a Main Category. 
        /// </summary>
        /// <param name="categoryName"></param>    
        public MainCategory(string categoryName, string categoryValue)
        {
            this._headerName = categoryName;
            this._mainCategoryNameValue = categoryValue;
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

    #endregion

    #region Model of Sub category.

    public class SubCategory : IDisposable
    {
        private string _headerName = string.Empty;    

        private IList<string> _values = new List<string>();

        public IList<string> Set_ValuesFromConfiguration_ForSubCategory(string addThisValue)
        {            
            if (_values.IndexOf(addThisValue) == Constants.Misc.List_IndexOf_WhenValueNotFound)
                _values.Add(addThisValue);
            
            return _values;
        }

        public IList<string> Get_ValuesFromConfiguration_ForSubCategory
        {
            get { return _values; }
        }

        public bool Search_ForMatchingValue_In_ValuesFromConfiguration_ForSubCategory(string searchValue)
        {
            return _values.Any(w => 
                w.TrimBothEndsAndConvertToLower() == searchValue.TrimBothEndsAndConvertToLower());
        }

        public string SubCategoryName_Header
        {
            get { return _headerName; }
        }

        /// <summary>
        /// Initialise a Sub Category.
        /// </summary>
        /// <param name="categoryName"></param>    
        public SubCategory(string categoryName)
        {
            this._headerName = categoryName;      
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

    #endregion
}



namespace PerfGuard.Statics
{
	using System;
	
    public static class EdPredicate
    {
        /// <summary>
        /// MatchCount : Returns the number of elements in a ARRAY that satify 
        /// a given condition. This can be used for quick checks.
        /// 
        /// eg - 10 Customers in ARRAY of Customer(s) of 100 have 
        /// email-addresses provided.
        /// </summary>
        /// 
        /// <typeparam name="T"></typeparam>
        /// 
        /// <param name="arr"></param>
        /// <param name="condition"></param>
        /// <returns>int : Number of Matches found.</returns>
        /// 
        /// <example>
        ///     int numberOfNegativeNumbers = MatchCount(numbers, x => x lt 0);
        ///     
        /// /*LINQ Equivalent */
        ///     int numberOfNegativeNumbers = numbers.Count(x => x lt 0);
        /// </example>
        public static int MatchCount<T>(T[] arr, Predicate<T> condition)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (condition(arr[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}


namespace PerfGuard.Statics
{
	using System;
	
    public static class EdUsing
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

        /// <summary>
        /// Use me instead of Using block.      
        /// 
        /// Example usage - var result = obj.Use(  x=> x.DoAction(); x.DoAllYouWantOfMe(); x.SummonSwitchBlockssss(); );
        /// 
        /// </summary>
        /// <typeparam name="T">T must implement <see cref="IDisposable"/></typeparam>
        /// <param name="obj">The object that implements <see cref="IDisposable"/></param>
        /// <param name="action">A Lambda function describing the methods (etc…) you want to run in using block.</param>
        /// 
        /// <example>
        ///     var result = obj.Use(x => x.DoAction(); ); where obj implements <see cref="IDisposable"/>
        /// </example>
        public static TResult Use<T,TResult>(this T obj, Func<T, TResult> func) where T : IDisposable
        {
            using (obj)
            {
                return func(obj);
            }
        }
    }
}



namespace PerfGuard.Statics
{
	using System;
	using System.Collections.Generic;

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


	
namespace PerfGuard.Statics
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using PerfGuard.ValueObjects;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	
    public static class TryCatch 
    {
        public static void Process(Action _code, Action<Exception> _codeWhenExceptionThrown)
        {
            try
            {
                _code();
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                _codeWhenExceptionThrown(_e);
            }
        }

        public static void Process(Action _code, Action<Exception> _codeWhenExceptionThrown, Action _finally)
        {
            try
            {
                _code();
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                _codeWhenExceptionThrown(_e);
            }
            finally
            {
                _finally();
            }
        }

        public static Result<TReturn> Process<TReturn>(Func<Result<TReturn>> _code, // The Code to Execute
            Func<Exception, Result<TReturn>> _codeWhenExceptionThrown, // Code to handle Exception and return a Fail Value
            Action _finally) // The finally close off block of code
        {
            try
            {
                return _code();
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                return _codeWhenExceptionThrown(_e);
            }
            finally
            {
                _finally();
            }
        }

        /// <summary>
        /// Process Task and Handle any Exceptions that the Task Throws.
        /// Records the Exception.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="_code">Task Code to Run. Well, touching the Task .Result or Wait() properties/methods.</param>
        /// <param name="_codeWhenExceptionThrown">Code to run when Exception is thrown.</param>
        /// <param name="_finally">The Finally block.</param>
        /// <returns></returns>
        public static Result<TResult> ProcessTask<TResult>
            (Func<Result<TResult>> _code, // The Code to Execute
            Func<Exception, IList<string>, Result<TResult>> _codeWhenExceptionThrown, // Code to handle Exception and return a Fail Value
            Action _finally) // The finally close off block of code
        {            
            try
            {
                return _code();            
            }
            catch(AggregateException _ae)
            {
                // record and send back a loving note.                
                return _codeWhenExceptionThrown(_ae, Handle_AggregateException(_ae));
            }
            catch (Exception _e)
            {
                // record and send back a loving note.                
                return _codeWhenExceptionThrown(_e, Handle_Exception(_e));               
            }
            finally
            {
                _finally();
            }            
        }

        public static void ProcessTask(Action _code, // The Code to Execute
            Action<Exception, IList<string>> _codeWhenExceptionThrown, // Code to handle Exception and return a Fail Value
            Action _finally) // The finally close off block of code
        {
            try
            {
                _code();
            }
            catch (AggregateException _ae)
            {
                // record and send back a loving note.                
                _codeWhenExceptionThrown(_ae, Handle_AggregateException(_ae));
            }
            catch (Exception _e)
            {
                // record and send back a loving note.                
                _codeWhenExceptionThrown(_e, Handle_Exception(_e));
            }
            finally
            {
                _finally();
            }
        }

        public static void Process<TExceptionResult>(Action _code, Func<Exception, TExceptionResult> _codeWhenExceptionThrown)
        {
            try
            {
                _code();
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                _codeWhenExceptionThrown(_e);
            }
        }

        public static TReturn Process<TReturn>(Func<TReturn> _code, Func<Exception, TReturn> _codeWhenExceptionThrown)
        {
            try
            {
                return _code();
            }            
            catch (Exception _e)
            {
                // record and send back a loving note.  
                return _codeWhenExceptionThrown(_e);
            }
        }

        /// <summary>
        /// Require AWAIT. to bring back the State Machine here after anything falls over etc.
        /// Await here is required for THREAD SYNCHRONIZATION. Do not remove this at any cost.
        /// </summary>
        /// <typeparam name="TReturn"></typeparam>
        /// <param name="_code">The code to excute - an ASYNC Lambda etc...</param>
        /// <param name="_codeWhenExceptionThrown">The fallback code to execute if any exception is thrown in above provided code.</param>
        /// <returns></returns>
        public static async Task<TReturn> ProcessAsync<TReturn>(Func<Task<TReturn>> _code, Func<Exception, Task<TReturn>> _codeWhenExceptionThrown)
        {
            try
            {
                return await _code();
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                return await _codeWhenExceptionThrown(_e);
            }
        }      

        /// <summary>
        /// RunCodeInTryCatch : Execute code in try/catch block.
        /// </summary>
        /// <typeparam name="T">The type of object whose methods are to be invoked in try/ctahc block</typeparam>
        /// <typeparam name="TResult">The return result object</typeparam>
        /// <param name="_obj">The object whose methods are to be invoked in try/ctahc block</param>
        /// <param name="_func">the code to be excuted on the object/with the object etc</param>
        /// <param name="_genericExceptionMessage">The message to be returned incase an exception is encountered</param>
        /// <returns></returns>
        public static Result<TResult> RunCodeInTryCatch<T, TResult>
            (this T _obj, Func<T, Result<TResult>> _func,
            NotNullStringProperty _genericExceptionMessage)
        {
            try
            {
                return _func(_obj);
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                return Result.Fail<TResult>(_genericExceptionMessage);
            }
        }


        /// <summary>
        /// Use this to avoid literring code with 'try/catch blocks'.
        /// </summary>
        /// <typeparam name="TInput1">Input 1</typeparam>
        /// <typeparam name="TInput2">Input 2</typeparam>
        /// <typeparam name="TResult">The Result</typeparam>
        /// <param name="_arg1">Argument 1 of type 'Input 1'</param>
        /// <param name="_arg2">Argument 2 of type 'Input 2'</param>
        /// <param name="_func">The code to Execute</param>
        /// <param name="_genericExceptionMessage">
        ///     The message to return when exception occurs while excuting provided code
        /// </param>
        /// <returns>
        ///     Result of TResult: wha you asked for, Result.Fail<TResult> when exception occurs
        /// </returns>
        public static Result<TResult> Run<TInput1, TInput2, TResult>
            (TInput1 _arg1, TInput2 _arg2, 
            Func<TInput1, TInput2, Result<TResult>> _func,            
            NotNullStringProperty _genericExceptionMessage)
        {
            try
            {
                return _func(_arg1, _arg2);
            }
            catch (Exception _e)
            {
                // record and send back a loving note.  
                return Result.Fail<TResult>(_genericExceptionMessage);
            }            
        }

        public static Result<TResult> Run<TInput1, TInput2, TResult>
            (TInput1 _arg1, TInput2 _arg2, Func<TInput1, TInput2, Result<TResult>> _func,
            IList<string> _exceptionNames, IList<NotNullStringProperty> _genericExceptionMessages,
            NotNullStringProperty _genericExceptionMessage)
        {
            string _returnMessage = _genericExceptionMessage;
            try
            {
                return _func(_arg1, _arg2);
            }
            catch(Exception _e)
            {
                int count = 0;
                bool _notFound = true;
                _exceptionNames.ToList().ForEach(e =>
                {                    
                    if(_notFound && _e.GetType().FullName == e)
                    {
                        // record and send back a loving note.
                        _returnMessage =_genericExceptionMessages[count];
                        _notFound = false;                        
                    }              
                    count++;                   
                });
                return Result.Fail<TResult>(_returnMessage);
            }            
        }

        //public string[] ExecuteTaskInTryBlock(Action codeToRun)
        //{
        //    string[] _exceptions = new string[] { };
        //    try
        //    {
        //        codeToRun();
        //    }
        //    catch (AggregateException aggregateException)
        //    {
        //        // Record Exception using Diagnostics
        //        _exceptions = Handle_AggregateException(aggregateException).ToArray();     
        //    }
        //    catch (Exception exception)
        //    {
        //        // Record Exception using Diagnostics
        //        _exceptions = Handle_Exception(exception).ToArray();             
        //    }
        //    return _exceptions;
        //}

        #region Tasks Exception Handling - AggregateException and Exception(Ss)

        /*
         * How to observe? Task Exceptions -
         * 1. call .wait or touch .Result - exception re-thrown at this point
         * 2. call Task.WaitAll - exceptions re-thrown when all have finished
         * 3. touch task's ,Exception property *after* task has completed
         * 4. subscribe to TaskScheduler.UnobservedTaskException     
         * 
         * If you do not do any of the above - the GC will throw the exception for you.
         * So, you better handle it while it lasts.
         */

        private static IList<string> Handle_AggregateException(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {
                // string taskWasCancelled = string.Empty;
                //if (ex.InnerException is OperationCanceledException)
                //    taskWasCancelled = Messages.TASK_WAS_CANCELLED;

                errors.Add(ex.Message != null
                    ? ex.Message : Messages.NO_EXCEPTIONS_FOUND);
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add(Messages.NO_EXCEPTIONS_FOUND);

            return errors;
        }

        private static IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException.Message
                : Messages.INNER_EXCEPTION_IS_NULL);

            return errors;
        }

        #endregion  

        #region IDisposable Support

        //private bool disposedValue = false;
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        disposedValue = true;
        //    }
        //}

        //// This code added to correctly implement the disposable pattern.
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        #endregion
    }
}



namespace PerfGuard.Statics
{
	using System;
	
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






namespace PerfGuard.TPL
{
	using PerfGuard.Core;
	using PerfGuard.Statics;
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using System.Threading; 

    public class EdWaitAllTasks : IDisposable
    {
        #region [Section:1] Pattern: Wait for all Tasks to complete - One by One.

        public async Task<Tuple<List<Task>, List<Task>>> WaitForAllTasksToComplete_Async(List<Task> tasks)
        {
            List<Task> _successfullyCompletedTasks = new List<Task>();
            List<Task> _failedTasks = new List<Task>();

            if (tasks != null && tasks.Count > 0)
            {
                while (tasks.Count > 0)
                {
                    var completedTask = await Task.WhenAny(tasks); // No Exception thrown here @WhenAny()                  

                    new ExecuteMyCode().Use(executeCodeObj =>
                    {
                        string[] _exceptions =
                        executeCodeObj.ProcessInTryCatch(() =>
                        {
                            completedTask.Wait();
                            _successfullyCompletedTasks.Add(completedTask);
                        },
                        (_aggregateException) =>
                        {
                            // Aggregate Exception has been thrown.
                            _failedTasks.Add(completedTask);
                        },
                        (_exception) =>
                        {
                            // Exception has been thrown.
                            _failedTasks.Add(completedTask);
                        });
                    });

                    tasks.Remove(completedTask);
                }
            }
            return Tuple.Create(_successfullyCompletedTasks, _failedTasks);
        }

        #endregion

        #region Private Method(s).

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



namespace PerfGuard.TPL.Waiting
{
	using System;
	
    public class EdWaitAnyTasks : IDisposable
    {
        #region Public Method(s).

        #endregion

        #region Private Method(s).

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


 

namespace PerfGuard.TPL
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

    public class LinkTasks : IDisposable
    {
        // Task Composition: Continue With, Continue When All, Continue When Any

        


                

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


namespace PerfGuard.TPL
{
	using PerfGuard.Core;
	using PerfGuard.Statics;
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;

    public class CreateTaskShell : IDisposable
    {
        private readonly int _numberOfCores;

        #region Constructor(s)
        public CreateTaskShell()
        {
            _numberOfCores = System.Environment.ProcessorCount;
        }
        #endregion

        /// <summary>
        /// Maximum 3 to 5 seconds of Processing.
        /// Create a Task - You can Await the creation.
        /// </summary>
        /// <typeparam name="TInput1">First Type</typeparam>
        /// <typeparam name="TInput2">Second Type</typeparam>
        /// <typeparam name="TInput3">Third Type</typeparam>
        /// <typeparam name="TInput4">Fourth Type</typeparam>
        /// <typeparam name="TInput5">Fifth Type</typeparam>
        /// <typeparam name="TResult">The result of the Task Operation</typeparam>
        /// <param name="argument1">Argument 1 of TInput1</param>
        /// <param name="argument2">Argument 2 of TInput2</param>
        /// <param name="argument3">Argument 3 of TInput3</param>
        /// <param name="argument4">Argument 4 of TInput4</param>
        /// <param name="argument5">Argument 5 of TInput5</param>
        /// <param name="function">The CODE to RUN.</param>
        /// <param name="cancellationTokenSource">Token signalling the Task was Cancelled.</param>
        /// <param name="taskCreationOptions">Any Creation Options - Long Running etc.</param>
        /// <returns></returns>
        public Task<Result<TResult>> CreateTask<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(TInput1 argument1,
            TInput2 argument2, TInput3 argument3, TInput4 argument4, TInput5 argument5,
            Func<TInput1, TInput2, TInput3, TInput4, TInput5, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>(() => //arg1, arg2, arg3, arg4, arg5
            {
                return function(argument1, argument2, argument3, argument4, argument5, cancellationToken);
            },
                cancellationToken,
                taskCreationOptions,
                TaskScheduler.Default
            );
        }

        /// <summary>
        /// Maximum 3 to 5 seconds of Processing.
        /// Create a Task - You can Await the creation.
        /// </summary>
        /// <typeparam name="TInput1">First Type</typeparam>
        /// <typeparam name="TInput2">Second Type</typeparam>
        /// <typeparam name="TInput3">Third Type</typeparam>
        /// <typeparam name="TInput4">Fourth Type</typeparam>
        /// <typeparam name="TInput5">Fifth Type</typeparam>
        /// <typeparam name="TResult">The result of the Task Operation</typeparam>
        /// <param name="argument1">Argument 1 of TInput1</param>
        /// <param name="argument2">Argument 2 of TInput2</param>
        /// <param name="argument3">Argument 3 of TInput3</param>
        /// <param name="argument4">Argument 4 of TInput4</param>
        /// <param name="argument5">Argument 5 of TInput5</param>
        /// <param name="function">
        /// The CODE to RUN.
        /// This Func should Monitor cancellationToken and if Cancellation is requested it 
        /// should throw cancellationToken.ThrowIfCancellationRequested() Exception.
        /// </param>
        /// <param name="cancellationTokenSource">
        /// Token signalling the Task was Cancelled. 
        /// This Func should Monitor cancellationToken and if Cancellation is requested it 
        /// should throw cancellationToken.ThrowIfCancellationRequested() Exception.
        /// </param>
        /// <param name="taskCreationOptions">Any Creation Options - Long Running etc.</param>
        /// <returns></returns>
        public async Task<Result<TResult>> CreateTaskAsync<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(TInput1 argument1,
            TInput2 argument2, TInput3 argument3, TInput4 argument4, TInput5 argument5,
            Func<TInput1, TInput2, TInput3, TInput4, TInput5, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return await Task.Factory.StartNew<Result<TResult>>(() => //arg1, arg2, arg3, arg4, arg5
            {                
                return function(argument1, argument2, argument3, argument4, argument5, cancellationToken); 
            },               
                cancellationToken,
                taskCreationOptions,
                TaskScheduler.Default
            );
        }


        public Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>((arg1) =>
            {
                return function((TInput)arg1, cancellationToken);
            },
                arg, // Not using Closure - using Task Parameter.
                cancellationToken,
                taskCreationOptions,
                TaskScheduler.Default
            );
        }



        #region Long Running Tasks

        /// <summary>
        /// Use this Bad - Boy to run All Long Running Tasks.
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TInput4"></typeparam>
        /// <typeparam name="TInput5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        /// <param name="argument3"></param>
        /// <param name="argument4"></param>
        /// <param name="argument5"></param>
        /// <param name="_longRunningCodeBlocks"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <param name="taskCreationOptions"></param>
        /// <returns></returns>
        public async Task<Tuple<List<Result<TResult>>, List<Task<Result<TResult>>>>> RunAllLongRunningTaskAsync<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>
            (TInput1 argument1,
            TInput2 argument2, TInput3 argument3, TInput4 argument4, TInput5 argument5,
            List<Func<TInput1, TInput2, TInput3, TInput4, TInput5, CancellationToken, Result<TResult>>> _longRunningCodeBlocks,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            List<Result<TResult>> _successfullyCompletedTasks = new List<Result<TResult>>();
            List<Task<Result<TResult>>> _failedTasks = new List<Task<Result<TResult>>>();
            
            if (_longRunningCodeBlocks != null && _longRunningCodeBlocks.Count > 0)
            {                
                List<Task<Result<TResult>>> _tasks = new List<Task<Result<TResult>>>();
                for (int _taskIndex = 0; _taskIndex < _longRunningCodeBlocks.Count; ++_taskIndex)
                {
                    for (int i = 0; i < _numberOfCores; ++i)
                    {
                        _tasks.Add(Task.Factory.StartNew<Result<TResult>>(
                                () => //arg1, arg2, arg3, arg4, arg5
                                {
                                    return _longRunningCodeBlocks[_taskIndex](argument1, argument2, argument3, argument4, argument5, cancellationToken);
                                },
                                cancellationToken,
                                taskCreationOptions,
                                TaskScheduler.Default
                                ));
                    }

                    while (_tasks.Count > 0 && !cancellationToken.IsCancellationRequested)
                    {
                        var completedTask = await Task.WhenAny(_tasks); // No Exception thrown here @WhenAny()    

                        TryCatch.ProcessTask(
                            () =>
                            {
                                var _result = completedTask.Result; // Exception re-thrown here.
                                _successfullyCompletedTasks.Add(_result);
                            },
                            (_e, _errorList) =>
                            {
                            // Handle Exception - Peek into _errorList and radiate any required Error(s).                           
                            _failedTasks.Add(completedTask);
                            },
                            () =>
                            {
                                // Finally Block Code
                                _tasks.Remove(completedTask);
                            });
                    }
                }                
            }
            return Tuple.Create(_successfullyCompletedTasks, _failedTasks);
        }

        //public async Task<Tuple<List<Result<TResult>>, List<Task<Result<TResult>>>>> RunAllLongRunningTask_ParallelFor_Async<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>
        //    (TInput1 argument1,
        //    TInput2 argument2, TInput3 argument3, TInput4 argument4, TInput5 argument5,
        //    List<Func<TInput1, TInput2, TInput3, TInput4, TInput5, CancellationToken, Result<TResult>>> _longRunningCodeBlocks,
        //    CancellationTokenSource cancellationTokenSource,
        //    TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        //{
        //    CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);
        //    List<Result<TResult>> _successfullyCompletedTasks = new List<Result<TResult>>();
        //    List<Task<Result<TResult>>> _failedTasks = new List<Task<Result<TResult>>>();
        //    return Tuple.Create(_successfullyCompletedTasks, _failedTasks);
        //}

        /// <summary>
        /// Beware* - Beware of Cost** - 
        /// Roughly 200,000 cycles to create, 100,000 to retire and every context switch is 6,000-8,000. Plus memory cost of STACK SPACE.
        /// 
        /// Use this sparingly.
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TInput4"></typeparam>
        /// <typeparam name="TInput5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        /// <param name="argument3"></param>
        /// <param name="argument4"></param>
        /// <param name="argument5"></param>
        /// <param name="function"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <returns></returns>
        public async Task<Result<TResult>> CreateLongRunningTaskAsync<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(TInput1 argument1,
            TInput2 argument2, TInput3 argument3, TInput4 argument4, TInput5 argument5,
            Func<TInput1, TInput2, TInput3, TInput4, TInput5, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return await Task.Factory.StartNew<Result<TResult>>(() =>
            {
                return function(argument1, argument2, argument3, argument4, argument5, cancellationToken);
            },
                cancellationToken,
                TaskCreationOptions.LongRunning, // .NET creates a non-worker POOL THREAD, dedicates thread to this TASK.
                TaskScheduler.Default
            );
        }

        /// <summary>
        /// Beware* - Beware of Cost** - 
        /// Roughly 200,000 cycles to create, 100,000 to retire and every context switch is 6,000-8,000. Plus memory cost of STACK SPACE.
        /// 
        /// Use this sparingly.
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TInput4"></typeparam>
        /// <typeparam name="TInput5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="argument1"></param>
        /// <param name="argument2"></param>
        /// <param name="argument3"></param>
        /// <param name="argument4"></param>
        /// <param name="argument5"></param>
        /// <param name="function"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <returns></returns>
        public Task<Result<TResult>> CreateLongRunningTask<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(TInput1 argument1,
            TInput2 argument2, TInput3 argument3, TInput4 argument4, TInput5 argument5,
            Func<TInput1, TInput2, TInput3, TInput4, TInput5, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>(() => 
            {
                return function(argument1, argument2, argument3, argument4, argument5, cancellationToken);
            },
                cancellationToken,
                TaskCreationOptions.LongRunning, // .NET creates a non-worker POOL THREAD, dedicates thread to this TASK.
                TaskScheduler.Default
            );
        }

        #endregion

        #region Private Method(s)

        private CancellationToken Fetch_CancellationToken(CancellationTokenSource cancellationTokenSource)
        {
            return cancellationTokenSource?.Token
                      ?? new CancellationTokenSource().Token;       
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



namespace PerfGuard.TPL
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using System;
	using System.Threading.Tasks;

    ///<summary>
    /// Facade Tasks - Pronounced as FASssAaDE Tasks.
    /// Facade Task lack of Explicit code during task creation. 
    /// It is assumed that the computation is specified elsewhere and is already running such as a Network request.
    /// 
    /// Why provide a Facade Task?
    /// To provide a common object model (a.k.a TASK) for interfacing with both Asynchronous and Parallel Operations.
    /// 
    /// EdFacadeTask is a Facade Task.
    /// This will wrap all calls going out of letitgos applications to 3rd parties REST APIs. 
    /// </summary>
    public class EdFacadeTask : IDisposable
    {
        ///<summary>
        /// Get data from Internet. Is a good option to use Fassade tasks.
        /// 
        /// IAsyncresult result = WebRequestObject.BeginGetResponse(new AsyncCallback(WebResponseCallback));         
        /// var t = RunAsFacadeTask(result);        
        /// </summary>       
        public Task RunAsFacadeTask<TResult>(object state)
        {
            using (this)
            {
                TaskCompletionSource<TResult> tc = new TaskCompletionSource<TResult>(state);
                //tc.SetResult((TResult)result);
                return tc.Task;  
            }
        }

        public static async Task<Result<TResult>> RunAsFacadeTaskAsync<TResult>(object state)
        {
            //using (this)
            //{
                TaskCompletionSource<TResult> tc = new TaskCompletionSource<TResult>(state);         
                //await tc.Task;

                return Statics.TryCatch.ProcessTask<TResult>(() =>                    
                    {                         
                        var _result = tc.Task.Result; // Exception re-thrown here.
                        return Result.Ok(_result);
                    },
                    (_e, _errorList) =>
                    {
                        // Handle Exception - Peek into _errorList and radiate any required Error(s).
                        return Result.Fail<TResult>(Messages.EXCEPTION_ALREADY_RECORDED);
                    },
                    () =>
                    {
                        // Finally Block Code                       
                    });
            //}
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



namespace PerfGuard.TPL
{

	using PerfGuard.Core;
	using System;
	using System.Threading.Tasks;

    /// <summary>
    /// Implementations for Parallel.For(), Parallel.ForEach() and Parallel.Invoke()
    /// 
    /// Prallel class uses "fork-join" pattern.
    /// 
    /// TPL Support
    /// 1. Data Parallelism: Parallel.For and Parallel.ForEach
    ///   Parallel.For(0, N, (i) => { DoWork(i); });
    ///   Parallel.ForEach(ds, (e) => { DoWork(e);
    /// });
    ///
    /// 2. Task Parallelism: Parallel.Invoke
    ///   Parallel.Invoke(() => Task1(), () => Task2(), () => Task3(), () => Task4(), () => Task5());
    /// </summary>
    public class EdParallel : IDisposable
    {
        public void For()
        {
            int i = 0, e = 10;
            Parallel.For<Result>(i, e, null,() =>
            {
                // Initialisation
                return Result.Ok();
            },
            (i1, p, r) => 
            {
                // The body to run for each iteration
                return Result.Ok();
            }, 
            (r1) => 
            {
                // Some House Keeping
            });
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




namespace PerfGuard.TPL
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

    /// <summary>
    /// 
    /// Welcome to - PerfGuard a.k.a - Performance Guardian. 
    /// 
    /// Are you excited - to write some very very Performant Parallel and Asynchronous Code?
    /// Very Well good then let's begin...
    /// 
    /// Edtask is Education Task. This will invoke TPL on your behalf.
    /// 
    /// Read the (detailed) instruction on every Method to fully utilise them to their TRUE potential. 
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
    public class EdTask : IDisposable
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="action">The code as Action that will be executed as a Task.</param>
        /// <returns>True if the Task completed or False if the Task failed.</returns>
        public Task<Result> RunAsTask(Action action)
        {
            // Equivalent, but slightly more efficent... StartNew().
            Task _task = Task.Factory.StartNew(() =>
            {
                action();
            });

            return ProcessTask(_task);
        }

        /// <summary>
        /// Closure variables become shared variables - beware if those vars are read & written (race condition?).
        /// 
        /// </summary>        
        /// <param name="arg1">String argument one to pass to action lamda.</param>
        /// <param name="arg2">String argument two to pass to action lamda.</param>
        /// <param name="action">The code as Action that will be executed as a Task.</param>
        /// <returns>True if the Task completed or False if the Task failed.</returns>
        public Task<Result> RunAsTask(string arg1, string arg2, Action<string, string> action)
        {
            // Equivalent, but slightly more efficent... StartNew().
            Task _task = Task.Factory.StartNew(() =>
            {
                action(arg1, arg2);
            });

            return ProcessTask(_task);
        }


        #region Waiting for Task(s) to Complete

        private Task<Result> ProcessTask(Task t)
        {
            string[] _exceptions = new string[] { };
            try
            {
                t.Wait();
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
                ? Task.FromResult(Result.Fail
                    (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions)))
                : Task.FromResult(Result.Ok());
        }

        private Task<Result<TResult>> ProcessTask<TResult>(Task<TResult> t)
        {
            string[] _exceptions = new string[] { };
            try
            {
                t.Wait();
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
                ? Task.FromResult(Result.Fail<TResult>
                    (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions)))
                : Task.FromResult(Result.Ok<TResult>(t.Result));
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

                errors.Add(ex.Message != null 
                    ? ex.Message : Messages.NO_EXCEPTIONS_FOUND);
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add(Messages.NO_EXCEPTIONS_FOUND);

            return errors;
        }

        private IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException.Message
                : Messages.INNER_EXCEPTION_IS_NULL);

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




namespace PerfGuard.TPL
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading;
	using System.Threading.Tasks;

    /// <summary>
    /// 
    /// Welcome to - PerfGuard a.k.a - Performance Guardian. 
    /// 
    /// This is the Asynchronous version of 'EdTask'
    /// And is hence rightly called 'EdTaskAsync'
    ///
    /// !Bow down to the Mighty AWAIT!     
    ///  
    /// Are you excited - to write some very very Performant Parallel and Asynchronous Code?
    /// Very Well good then let's begin...
    /// 
    /// Edtask is Education Task. This will invoke TPL on your behalf.
    /// 
    /// Read the (detailed) instruction on every Method to fully utilise them to their TRUE potential. 
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
    /// Responsiveness: Hide Latency of potentially long-running or blocking operations e.g I/O 
    /// by starting in the background. This is Async Progarmming.
    /// 
    /// Performance: Reduce Execution time of CPU-bound computations by dividing workload & executing simultaneously.
    /// This is Parallel Programming.
    /// 
    /// 
    /// 
    /// We haqve implmented the following Pattern(s).
    ///
    /// 1.1  Wait All Tasks(When All)
    /// 1.2  Wait All Tasks of Result<TResult>(When All)
    /// 1.3  Wait All Tasks(When All) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 1.4  Wait All Tasks of Result<TResult>(When All) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 
    /// 2.1  Wait Any Task(When Any)
    /// 2.2  Wait Any Task of Result<TResult>(When Any)
    /// 2.3   Wait Any Task(When Any) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 2.4  Wait Any Task of Result<TResult>(When Any) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 
    /// 3.1  Wait All Tasks One-by-One(When Any) [Remove from for-each]
    /// 3.2  Wait All Tasks One-by-One of Result<TResult>(When Any)[Remove from for-each]   
    /// 3.3  Wait All Tasks One-by-One(When Any) [Remove from for-each] - With Cancellation Token, Task Priorities,
    /// Parent-child tasks and Parametrer passing.
    /// 3.4  Wait All Tasks One-by-One of Result<TResult>(When Any)[Remove from for-each] - With Cancellation Token, 
    ///      Task Priorities, Parent-child tasks and Parametrer passing.
    /// 
    /// Continuation Tasks - Data Flow Tasks Pattern
    /// 1. Many-to-One
    ///    Task.Factory.ContinueWhenAll(tasks, (setOfTasks => { //Code here to run after the Array of tasks has completed });)
    /// 
    /// 2.Any - to - One
    ///    Task.Factory.ContinueWhenAny(tasks, (firstTask => { //Code here to run after the First has completed });)
    ///    
    /// 
    ///  -- When all, When any - Many-to-One Task Composition: .ContinueWhenAll, .ContinueWhenAny
    /// 
    /// </summary>
    /// 
    /// <seealso cref="PerfGuard.Statics.EdUsing">
    ///     Wrap this class object in a Using Block.
    /// </seealso>
    public class EdTaskAsync : IDisposable
    {
        /// <summary>
        /// Create and return a Task, this will be used in a pattern, 
        /// that takes an array/list of Task(s).
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="arg"></param>
        /// <param name="function"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <returns></returns>
        public Task<Result<TResult>> RunAsTaskAsync<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>(() =>
            {
                return function(arg, cancellationToken);
            },
            cancellationToken);           
        }



        // Parent-Child Tasks relationship.

        /// <summary>
        /// To Use this for Parent-Child Tasks relationship -
        /// Simply: Task child = Task.Factory.StartNew(() => {...}, TaskCreationOptions.AttachedToParent); 
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
        /// new Token for following Task or Task(s). Tokens' are SticKYyYyYyYy and hence this remedy.
        /// 
        /// In you Function before comencing on a Heavy Computing Task - check for the token.
        /// ex. if(cancellationToken.IsCancellationRequested) 
        /// {
        ///     // Clean up code goes before
        ///     cancellationToken.ThrowIfCancellationRequested();
        /// }
        ///
        /// Catch = OperationCancelledException in calling Code.
        /// </param>
        /// <returns></returns>
        public async Task<Result<TResult>> RunAsTaskAsync<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, TResult> function,
            CancellationTokenSource cancellationTokenSource)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            Task<TResult> _task = Task.Factory.StartNew(() =>
            {
                return function(arg, cancellationToken);
            },
            cancellationToken);

            return await ProcessTaskAsync(_task);
        }

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


        #region Pattern Implementaion - 1

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
        //public async Task WaitForAllTasks_ToComplete_Async()
        //{

        //}

        #endregion


        #region Pattern Implementaion - 2

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
        public async Task<Result<TResult>> WaitForAnyTaskToComplete_Async<TResult>(List<Task<TResult>> tasks,
            CancellationTokenSource cancellationTokenSource)
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
            return Result.Fail<TResult>(string.Empty, Messages.ALL_TASKS_FAILED);
        }        

        #endregion

        #region Pattern Implementaion - 3

        /// <summary>   
        /// 
        /// WaitForAllTasks_ToComplete - Pass a List of Tasks and Wait for them to finish.
        /// All Tasks will be executed Parallely. Code will return to calling method once all have completed.
        ///
        /// </summary>
        /// 
        /// <typeparam name="TResult"></typeparam>
        //  <param name="tasks"></param>
        //  <param name="cancellationTokenSource">One Call to cancel them all.</param>
        /// 
        /// <returns>
        /// List<Task> - the list of tasks that completed Successfully. 
        /// Failed Tasks are ignored, and there details are recorded via appropriate logging mechanism.        /// 
        /// </returns>
        /// 
        /// <remarks>
        /// Pattern Implementation : 3.1 -> Wait All Tasks One-by-One (When Any) [Remove from for-each]
        /// </remarks>
        public async Task<List<Task>> WaitForAllTasks_OneByOne_ToCompleteAsync(List<Task> tasks,
            CancellationTokenSource cancellationTokenSource)
        {
            List<Task> successfullyCompletedTasks = new List<Task>();
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

        /// <summary>   
        /// 
        /// WaitForAllTasks_ToComplete - Pass a List of Tasks and Wait for them to finish.
        /// All Tasks will be executed Parallely. Code will return to calling method once all have completed.
        ///
        /// </summary>
        /// 
        /// <typeparam name="TResult"></typeparam>
        //  <param name="tasks"></param>
        //  <param name="cancellationTokenSource">One Call to cancel them all.</param>
        /// 
        /// <returns>
        /// List<Task> - the list of tasks that completed Successfully. 
        /// Failed Tasks are ignored, and there details are recorded via appropriate logging mechanism.        /// 
        /// </returns>
        /// 
        /// <remarks>
        /// Pattern Implementation : 3.1 -> Wait All Tasks One-by-One (When Any) [Remove from for-each]
        /// </remarks>
        public async Task<List<Task>> WaitForAllTasks_OneByOne_ToComplete_Async(List<Task> tasks,
            CancellationTokenSource cancellationTokenSource)
        {
            List<Task> successfullyCompletedTasks = new List<Task>();
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



        #endregion


        #region Helper methods

        private CancellationToken Fetch_CancellationToken(CancellationTokenSource cancellationTokenSource)
        {
            //return cancellationTokenSource?.Token
            //          ?? new CancellationTokenSource().Token;

            if(cancellationTokenSource != null)
            {
                return cancellationTokenSource.Token;
            }
            return new CancellationTokenSource().Token;
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
                    (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions))
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
                    (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions))
                : Result.Ok<TResult>(taskResult);
        }

        #endregion


        #region Exception Handling - AggregateException and Exception(Ss)

        /*
         * How to observe? Task Exceptions -
         * 1. call .wait or touch .Result - exception re-thrown at this point
         * 2. call Task.WaitAll - exceptions re-thrown when all have finished
         * 3. touch task's ,Exception property *after* task has completed
         * 4. subscribe to TaskScheduler.UnobservedTaskException     
         * 
         * If you do not do any of the above - the GC will throw the exception for you.
         * So, you better handle it while it lasts.
         */

        private IList<string> Handle_AggregateException(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {
                // string taskWasCancelled = string.Empty;
                //if (ex.InnerException is OperationCanceledException)
                //    taskWasCancelled = Messages.TASK_WAS_CANCELLED;

                errors.Add(ex.Message != null 
                    ? ex.Message : Messages.NO_EXCEPTIONS_FOUND);
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add(Messages.NO_EXCEPTIONS_FOUND);

            return errors;
        }

        private IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException.Message
                : Messages.INNER_EXCEPTION_IS_NULL);

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




namespace PerfGuard.TPL
{
	using PerfGuard.Core;
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;

    public interface IPerformanceGuardianTPL
    {
        #region [Section:1] Create Tasks: Awaitable Tasks.

        Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None);


        Task<Result<TResult>> RunAsTaskAsync<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource);


        #endregion

        #region [Section:2] Parent-Child Tasks: 'Under Construction'


        Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            List<Func<TInput, CancellationToken, Result<TResult>>> _children,
            Func<IList<Task<Result<TResult>>>, Result<TResult>> parent,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None);

        Task CreateTask<TInput, TResult>(TInput arg,
            List<Func<TInput, CancellationToken, Result<TResult>>> _children,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None);


        #endregion

        #region [Section:3] Pattern: Wait for all Tasks to complete - One by One.

        Task<Tuple<List<Result<TResult>>, List<Task<TResult>>>> WaitForAllTasksToComplete_Async<TResult>(List<Task<TResult>> tasks, CancellationToken cancellationToken);


        #endregion

        #region [Section:4] Pattern: Wait for FIRST/Any Tasks to complete.

        Task<Result<TResult>> WaitForAnyTaskToComplete_Async<TResult>(List<Task<TResult>> tasks,
            CancellationToken cancellationToken);
        

        #endregion
        
    }
}



namespace PerfGuard.TPL
{
	using System;
	
    public class LongRunningWorkItem : IDisposable
    {
        #region List of all Long Running Workitems for this class.



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




namespace PerfGuard.TPL
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading;
	using System.Threading.Tasks;

    /// <summary>
    /// 
    /// Welcome to - PerfGuard a.k.a - Performance Guardian. 
    /// 
    /// This is the TaskManager
    ///
    /// !Bow down to the Mighty AWAIT!     
    ///  
    /// Are you excited - to write some very very Performant Parallel and Asynchronous Code?
    /// Very Well good then let's begin...
    /// 
    /// Edtask is Education Task. This will invoke TPL on your behalf.
    /// 
    /// Read the (detailed) instruction on every Method to fully utilise them to their TRUE potential. 
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
    /// Responsiveness: Hide Latency of potentially long-running or blocking operations e.g I/O 
    /// by starting in the background. This is Async Progarmming.
    /// 
    /// Performance: Reduce Execution time of CPU-bound computations by dividing workload & executing simultaneously.
    /// This is Parallel Programming.
    /// 
    /// 
    /// 
    /// We haqve implmented the following Pattern(s).
    ///
    /// 1.1  Wait All Tasks(When All)
    /// 1.2  Wait All Tasks of Result<TResult>(When All)
    /// 1.3  Wait All Tasks(When All) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 1.4  Wait All Tasks of Result<TResult>(When All) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 
    /// 2.1  Wait Any Task(When Any)
    /// 2.2  Wait Any Task of Result<TResult>(When Any)
    /// 2.3   Wait Any Task(When Any) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 2.4  Wait Any Task of Result<TResult>(When Any) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 
    /// 3.1  Wait All Tasks One-by-One(When Any) [Remove from for-each]
    /// 3.2  Wait All Tasks One-by-One of Result<TResult>(When Any)[Remove from for-each]   
    /// 3.3  Wait All Tasks One-by-One(When Any) [Remove from for-each] - With Cancellation Token, Task Priorities,
    /// Parent-child tasks and Parametrer passing.
    /// 3.4  Wait All Tasks One-by-One of Result<TResult>(When Any)[Remove from for-each] - With Cancellation Token, 
    ///      Task Priorities, Parent-child tasks and Parametrer passing.
    /// 
    /// Continuation Tasks - Data Flow Tasks Pattern
    /// 1. Many-to-One
    ///    Task.Factory.ContinueWhenAll(tasks, (setOfTasks => { //Code here to run after the Array of tasks has completed });)
    /// 
    /// 2.Any - to - One
    ///    Task.Factory.ContinueWhenAny(tasks, (firstTask => { //Code here to run after the First has completed });)
    ///    
    /// 
    ///  -- When all, When any - Many-to-One Task Composition: .ContinueWhenAll, .ContinueWhenAny
    /// 
    /// </summary>
    /// 
    /// <seealso cref="PerfGuard.Statics.EdUsing">
    ///     Wrap this class object in a Using Block.
    /// </seealso>
    public class TaskManager : IDisposable
    {
        private readonly int numberOfCores;

        #region Constructor(s)
        public TaskManager()
        {
            numberOfCores = System.Environment.ProcessorCount;
        }
        #endregion

        #region [Section:1] Create Tasks - with varing Input Parameters.

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="arg"></param>
        /// <param name="function"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <param name="taskCreationOptions"></param>
        /// <returns></returns>
        public Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {            
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>(() =>
            {
                return function(arg, cancellationToken);
            },
            cancellationToken, 
            taskCreationOptions, 
            TaskScheduler.Default
            );
        }

        #region Parent-Child Testing
        /// <summary>
        /// Testing - Parent - child relationship. 
        /// Parent Task is completed after all child tasks have completed.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="arg"></param>
        /// <param name="_children"></param>
        /// <param name="childrenResults"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <param name="taskCreationOptions"></param>
        /// <returns></returns>
        public Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            List<Func<TInput, CancellationToken, Result<TResult>>> _children,
            Func<IList<Task<Result<TResult>>>, Result<TResult>> parent,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>(() =>
            {
                IList<Task<Result<TResult>>> _tasks = new List<Task<Result<TResult>>>();
                _children.ForEach(child =>
                {
                    _tasks.Add(Task.Factory.StartNew<Result<TResult>>(() => 
                    {
                        return child(arg, cancellationToken);
                    }, cancellationToken, TaskCreationOptions.AttachedToParent, TaskScheduler.Default));
                });

                return parent(_tasks);
            },
            cancellationToken, taskCreationOptions, TaskScheduler.Default);
        }
        public Task CreateTask<TInput, TResult>(TInput arg,
            List<Func<TInput, CancellationToken, Result<TResult>>> _children,            
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew(() =>
            {               
                _children.ForEach(child =>
                {
                    Task.Factory.StartNew<Result<TResult>>(() =>
                    {
                        return child(arg, cancellationToken);
                    }, cancellationToken, TaskCreationOptions.AttachedToParent, TaskScheduler.Default);
                });                
            },
            cancellationToken, taskCreationOptions, TaskScheduler.Default);
        }
        #endregion

        #endregion

        #region [Section:2] Pattern: Wait for all Tasks to Complete - one-by-one. 


        #endregion

        #region [Section:3] Pattern: Wait for first task of Tasks to Complete - any one. 


        #endregion

        #region [Section:4] Pattern: Continuation Tasks - Continue When All tasks complete.


        #endregion

        #region [Section:5] Pattern: Continuation Tasks - Continue When Any one task complete.


        #endregion

        #region [Section:6] Pattern: DataFlow, Tasks, etc.


        #endregion

        #region [Section:7] Pattern: Wait for all Tasks to complete - One by One

        /// <summary>   
        /// 
        /// WaitForAllTasks_ToComplete - Pass a List of Tasks and Wait for them to finish.
        /// All Tasks will be executed Parallely. Code will return to calling method once all have completed.
        ///
        /// </summary>
        /// 
        /// <typeparam name="TResult"></typeparam>
        //  <param name="tasks"></param>
        //  <param name="cancellationTokenSource">One Call to cancel them all.</param>
        /// 
        /// <returns>
        /// List<Task> - the list of tasks that completed Successfully. 
        /// Failed Tasks are ignored, and there details are recorded via appropriate logging mechanism.        /// 
        /// </returns>
        /// 
        /// <remarks>
        /// Pattern Implementation : 3.1 -> Wait All Tasks One-by-One (When Any) [Remove from for-each]
        /// </remarks>
        public async Task<List<Task>> RunAllTasks_Async(List<Task> tasks)
        {
            List<Task> successfullyCompletedTasks = new List<Task>();
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

        #region [Section:8] Pattern: 


        #endregion

        #region [Section:9] Pattern: 


        #endregion

        #region [Section:10] Pattern: 


        #endregion

        #region [Section:11] Long Running Tasks - CPU Intensive Tasks/Network Calls with async/await.

        //public (int hours, int minutes, int seconds) teassasst()
        //{
        //    return (1, 2, 3);
        //}

        /*
         * Start just T tasks - one per core
         * As tasks finish, start new ones...
         */
        public async Task<Tuple<List<Result<Task>>, List<Result<Task>>>> RunLongRunningTasksParalleley<TInput, TResult>
            (TInput arg, IList<Func<TInput, CancellationToken, Result<TResult>>> tasksCode,
            CancellationTokenSource cancellationTokenSource)            
        {
            CancellationToken cancellationToken = 
                Fetch_CancellationToken(cancellationTokenSource);

            int _totalNumberOfTasks = tasksCode.Count();
            List<Task> _tasks = new List<Task>();

            List<Result<Task>> _successfullyCompleted = new List<Result<Task>>();
            List<Result<Task>> _failedTasks = new List<Result<Task>>();

            while (_totalNumberOfTasks > 0)
            {                
                for (int i = 0; i < numberOfCores; i++)
                {
                    _tasks.Add(CreateTask(arg, tasksCode[i], cancellationToken));               
                }

                // _completedTasks can be less than the number we sent - some might fail!**
                var _completedTasks = await RunAllTasks_Async(_tasks);

                _completedTasks.ForEach(i => 
                {
                    _successfullyCompleted.Add(Result.Ok(i));
                    tasksCode.RemoveAt(_tasks.IndexOf(i));
                    _tasks.Remove(i);                    
                });
                //_tasks.RemoveAll(p => _completedTasks.Find(f => f == p) != null);

                _totalNumberOfTasks -= _completedTasks.Count();
            }

            return Tuple.Create(_successfullyCompleted, _failedTasks);
        }

        // We have Parallel.For - Prallel class uses "fork-join" pattern


        #endregion

        #region [Section:12] Fetch_CancellationToken Method.

        private CancellationToken Fetch_CancellationToken(CancellationTokenSource cancellationTokenSource)
        {
            //return cancellationTokenSource?.Token
            //          ?? new CancellationTokenSource().Token;

            if (cancellationTokenSource != null)
            {
                return cancellationTokenSource.Token;
            }
            return new CancellationTokenSource().Token;
        }

        #endregion

        #region [Section:13] Waiting for Task to Complete - Note* Used in conjunction with [Section:1].        

        private async Task<Result<TResult>> ProcessTaskAsync<TResult>(Task<TResult> t)
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
                ? Result.Fail<TResult>
                    (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions))
                : Result.Ok<TResult>(t.Result);
        }

        private async Task<Result<TResult>> ProcessTaskAsync_Not<TResult>(Task<TResult> t)
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
                    (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions))
                : Result.Ok<TResult>(taskResult);
        }

        #endregion

        #region [Section:14] Exception Handling - AggregateException and Exception(Ss)

        /*
         * How to observe? Task Exceptions -
         * 1. call .wait or touch .Result - exception re-thrown at this point
         * 2. call Task.WaitAll - exceptions re-thrown when all have finished
         * 3. touch task's ,Exception property *after* task has completed
         * 4. subscribe to TaskScheduler.UnobservedTaskException     
         * 
         * If you do not do any of the above - the GC will throw the exception for you.
         * So, you better handle it while it lasts.
         */

        private IList<string> Handle_AggregateException(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {
                // string taskWasCancelled = string.Empty;
                //if (ex.InnerException is OperationCanceledException)
                //    taskWasCancelled = Messages.TASK_WAS_CANCELLED;

                errors.Add(ex.Message != null
                    ? ex.Message : Messages.NO_EXCEPTIONS_FOUND);
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add(Messages.NO_EXCEPTIONS_FOUND);

            return errors;
        }

        private IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException.Message
                : Messages.INNER_EXCEPTION_IS_NULL);

            return errors;
        }

        #endregion

        #region [Section:15] Private methods

        private Task CreateTask<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> tasksCode,
            CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew<Result<TResult>>(() =>
            {
                return tasksCode(arg, cancellationToken);
            },
            cancellationToken);
        }

        #endregion

        #region [Section:20] IDisposable Support

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



namespace PerfGuard.TPL
{
	using PerfGuard.Constants;
	using PerfGuard.Core;
	using PerfGuard.Statics;
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;

    /// <summary>
    /// Use this.
    /// Welcome to - PerfGuard a.k.a - Performance Guardian. 
    /// 
    /// This is the TaskManager
    ///
    /// !Bow down to the Mighty AWAIT!     
    ///  
    /// Are you excited - to write some very very Performant Parallel and Asynchronous Code?
    /// Very Well good then let's begin...
    /// 
    /// Edtask is Education Task. This will invoke TPL on your behalf.
    /// 
    /// Read the (detailed) instruction on every Method to fully utilise them to their TRUE potential. 
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
    /// Responsiveness: Hide Latency of potentially long-running or blocking operations e.g I/O 
    /// by starting in the background. This is Async Progarmming.
    /// 
    /// Performance: Reduce Execution time of CPU-bound computations by dividing workload & executing simultaneously.
    /// This is Parallel Programming.
    /// 
    /// 
    /// 
    /// We haqve implmented the following Pattern(s).
    ///
    /// 1.1  Wait All Tasks(When All)
    /// 1.2  Wait All Tasks of Result<TResult>(When All)
    /// 1.3  Wait All Tasks(When All) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 1.4  Wait All Tasks of Result<TResult>(When All) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 
    /// 2.1  Wait Any Task(When Any)
    /// 2.2  Wait Any Task of Result<TResult>(When Any)
    /// 2.3   Wait Any Task(When Any) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 2.4  Wait Any Task of Result<TResult>(When Any) - With Cancellation Token, Task Priorities,
    ///     Parent-child tasks and Parametrer passing.
    /// 
    /// 3.1  Wait All Tasks One-by-One(When Any) [Remove from for-each]
    /// 3.2  Wait All Tasks One-by-One of Result<TResult>(When Any)[Remove from for-each]   
    /// 3.3  Wait All Tasks One-by-One(When Any) [Remove from for-each] - With Cancellation Token, Task Priorities,
    /// Parent-child tasks and Parametrer passing.
    /// 3.4  Wait All Tasks One-by-One of Result<TResult>(When Any)[Remove from for-each] - With Cancellation Token, 
    ///      Task Priorities, Parent-child tasks and Parametrer passing.
    /// 
    /// Continuation Tasks - Data Flow Tasks Pattern
    /// 1. Many-to-One
    ///    Task.Factory.ContinueWhenAll(tasks, (setOfTasks => { //Code here to run after the Array of tasks has completed });)
    /// 
    /// 2.Any - to - One
    ///    Task.Factory.ContinueWhenAny(tasks, (firstTask => { //Code here to run after the First has completed });)
    ///    
    /// 
    ///  -- When all, When any - Many-to-One Task Composition: .ContinueWhenAll, .ContinueWhenAny
    ///  
    /// 
    /// :: Types of Parallelism ::
    /// 1. Data Parallelism [Parallel.For and Parallel.Foreach]
    /// - the same operation executed across Different DATA
    /// 
    /// 2. Task Parallelism [Parallel.Invoke]
    /// - Different Operations Executed across the SAME or DIFFERENT DATA
    /// 
    /// 3. DataFlow Parallelism
    /// - When operation sDEPEND on one another.
    /// - Where the RESULT of oNE Task feeds the NEXT
    /// 
    /// 4. Embarrassingly Parallel (Parallelism) [Parallel.Invoke]
    /// - Also known as - Delightfully Parallel
    /// - A problem is Embarrassingly parallel if the computations are ENTIRELY INDEPENDENT of one another
    /// 
    /// </summary>
    /// 
    /// <seealso cref="PerfGuard.Statics.EdUsing">
    ///     Wrap this class object in a Using Block.
    /// </seealso>
    public class TaskPanther : IDisposable, IPerformanceGuardianTPL
    {
        private readonly int _numberOfCores;

        private IDictionary<IDisposable, LongRunningWorkItem> _numberOfClassesAndTheirLongRunningTasks = 
            new Dictionary<IDisposable, LongRunningWorkItem>();

        //public IDictionary<IDisposable, LongRunningWorkItem> NumberOfClassesAndTheirLongRunningTasks
        //{
        //    get => _numberOfClassesAndTheirLongRunningTasks;
        //    set => _numberOfClassesAndTheirLongRunningTasks = value;
        //}

        #region Constructor(s)
        public TaskPanther()
        {
            _numberOfCores = System.Environment.ProcessorCount;       
        }
        #endregion

        #region [Section:1] Create Tasks: Awaitable Tasks.

        public async Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return await Task.Factory.StartNew<Result<TResult>>((arg1) =>
            {
                return function((TInput)arg1, cancellationToken);
            },
                arg, // Not using Closure - using Task Parameter.
                cancellationToken,
                taskCreationOptions,
                TaskScheduler.Default
            );
        }

        public async Task<Result<TResult>> RunAsTaskAsync<TInput, TResult>(TInput arg,
            Func<TInput, CancellationToken, Result<TResult>> function,
            CancellationTokenSource cancellationTokenSource)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            Task<Result<TResult>> _task = Task.Factory.StartNew<Result<TResult>>((arg1) =>
            {
                return function((TInput)arg1, cancellationToken);
            },
            arg,
            cancellationToken);

            return await ProcessTaskAsync(_task);
        }

        #endregion

        #region [Section:2] Parent-Child Tasks: 'Under Construction'

        /// <summary>
        /// Testing - Parent - child relationship. 
        /// Parent Task is completed after all child tasks have completed.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="arg"></param>
        /// <param name="_children"></param>
        /// <param name="childrenResults"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <param name="taskCreationOptions"></param>
        /// <returns></returns>
        public Task<Result<TResult>> CreateTask<TInput, TResult>(TInput arg,
            List<Func<TInput, CancellationToken, Result<TResult>>> _children,
            Func<IList<Task<Result<TResult>>>, Result<TResult>> parent,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew<Result<TResult>>(() =>
            {
                IList<Task<Result<TResult>>> _tasks = new List<Task<Result<TResult>>>();
                _children.ForEach(child =>
                {
                    _tasks.Add(Task.Factory.StartNew<Result<TResult>>(() =>
                    {
                        return child(arg, cancellationToken);
                    }, cancellationToken, TaskCreationOptions.AttachedToParent, TaskScheduler.Default));
                });

                return parent(_tasks);
            },
            cancellationToken, taskCreationOptions, TaskScheduler.Default);
        }

        /// <summary>
        /// Parent - Child Tasks.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="arg"></param>
        /// <param name="_children"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <param name="taskCreationOptions"></param>
        /// <returns></returns>
        public Task CreateTask<TInput, TResult>(TInput arg,
            List<Func<TInput, CancellationToken, Result<TResult>>> _children,
            CancellationTokenSource cancellationTokenSource,
            TaskCreationOptions taskCreationOptions = TaskCreationOptions.None)
        {
            CancellationToken cancellationToken = Fetch_CancellationToken(cancellationTokenSource);

            // Equivalent, but slightly more efficent... StartNew().
            return Task.Factory.StartNew(() =>
            {
                _children.ForEach(child =>
                {
                    Task.Factory.StartNew<Result<TResult>>(() =>
                    {
                        return child(arg, cancellationToken);
                    }, cancellationToken, TaskCreationOptions.AttachedToParent, TaskScheduler.Default);
                });
            },
            cancellationToken, taskCreationOptions, TaskScheduler.Default);
        }

        #endregion

        #region Completed - [Section:3] Pattern: Wait for all Tasks to complete - One by One.

        public async Task<Tuple<List<Result<TResult>>, List<Task<TResult>>>> WaitForAllTasksToComplete_Async<TResult>
            (List<Task<TResult>> tasks, CancellationToken cancellationToken)
        {
            List<Result<TResult>> _successfullyCompletedTasks = new List<Result<TResult>>();
            List<Task<TResult>> _failedTasks = new List<Task<TResult>>();              

            if (tasks != null && tasks.Count > 0)
            {
                while (tasks.Count > 0 && !cancellationToken.IsCancellationRequested)
                {                   
                    var completedTask = await Task.WhenAny(tasks); // No Exception thrown here @WhenAny()    

                    TryCatch.ProcessTask(
                        () =>
                        {
                            var _result = completedTask.Result; // Exception re-thrown here.
                            _successfullyCompletedTasks.Add(Result.Ok(_result));                          
                        },
                        (_e, _errorList) =>
                        {
                            // Handle Exception - Peek into _errorList and radiate any required Error(s).                           
                            _failedTasks.Add(completedTask);                          
                        },
                        () =>
                        {
                            // Finally Block Code
                            tasks.Remove(completedTask);
                        });                            
                }
            }           
            return Tuple.Create(_successfullyCompletedTasks, _failedTasks);
        }

        #endregion

        #region Completed - [Section:4] Pattern: Wait for FIRST/Any Tasks to complete.

        public async Task<Result<TResult>> WaitForAnyTaskToComplete_Async<TResult>(List<Task<TResult>> tasks,
            CancellationToken cancellationToken)
        {           
            if (tasks != null && tasks.Count > 0)
            {
                while (tasks.Count > 0 && !cancellationToken.IsCancellationRequested)
                {
                    var completedTask = await Task.WhenAny(tasks); // No Exception thrown here @WhenAny()                     

                    var _processResult = TryCatch.ProcessTask(
                        () =>
                            {
                                var _result = completedTask.Result; // Exception re-thrown here.
                                return Result.Ok(_result);
                            },
                        (_e, _errorList) => 
                            {
                                // Handle Exception - Peek into _errorList and radiate any required Error(s).
                                return Result.Fail<TResult>(Messages.EXCEPTION_ALREADY_RECORDED);
                            },
                        () => 
                            {
                                // Finally Block Code
                                tasks.Remove(completedTask);                             
                            }); 
                    
                    if(_processResult.IsSuccess)
                    {
                        return _processResult;
                    }
                } // End While
            }
            // All Tasks Failed
            return Result.Fail<TResult>(string.Empty, Messages.ALL_TASKS_FAILED);
        }

        #endregion

        #region [Section:5] Pattern: Continuation Tasks - Continue When FIRST/Any task completes.

        #endregion

        #region [Section:6] Pattern: Pattern: Continuation Tasks - Continue When All tasks complete.

        #endregion

        #region [Section:7] Pattern: Long Running Task(s)

        #endregion

        #region [Section:8] Pattern: 

        #endregion

        #region [Section:9] Pattern: 

        #endregion

        #region [Section:17] Waiting for Task to Complete - Note* Used in conjunction with [Section:1].        

        /// <summary>
        /// Exception Catching is remaining.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        private async Task<Result<TResult>> ProcessTaskAsync<TResult>(Task<Result<TResult>> t)
        {
            await t; // No shots fired yet

            var t1 = t.Result; // Block/Finalise the Call Now - This should be done in Exception handling block.
            return t1;

            //return new ExecuteMyCode()
            //    .Use(executeCodeObj =>
            //    {
            //        string[] _exceptions = executeCodeObj.InTryBlock(() =>
            //        {
            //            t.Wait();  // Make sure we have a result by now. Firing! now...
            //        });
            //
            //        return (_exceptions.Length > 0)
            //            ? Result.Fail<TResult>
            //                (Messages.TASK_FAILED_FUNNY, string.Concat(_exceptions))
            //            : Result.Ok<TResult>(t.Result.Value);
            //    });     
        }

        #endregion

        #region [Section:18] Exception Handling - AggregateException and Exception(Ss)

        /*
         * How to observe? Task Exceptions -
         * 1. call .wait or touch .Result - exception re-thrown at this point
         * 2. call Task.WaitAll - exceptions re-thrown when all have finished
         * 3. touch task's ,Exception property *after* task has completed
         * 4. subscribe to TaskScheduler.UnobservedTaskException     
         * 
         * If you do not do any of the above - the GC will throw the exception for you.
         * So, you better handle it while it lasts.
         */

        private IList<string> Handle_AggregateException(AggregateException ae)
        {
            IList<string> errors = new List<string>();

            ae.Flatten();
            foreach (var ex in ae.InnerExceptions)
            {
                // string taskWasCancelled = string.Empty;
                //if (ex.InnerException is OperationCanceledException)
                //    taskWasCancelled = Messages.TASK_WAS_CANCELLED;

                errors.Add(ex.Message != null
                    ? ex.Message : Messages.NO_EXCEPTIONS_FOUND);
                // Record string in Windows Event Log via Diagnostics.
            }

            if (errors.Count == 0)
                errors.Add(Messages.NO_EXCEPTIONS_FOUND);

            return errors;
        }

        private IList<string> Handle_Exception(Exception e)
        {
            IList<string> errors = new List<string>();

            // Record the following - Exception and Inner Exception details                        
            errors.Add((e.InnerException != null) ? e.InnerException.Message
                : Messages.INNER_EXCEPTION_IS_NULL);

            return errors;
        }

        #endregion        

        #region [Section:19] Fetch_CancellationToken Method.

        private CancellationToken Fetch_CancellationToken(CancellationTokenSource cancellationTokenSource)
        {
            return cancellationTokenSource?.Token
                      ?? new CancellationTokenSource().Token;

            //if (cancellationTokenSource != null)
            //{
            //    return cancellationTokenSource.Token;
            //}
            //return new CancellationTokenSource().Token;
        }

        #endregion

        #region [Section:20] IDisposable Support

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

namespace PerfGuard.TPL
{
	using System;
	using System.Threading;

    /// <summary>
    /// CancellationToken Token is STICKY - Create new for Unrelated Tasks.
    /// </summary>
    public class TaskToken : IDisposable
    {
        /// <summary>
        /// CancellationToken Token is STICKY - Create new for Unrelated Tasks.
        /// 
        /// CancellationToken Token should be passed to .NET
        /// 
        /// CancellationToken is access by CLOSURE Mechanism.
        /// </summary>
        /// <returns></returns>
        public CancellationToken Fetch_CancellationToken_ToSignalCancel()
        {
            return new CancellationTokenSource().Token;            
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




namespace PerfGuard.ValueObjects
{
	using PerfGuard.Core;
	using System;

    public class Email : ValueObject<Email>, IDisposable
    {
        private readonly string _emailValue;

        private Email(string emailValue)
        {
            _emailValue = emailValue;
        }

        public static Result<Email> Create(string emailValue)
        {
            if (string.IsNullOrWhiteSpace(emailValue) || string.IsNullOrEmpty(emailValue))
                return Result.Fail<Email>(PerfGuard.Constants.Messages.EMAIL_IS_NULL);

            emailValue = emailValue.Trim();

            if (emailValue.Length > PerfGuard.Constants.Misc.EMAIL_ALLOWED_LENGTH) return Result.Fail<Email>(PerfGuard.Constants.Messages.EMAIL_IS_TOO_LONG);
            if (!emailValue.Contains(PerfGuard.Constants.Misc.EMAIL_SHOULD_CONTAIN_AT)) return Result.Fail<Email>(PerfGuard.Constants.Messages.EMAIL_INVALID);

            return Result.Ok(new Email(emailValue));
        }

        protected override bool EqualsCore(Email other)
        {
            return _emailValue == other._emailValue;
        }

        protected override int GetHashCodeCore()
        {
            return _emailValue.GetHashCode();
        }

        /// <summary>
        /// Overloaded implicit conversion operator for Email Primitive Type.
        /// From Email Object to plain Email String (string object - wink wink)
        /// 
        /// Example of this implicit conversion -
        /// Email _email = GetEmail();
        /// sting _emailString = _email;
        /// </summary>
        /// <param name="email"></param>
        public static implicit operator string(Email email)
        {
            return email._emailValue;
        }

        /// <summary>
        /// Overloaded explicit conversion operator for Email Primitive Type.
        /// From Email string to Email Object
        /// 
        /// Example of this explicit conversion -
        /// string _emalString = "schools-validEmail@education.gov.au"
        /// Email _emailObject= Email(_emalString); 
        /// </summary>
        /// <param name="email"></param>
        public static explicit operator Email(string email)
        {
            return Create(email).Value;
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




namespace PerfGuard.ValueObjects
{
	using PerfGuard.Core;
	using System;
	using System.Runtime.CompilerServices;

    public class NotNullStringProperty : ValueObject<NotNullStringProperty>, IDisposable
    {
        private readonly string _notNullStringPropertyValue;

        private NotNullStringProperty(string notNullStringPropertyValue)
        {
            _notNullStringPropertyValue = notNullStringPropertyValue;
        }

        public static Result<NotNullStringProperty> Create(string notNullStringPropertyValueIs, 
            string detailsAboutProperty = PerfGuard.Constants.Messages.NotNullStringProperty_No_Details_Provided,
            [CallerMemberName] string callerMemberName = null,
            [CallerFilePath] string callerFilePath = null,
            [CallerLineNumber] int callerLineNumber = default(int))
        {
            if (string.IsNullOrWhiteSpace(notNullStringPropertyValueIs) || string.IsNullOrEmpty(notNullStringPropertyValueIs))
            {
                return Result.Fail<NotNullStringProperty>
                    (PerfGuard.Constants.Messages.NotNullStringProperty_Is_NULL +
                    PerfGuard.Constants.Messages.SPACE + detailsAboutProperty +
                    PerfGuard.Constants.Messages.PERIOD + PerfGuard.Constants.Messages.SPACE +
                    PerfGuard.Constants.Messages.CalledFromMethod + callerMemberName + PerfGuard.Constants.Messages.SPACE +
                    PerfGuard.Constants.Messages.FilePathOfCalledCode + callerFilePath + PerfGuard.Constants.Messages.SPACE +
                    PerfGuard.Constants.Messages.LineNumberOfCalledCode + callerLineNumber + PerfGuard.Constants.Messages.PERIOD);
            }

            notNullStringPropertyValueIs = notNullStringPropertyValueIs.Trim();           

            return Result.Ok(new NotNullStringProperty(notNullStringPropertyValueIs));
        }

        protected override bool EqualsCore(NotNullStringProperty other)
        {
            return _notNullStringPropertyValue == other._notNullStringPropertyValue;
        }

        protected override int GetHashCodeCore()
        {
            return _notNullStringPropertyValue.GetHashCode();
        }

        //public string Trim()
        //{
        //    return _notNullStringPropertyValue.GetHashCode();
        //}

        /// <summary>
        /// Overloaded implicit conversion operator for NotNullStringProperty Primitive Type.
        /// From NotNullStringProperty Object to plain NotNullStringProperty String (string object - wink wink)
        /// 
        /// Example of this implicit conversion -
        /// NotNullStringProperty _notNullStringProperty = GetNotNullStringProperty();
        /// sting _notNullStringPropertyString = _notNullStringProperty;
        /// </summary>
        /// <param name="notNullStringProperty"></param>
        public static implicit operator string(NotNullStringProperty notNullStringProperty)
        {
            return notNullStringProperty._notNullStringPropertyValue;
        }

        /// <summary>
        /// Overloaded explicit conversion operator for Email Primitive Type.
        /// From NotNullStringProperty string to NotNullStringProperty Object
        /// 
        /// Example of this explicit conversion -
        /// string _notNullStringPropertyString = "schools-validEmail@education.gov.au"
        /// NotNullStringProperty _notNullStringPropertyObject = NotNullStringProperty(_notNullStringPropertyString); 
        /// </summary>
        /// <param name="notNullStringProperty"></param>
        public static explicit operator NotNullStringProperty(string notNullStringProperty)
        {
            return Create(notNullStringProperty).Value;
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



















