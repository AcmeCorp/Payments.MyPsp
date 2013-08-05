namespace AcmeCorp.Payments.MyPsp.EndPoint
{
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using Messages.Events;
    using NServiceBus;

    /*
        This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
        can be found here: http://particular.net/articles/the-nservicebus-host
    */
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization, UsingTransport<AzureServiceBus>
    {
        [ExcludeFromCodeCoverage]
        public void Init()
        {
            Configure
                .With(GetMessageAssemblies())
                .UnicastBus();
        }

        internal static Assembly[] GetMessageAssemblies()
        {
            return new[] { typeof(EndpointConfig).Assembly, typeof(MyEventV1).Assembly };
        }
    }
}