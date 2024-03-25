namespace apbdcw2.Models;
public class Container{
    //private string Depth = "";
    public string Depth{get; set;}
    

    private double _weight;
    public double weight{
        get{return _weight;}
        set{
            _weight=value;
        }
    }
    public Container(string depth){
        Depth = depth;
    }
}