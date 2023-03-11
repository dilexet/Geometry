namespace Geometry.BusinessLogicLayer.CustomException
{
    public class TriangleNotExistException : System.Exception
    {
        public TriangleNotExistException()
        {
        }

        public TriangleNotExistException(string message)
            : base(message)
        {
        }

        public TriangleNotExistException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}