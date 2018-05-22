using System;

namespace PerformancePunch.FP
{
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
    /// 2. Mutable Shell - Should as Dumb as possible.
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
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;

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
        /// Are army of monkeys is on this and hopefully this should be fixed, shortly.
        /// How about you try again in a minute!
        /// </example>
        public string DisplayError { get; private set; }

        /// <summary>
        /// This is an Error message, that is for Application Developers, BAs and other relevant parties.
        /// This can be system level, detailed for indicationg the Exact Technical cause of the error.
        /// </summary>
        public string Error { get; private set; }

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
                throw new InvalidOperationException("Error description property(s) should be null.");
            }
            if (!isSuccess && displayErrorDescription == string.Empty)
            {
                throw new InvalidOperationException("Error description property should not be null.");
            }

            IsSuccess = isSuccess;
            DisplayError = displayErrorDescription;
            Error = appLevelErrorDescription;
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
                if (!IsSuccess) throw new InvalidOperationException();

                return _value;
            }
        }

        protected internal Result(T value, bool isSuccess, string displayError, string appLevelErrorDesc)
            : base(isSuccess, displayError, appLevelErrorDesc)
        {
            _value = value;
        }
    }
}
