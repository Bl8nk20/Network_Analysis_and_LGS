namespace Network_Analysis_and_LGS.Graph.Models;

public class Edge<T> : IEdge<T>
{
    public INode<T> NodeA { get; set; }
    public INode<T> NodeB { get; set; }

    public Edge(INode<T> nodeA, INode<T> nodeB)
    {
        NodeA = nodeA;
        NodeB = nodeB;
    }

    public override string ToString()
    {
        return $"Edge: between {NodeA} and {NodeB}";
    }
}