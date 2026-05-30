using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.ElectricalComponents.Enums;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface ICircuitComponent : IBaseComponent
{
    public string Name { get; }
    public ComponentType Type { get; }
}