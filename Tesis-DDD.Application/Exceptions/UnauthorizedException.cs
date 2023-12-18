namespace Tesis_DDD.Application.Exceptions
{
    public class UnauthorizedException :ApplicationException
    {
        public UnauthorizedException(string message) : base(message)
        {
        }
    }
}
