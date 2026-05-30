namespace Network_Analysis_and_LGS.Graph.Models;

public class Graph<T> : IGraph<T>
{
    public IReadOnlyCollection<INode<T>> Nodes { get; }
    public IReadOnlyCollection<IEdge<T>> Edges { get; }

    internal Graph(IReadOnlyCollection<INode<T>> nodes, IReadOnlyCollection<IEdge<T>> edges)
    {
        Nodes = nodes;
        Edges = edges;
    }

    public IEnumerable<INode<T>> GetNeighbors(INode<T> node)
    {
        return Edges
                .Where(e => e.NodeA.Equals(node))
                .Select(e => e.NodeB);
    }
}