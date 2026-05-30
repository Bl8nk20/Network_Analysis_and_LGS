using Network_Analysis_and_LGS.AbstractLayer.Enums;

namespace Network_Analysis_and_LGS.ElectricalComponents.BasicComponents;

public class Wire : IWire
{
    private double _crossSectionArea;
    private double _resistivity;
    private double _length;

    public string ID { get; }
    public ComponentType Type => ComponentType.Wire;

    public double Length
    {
        get => _length;
        set => _length = value > 0 ? value : throw new ArgumentException("Length must be positive");
    }

    public double CrossSectionArea
    {
        get => _crossSectionArea;
        set => _crossSectionArea = value > 0 ? value : throw new ArgumentException("Area must be positive");
    }

    public Wire(double length, double crossSectionArea, double resistivity = 0.0175)
    {
        ID = Guid.NewGuid().ToString();
        Length = length;
        CrossSectionArea = crossSectionArea;
        _resistivity = resistivity;
    }

    public double GetResistance() => _resistivity * Length / CrossSectionArea;
}