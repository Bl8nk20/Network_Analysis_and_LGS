using Network_Analysis_and_LGS.AbstractLayer.Enums;
namespace Network_Analysis_and_LGS.AbstractLayer.Interfaces;

/// <summary>
/// Interface für alle Komponenten in einem Circuit
/// ElectricalComponents implementiert dies
/// CircuitAnalysis benutzt nur dieses Interface
/// </summary>
public interface ICircuitComponent : IBaseComponent
{
    double GetResistance();
    ComponentType Type { get; }
}