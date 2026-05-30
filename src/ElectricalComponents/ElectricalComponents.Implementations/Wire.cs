using Network_Analysis_and_LGS.ElectricalComponents.Interfaces;

namespace Network_Analysis_and_LGS.ElectricalComponents.Implementations;

public class Wire : Interfaces.IWire
{
    private double _resistance { get; set; }
    private double _area { get; set; }
    private double _length { get; set; }
    public string ID { get; }


    public Wire()
    {
        _resistance = 0;
        _area = 2.5;
        _length = 1.0;
    }
    public Wire(double resistance, double area = 2.5, double length = 1.0)
    {
        _resistance = resistance;
        _area = area;
        _length = length;
    }

}