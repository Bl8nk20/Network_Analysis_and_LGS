using Network_Analysis_and_LGS.AbstractLayer.Interfaces;

namespace Network_Analysis_and_LGS.CircuitAnalysis;

/// <summary>
/// Netzwerk-Knoten (Verbindungspunkte)
/// </summary>
public interface INetworkNode : IBaseComponent
{
    string NodeLabel { get; }
}