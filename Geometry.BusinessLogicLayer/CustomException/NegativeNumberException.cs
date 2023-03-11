namespace Geometry.BusinessLogicLayer.CustomException
{
    public class NegativeNumberException : System.Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message)
            : base(message)
        {
        }

        public NegativeNumberException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}