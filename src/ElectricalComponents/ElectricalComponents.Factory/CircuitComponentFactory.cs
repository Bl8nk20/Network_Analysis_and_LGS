using Network_Analysis_and_LGS.AbstractLayer.Enums;
using Network_Analysis_and_LGS.AbstractLayer.Interfaces;
using Network_Analysis_and_LGS.ElectricalComponents.BasicComponents;
using Network_Analysis_and_LGS.ElectricalComponents.Validators;

namespace Network_Analysis_and_LGS.ElectricalComponents.Factory;

public class CircuitComponentFactory : ICircuitComponentFactory
{
    private readonly IValidator _validator;

    public IReadOnlyCollection<ComponentType> SupportedTypes => new[]
    {
        ComponentType.Resistor,
        ComponentType.Wire
    };

    public CircuitComponentFactory(IValidator validator)
    {
        _validator = validator;
    }

    public ICircuitComponent CreateComponent(ComponentType type, Dictionary<string, object> parameters)
    {
        return type switch
        {
            ComponentType.Resistor => CreateResistor(parameters),
            ComponentType.Wire => CreateWire(parameters),
            _ => throw new ArgumentException($"Unbekannter ComponentType: {type}")
        };
    }

    private ICircuitComponent CreateResistor(Dictionary<string, object> parameters)
    {
        if (parameters.TryGetValue("resistance", out var resistanceObj)
            && resistanceObj is double resistance)
        {
            return new Resistor(_validator, resistance);
        }

        throw new ArgumentException("Parameter 'resistance' erforderlich");
    }

    private ICircuitComponent CreateWire(Dictionary<string, object> parameters)
    {
        if (!parameters.TryGetValue("length", out var lengthObj)
            || !(lengthObj is double length))
            throw new ArgumentException("Parameter 'length' erforderlich");

        if (!parameters.TryGetValue("crossSectionArea", out var areaObj)
            || !(areaObj is double area))
            throw new ArgumentException("Parameter 'crossSectionArea' erforderlich");

        var resistivity = parameters.TryGetValue("resistivity", out var resistivityObj)
            && resistivityObj is double res
            ? res
            : 0.0175;

        return new Wire(length, area, resistivity);
    }
}