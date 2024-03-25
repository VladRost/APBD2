namespace apbdcw2.Models;
interface IHazardNotifier
{
    void NotifyDanger(string containerNumber);
}
public class GasContainer : Container

{
    public double Pressure{ get;set; }
    public GasContainer(double height, double emptyWeight, double depth, string containerType) : base(height, emptyWeight, depth, containerType)
    {
        Pressure = 23;
    }
    public void Unload()
    {
        Weight = Weight*0.05;
    }
    protected string GetTypeCont()
    {
        return "G";
    }
    
}