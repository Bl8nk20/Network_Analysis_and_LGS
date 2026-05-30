using Network_Analysis_and_LGS.ElectricalComponents.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface INetworkNode : IBaseComponent
{
    public string NodeLabel { get; }
}