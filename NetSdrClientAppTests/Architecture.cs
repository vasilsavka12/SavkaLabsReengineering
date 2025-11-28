using NetArchTest.Rules;
using NUnit.Framework;

namespace NetSdrClientAppTests
{
    public class Architecture
    {
        [Test]
        public void UI_InfrastructureTestOnDependency()
        {
            var assembly = typeof(NetSdrClientApp.NetSdrClient).Assembly;

            var result = Types.InAssembly(assembly)
                .That()
                .ResideInNamespace("NetSdrClientApp")
                .ShouldNot()
                .HaveDependencyOn("EchoTspServer")
                .GetResult();

            Assert.That(result.IsSuccessful, Is.True);

        }
    }
}