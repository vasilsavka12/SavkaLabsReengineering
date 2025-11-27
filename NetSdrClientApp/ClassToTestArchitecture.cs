using EchoTspServer;

namespace NetSdrClientApp
{
    public class ClassToTestArchitecture
    {
        public void CreateServer()
        {
            var server = new EchoServer(5000);
        }
    }
}