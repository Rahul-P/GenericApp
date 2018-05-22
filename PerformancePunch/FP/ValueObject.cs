namespace PerformancePunch.FP
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
