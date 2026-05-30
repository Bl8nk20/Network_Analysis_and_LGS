using Network_Analysis_and_LGS.AbstractLayer.Interfaces;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.Graph;

public class GraphBuilder<T> : IGraphBuilder<T>
{
    private readonly Dictionary<T, Node<T>> _nodes = new();
    private readonly List<Edge<T>> _edges = new();

    public Node<T> AddNode(T value)
    {
        if (!_nodes.TryGetValue(value, out var node))
        {
            node = new Node<T>(value);
            _nodes.Add(value, node);
        }
        return node;
    }

    public IGraphBuilder<T> AddEdge(T valueA, T valueB)
    {
        var nodeA = AddNode(valueA);
        var nodeB = AddNode(valueB);

        _edges.Add(new Edge<T>(nodeA, nodeB));

        return this;
    }

    public IGraphBuilder<T> AddEdge(T valueA, T valueB, ICircuitComponent component)
    {
        var nodeA = AddNode(valueA);
        var nodeB = AddNode(valueB);

        _edges.Add(new Edge<T>(nodeA, nodeB, component));

        return this;
    }

    public IGraph<T> Build()
    {
        return new Graph<T>(_nodes.Values.ToList(), _edges.ToList());
    }
}