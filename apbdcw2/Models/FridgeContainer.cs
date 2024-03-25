using apbdcw2.Exceptions;
using apbdcw2.Models;

class FridgeContainer : Container
{
    public string ProductType { get;set; }
    public double Temperature { get;set; }
     public FridgeContainer(double height, double emptyWeight, double depth,string containerType)
        : base(height, emptyWeight, depth, containerType)
    {
        Temperature = -30;
    }
    public void Load(double items,string name,double temperature)
    {
        if(temperature<Temperature){
            Console.WriteLine("Temperature too high");
        }
        else if (items > MaxLoadCapacity()-Weight)
        {
            throw new OverfillException("Not enough space");
        }
        else
        {
            Weight += items;
        }
    }
    protected string GetTypeCont()
    {
        return "F";
    }

    
}