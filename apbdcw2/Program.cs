using apbdcw2.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            LiquidContainer liquidContainer = new LiquidContainer(500, 5, 300, 10, "L");
            liquidContainer.Load(500);

            liquidContainer.Load(300); 
            //liquidContainer.NotifyDanger(liquidContainer.SerNumber);
            Console.WriteLine(liquidContainer.ContainerType+" "+liquidContainer.EmptyWeight);
        }
        catch (OverfillException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}