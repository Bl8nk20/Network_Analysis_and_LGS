using Network_Analysis_and_LGS.ElectricalComponents;

namespace Network_Analysis_and_LGS.ElectricalComponents.Models;

public class Wire : IWire
{
    private double _length;
    private double _crossSectionArea;
    private double _resistivity; // Material-spezifisch

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
        Length = length;
        CrossSectionArea = crossSectionArea;
        _resistivity = resistivity;
    }

    /// <summary>
    /// Calculates resistance using R = ρ * L / A
    /// </summary>
    public double GetResistance() => _resistivity * Length / CrossSectionArea;
}