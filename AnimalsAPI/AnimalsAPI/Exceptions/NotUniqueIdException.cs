namespace AnimalsAPI.Exceptions;

public class NotUniqueIdException : Exception
{
    public NotUniqueIdException(string? message) : base(message)
    {
        
    }

    public NotUniqueIdException()
    {
    }
}