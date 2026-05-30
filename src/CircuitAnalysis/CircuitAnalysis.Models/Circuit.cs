using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitAnalysis;

public class Circuit : ICircuit
{
    private readonly IGraph<INetworkNode> _graph;

    public IReadOnlyCollection<INode<INetworkNode>> Nodes => _graph.Nodes;
    public IReadOnlyCollection<IEdge<INetworkNode>> Edges => _graph.Edges;

    public Circuit(IGraph<INetworkNode> graph)
    {
        _graph = graph;
    }

    /// <summary>
    /// Gibt alle Komponenten zwischen zwei Knoten zurück (für Parallelschaltung)
    /// </summary>
    public IReadOnlyCollection<IEdge<INetworkNode>> GetComponentsBetween(
        INetworkNode nodeA, 
        INetworkNode nodeB)
    {
        var node1 = Nodes.FirstOrDefault(n => n.Value.Equals(nodeA));
        var node2 = Nodes.FirstOrDefault(n => n.Value.Equals(nodeB));

        if (node1 == null || node2 == null)
            return new List<IEdge<INetworkNode>>();

        return Edges
            .Where(e => (e.NodeA.Equals(node1) && e.NodeB.Equals(node2)) ||
                        (e.NodeA.Equals(node2) && e.NodeB.Equals(node1)))
            .ToList();
    }

    /// <summary>
    /// Berechnet den äquivalenten Widerstand zwischen zwei Knoten
    /// </summary>
    public double GetEquivalentResistance(INetworkNode nodeA, INetworkNode nodeB)
    {
        var components = GetComponentsBetween(nodeA, nodeB);

        if (components.Count == 0) return 0;
        if (components.Count == 1) return components.First().Component?.GetResistance() ?? 0;

        // Parallelschaltung: 1/R_eq = 1/R1 + 1/R2 + ...
        var reciprocalSum = components
            .Where(e => e.Component != null)
            .Sum(e => 1.0 / e.Component!.GetResistance());

        return reciprocalSum > 0 ? 1.0 / reciprocalSum : 0;
    }
}