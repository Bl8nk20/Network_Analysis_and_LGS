using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitAnalysis;

public interface ICircuit
{
    IReadOnlyCollection<INode<INetworkNode>> Nodes { get; }

    IReadOnlyCollection<IEdge<INetworkNode>> Edges { get; }
    
    double GetEquivalentResistance(INetworkNode nodeA,
                                   INetworkNode nodeB);
    
    IReadOnlyCollection<IEdge<INetworkNode>> GetComponentsBetween(INetworkNode nodeA,
                                                                  INetworkNode nodeB);
}