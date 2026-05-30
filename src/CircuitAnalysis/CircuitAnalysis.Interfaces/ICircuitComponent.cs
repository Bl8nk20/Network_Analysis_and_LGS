using Network_Analysis_and_LGS.AbstractLayer.Enums;
using Network_Analysis_and_LGS.AbstractLayer.Interfaces;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface ICircuitComponent : IBaseComponent
{
    public double GetResistance();
    
    public ComponentType Type { get; }
}