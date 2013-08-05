namespace AcmeCorp.Payments.MyPsp.EndPoint.Tests.Handlers
{
    using System.Reflection;

    using EndPoint.Configuration;
    using EndPoint.Handlers;

    using Messages.Commands;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NServiceBus;
    using NServiceBus.Testing;

    [TestClass]
    public class MyCommandV1HandlerTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            MessageConventionExtensions.IsMessageTypeAction = MessageType.IsMessage();
            Assembly[] messageAssemblies = EndpointConfig.GetMessageAssemblies();
            Test.Initialize(messageAssemblies);
        }

        [TestMethod]
        public void Test_That_Message_Is_Handled()
        {
            // Arrange
            MyCommandV1 myCommandV1 = new MyCommandV1();

            // Act
            Test.Handler<MyCommandV1Handler>()
                .OnMessage(myCommandV1);
        
            // Assert
            // No asserts to make.
        }
    }
}
