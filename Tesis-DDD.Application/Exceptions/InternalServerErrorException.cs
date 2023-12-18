namespace Tesis_DDD.Application.Exceptions
{
    public class InternalServerErrorException : ApplicationException
    {
        public InternalServerErrorException(string? message) : base(message)
        {
        }
    }
}
