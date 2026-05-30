using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public class Circuit : ICircuit
{
    public IReadOnlyCollection<INode<INetworkNode>> Nodes => _circuitGraph.Nodes;
    public IReadOnlyCollection<IEdge<INetworkNode>> Edges => _circuitGraph.Edges;
    private readonly IGraph<INetworkNode> _circuitGraph;

    public Circuit(IGraph<INetworkNode> circuitGraph)
    {
        _circuitGraph = circuitGraph;
    }
    public IEnumerable<INode<INetworkNode>> GetNeighbors(INetworkNode node){
        var nodeObj = Nodes.FirstOrDefault(n => n.Value.Equals(node.Value));
        if (nodeObj == null)
        {
            throw new ArgumentException($"Node {node.Value} does not exist in the circuit.");
        }
        return _circuitGraph.GetNeighbors(node);
    }
    
    public IReadOnlyCollection<IEdge<INetworkNode>> GetComponentsBetween(INetworkNode nodeA,
                                                                         INetworkNode nodeB){
        
        var node1 = Nodes.FirstOrDefault(n => n.Value.Equals(nodeA));
        var node2 = Nodes.FirstOrDefault(n => n.Value.Equals(nodeB));

        if (node1 == null || node2 == null)
        {
            return new List<IEdge<INetworkNode>>();
        }

        return Edges
                .Where(e => (e.Source.Equals(node1) && e.Target.Equals(node2)) ||
                            (e.Source.Equals(node2) && e.Target.Equals(node1)))
                .ToList();

    }

    public double GetEquivalentResistance(INetworkNode nodeA, 
                                          INetworkNode nodeB){
        var components = GetComponentsBetween(nodeA, nodeB);

        if (components.Count == 0)
        {
            return 0;
        }
        if (components.Count == 1)
        {
          return components.First().Value?.GetResistance() ?? 0;
        }

        var sum = components
                    .Where(e => e.Value != null)
                    .Sum(e => 1.0 / e.Value.GetResistance());

        return sum > 0 ? 1.0/sum : 0;
    }
    
    public bool isSolveable()
    {
        // Implement logic to determine if the circuit is solvable
        throw new NotImplementedException();
    }
}