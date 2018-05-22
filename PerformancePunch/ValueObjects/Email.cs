using PerformancePunch.FP;

namespace PerformancePunch.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        private readonly string _emailValue;

        private Email(string emailValue)
        {
            _emailValue = emailValue;
        }

        public static Result<Email> Create(string emailValue)
        {
            if (string.IsNullOrWhiteSpace(emailValue) || string.IsNullOrEmpty(emailValue))
                return Result.Fail<Email>("Email should not be empty");

            emailValue = emailValue.Trim();

            if (emailValue.Length > 256) return Result.Fail<Email>("Email is too long");
            if (!emailValue.Contains("@")) return Result.Fail<Email>("Email is invalid");

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
    }
}
