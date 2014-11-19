namespace ProxyModule
{
    public class UrlItem
    {
        public UrlItem()
        {
        }

        public UrlItem(string pathAndQueryPrefix = "/", string hostName = "localhost", int port = 80,
            string scheme = "http")
        {
            HostName = hostName;
            Match = pathAndQueryPrefix;
            Port = port;
            Scheme = scheme;
        }

        public string HostName { set; get; }

        public string Match { set; get; }

        public int Port { set; get; }

        public string Scheme { set; get; }
    }
}