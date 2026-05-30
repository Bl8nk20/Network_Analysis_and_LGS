using Network_Analysis_and_LGS.AbstractLayer.Enums;

namespace Network_Analysis_and_LGS.AbstractLayer.Interfaces;

/// <summary>
/// Factory für Komponenten-Erstellung
/// Abhängigkeit: ElectricalComponents → Abstractions (unidirektional!)
/// </summary>
public interface ICircuitComponentFactory
{
    ICircuitComponent CreateComponent(ComponentType type, Dictionary<string, object> parameters);
    IReadOnlyCollection<ComponentType> SupportedTypes { get; }
}