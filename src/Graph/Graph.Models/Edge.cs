namespace Network_Analysis_and_LGS.Graph.Models;

public class Edge<T> : IEdge<T>
{
    public INode<T> NodeA { get; set; }
    public INode<T> NodeB { get; set; }
    public T? Value { get; set;}

    public Edge(INode<T> nodeA, INode<T> nodeB)
    {
        NodeA = nodeA;
        NodeB = nodeB;
    }

    public Edge(INode<T> nodeA, INode<T> nodeB, T? value)
    {
        NodeA = nodeA;
        NodeB = nodeB;
        Value = value;
    }

    public override string ToString()
    {
        var componentInfo = Value != null 
            ? $" [{Value}]" 
            : "";
        return $"Edge: between {NodeA} and {NodeB}{componentInfo}";
    }
}