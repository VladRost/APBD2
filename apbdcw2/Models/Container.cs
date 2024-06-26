using apbdcw2.Exceptions;

namespace apbdcw2.Models;

public class Container{
    private static HashSet<string> serNumbers = new HashSet<string>();
    public double Weight{ get;set; }
    public double Height { get;set; }
    public double EmptyWeight { get;set; }
    public double Depth { get;set; }
    public string SerNumber { get;set; }
    public string ContainerType { get;set; }

    public Container(double height, double emptyWeight, double depth,string containerType)
    {
        Weight = 0;
        Height = height;
        EmptyWeight = emptyWeight;
        Depth = depth;
        SerNumber = GenerateSerNumber();
        ContainerType = containerType;
    }

    public double MaxLoadCapacity()
    {
        return EmptyWeight *3;
    }
    private string GenerateSerNumber()
    {
        Random random = new Random();
        string serNumber = $"KON-{ContainerType}-";
        int uniqNumber = random.Next(1, 100);
        while (serNumbers.Contains(serNumber + uniqNumber))
        {
            uniqNumber = random.Next(1, 100);
        }
        serNumber += uniqNumber.ToString();
        serNumbers.Add(serNumber);
        return serNumber;
    }

    public void Unload()
    {
        Weight = 0;
    }

    public void Load(double items,string name)
    {
        if (items > MaxLoadCapacity()-Weight)
        {
            throw new OverfillException("Not enough space");
        }
        else
        {
            Weight += items;
        }
    }
}