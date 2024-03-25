using apbdcw2.Models;

interface IHazardNotifier
{
    void NotifyDanger(string containerNumber);
}
class LiquidContainer : Container, IHazardNotifier
{
     public LiquidContainer(double weight, double height, double emptyWeight, double depth,string containerType)
        : base(weight, height, emptyWeight, depth, containerType)
    {
    }
    public void NotifyDanger(string containerNumber)
    {
        Console.WriteLine($"Container {containerNumber} is in danger!");
    }

    protected string GetTypeCont()
    {
        return "L";
    }

    
}