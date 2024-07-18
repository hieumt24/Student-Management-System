namespace StudentManagementSystem.Domain.Exceptions
{
    public class ForbidException : Exception
    {
        public ForbidException() : base()
        {
        }

        public ForbidException(string message) : base(message)
        {
        }

        public ForbidException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}