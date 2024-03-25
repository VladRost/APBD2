using apbdcw2.Exceptions;
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
        Console.WriteLine($"Container {containerNumber} is in a danger!");
    }
    public void Load(double items,string name)
    {
        if(name == "paliwo" && items > MaxLoadCapacity()*0.5){
            NotifyDanger(SerNumber);
        }
        else if (items > MaxLoadCapacity()*0.9)
        {
            throw new OverfillException("Not enough space");
        }
        else
        {
            Weight -= items;
        }
    }

    protected string GetTypeCont()
    {
        return "L";
    }

    
}