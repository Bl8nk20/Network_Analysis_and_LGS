using Network_Analysis_and_LGS.AbstractLayer.Interfaces;
using Network_Analysis_and_LGS.AbstractLayer.Enums;

namespace Network_Analysis_and_LGS.CircuitAnalysis;

public interface ICircuitBuilder
{
    ICircuitBuilder AddNode(INetworkNode node);
    
    ICircuitBuilder AddComponent(INetworkNode nodeA, 
                                 INetworkNode nodeB, 
                                 ComponentType componentType, 
                                 Dictionary<string, object> parameters);

    ICircuitBuilder AddComponent(INetworkNode nodeA, 
                                 INetworkNode nodeB, 
                                 ICircuitComponent component);
    
    ICircuit Build();
}