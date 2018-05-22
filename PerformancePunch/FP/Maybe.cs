using System;

namespace PerformancePunch.FP
{
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
                        ($"Expected reference type is null. {typeof(T).ToString()} is Null.");
                return _value;
            }
        }

        public bool HasValue => _value != null;
        public bool HasNoValue => !HasValue;

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
            if (HasNoValue) return "No Value";
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
