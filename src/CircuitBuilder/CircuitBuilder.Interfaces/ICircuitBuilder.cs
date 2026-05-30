using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface ICircuitBuilder
{
    ICircuitBuilder AddNode(INetworkNode node);

    ICircuitBuilder AddComponent(ICircuitComponent component, 
                                 INetworkNode node1, 
                                 INetworkNode node2);

    ICircuit Build();
}