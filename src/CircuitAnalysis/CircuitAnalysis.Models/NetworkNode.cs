namespace Network_Analysis_and_LGS.CircuitAnalysis;

public class NetworkNode : INetworkNode
{
    public string ID { get; }
    public string NodeLabel { get; }

    public NetworkNode(string label)
    {
        NodeLabel = label;
        ID = Guid.NewGuid().ToString();
    }

    public override string ToString() => NodeLabel;
}