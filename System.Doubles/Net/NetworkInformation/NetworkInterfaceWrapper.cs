namespace System.Net.NetworkInformation
{
    public sealed class NetworkInterfaceWrapper : INetworkInterface
    {
        public bool GetIsNetworkAvailable() => NetworkInterface.GetIsNetworkAvailable();
    }
}
