using apbdcw2.Exceptions;
using apbdcw2.Models;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // LiquidContainer liquidContainer = new LiquidContainer(5, 500, 10, "L");
            // liquidContainer.Load(600,"paliwo");
            // liquidContainer.Unload();
            // Console.WriteLine(liquidContainer.EmptyWeight);
            // Console.WriteLine(liquidContainer.Weight);
            // liquidContainer.Load(1200,"mleko"); 
            
            // Console.WriteLine(liquidContainer.ContainerType+" "+liquidContainer.EmptyWeight);

            GasContainer gasContainer = new GasContainer(10,200,5,"G");
        }
        catch (OverfillException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}