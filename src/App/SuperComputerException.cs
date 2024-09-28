namespace App;

public sealed class SuperComputerException : ApplicationException
{
    private SuperComputerException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public static SuperComputerException OperationHasFailed(string operation, Exception ex)
    {
        return new SuperComputerException($"Operation '{operation}' has failed.", ex);
    }
}