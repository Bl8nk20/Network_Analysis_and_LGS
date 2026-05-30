using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface ICircuit
{
    public IReadOnlyCollection<INode<INetworkNode>> Nodes { get; }
    public IReadOnlyCollection<IEdge<INetworkNode>> Edges { get; }

    public IEnumerable<INode<INetworkNode>> GetNeighbors(INetworkNode node);
    public IReadOnlyCollection<IEdge<INetworkNode>> GetComponentsBetween(INetworkNode nodeA,
                                                                         INetworkNode nodeB);

    public double GetEquivalentResistance(INetworkNode nodeA, 
                                          INetworkNode nodeB);
    public bool isSolveable();
}