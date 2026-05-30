namespace Network_Analysis_and_LGS.Graph.Models;

public interface INode<T>
{
    public T Value { get; }
    public bool Equals(object? obj);
    public int GetHashCode();
}