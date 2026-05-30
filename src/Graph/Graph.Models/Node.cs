namespace Network_Analysis_and_LGS.Graph.Models;

public class Node<T> : INode<T>
{
    public T? Value { get; set; }

    public Node(T? value)
    {
        Value = value;
    }

    public override bool Equals(object? obj)
    {
        return obj is Node<T> node && EqualityComparer<T>.Default.Equals(Value, node.Value);
    }

    public override int GetHashCode()
    {
        return EqualityComparer<T>.Default.GetHashCode(Value);
    }
}