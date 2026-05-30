namespace Network_Analysis_and_LGS.Graph.Models;

public interface IGraph<T>
{
    public IReadOnlyCollection<INode<T>> Nodes { get; }
    public IReadOnlyCollection<IEdge<T>> Edges { get; }

    public IEnumerable<INode<T>> GetNeighbors(INode<T> node);
}