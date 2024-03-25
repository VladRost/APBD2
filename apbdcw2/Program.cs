using apbdcw2.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            LiquidContainer liquidContainer = new LiquidContainer(500, 5, 300, 10, "L");
            liquidContainer.Load(500,"paliwo");

            liquidContainer.Load(350,"asdfs"); 
            
            Console.WriteLine(liquidContainer.ContainerType+" "+liquidContainer.EmptyWeight);
        }
        catch (OverfillException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}