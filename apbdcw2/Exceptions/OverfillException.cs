using System.Runtime.Serialization;

namespace apbdcw2.Exceptions;
public class OverfillException:Exception
{

    public OverfillException(string message) : base(message)
    {
    }
}