using EchoTspServer;

namespace NetSdrClientApp
{
    public class DirectDependencyImplementation
    {
        public void CreateServer()
        {
            var server = new EchoServer(5000);
        }
    }
}