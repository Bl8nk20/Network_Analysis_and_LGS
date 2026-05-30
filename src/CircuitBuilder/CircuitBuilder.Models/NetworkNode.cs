namespace Network_Analysis_and_LGS.CircuitBuilder;

public class NetworkNode : INetworkNode
{
    public string ID { get; }
    public string NodeLabel { get;}

    public NetworkNode(string nodeLabel)
    {
        ID = Guid.NewGuid().ToString();
        NodeLabel = nodeLabel;
    }

    public override string ToString() => NodeLabel;
}