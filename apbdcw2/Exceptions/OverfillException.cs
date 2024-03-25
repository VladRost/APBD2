using System.Runtime.Serialization;

namespace apbdcw2.Exceptions;
public class OverfillException:Exception
{
    public OverfillException()
    {
    }


    public OverfillException(string? message) : base(message)
    {
    }

    
    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
    
}