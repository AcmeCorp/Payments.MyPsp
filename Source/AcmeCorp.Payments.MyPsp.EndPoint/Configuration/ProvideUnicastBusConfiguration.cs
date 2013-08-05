namespace AcmeCorp.Payments.MyPsp.EndPoint.Configuration
{
    using System.Diagnostics.CodeAnalysis;

    using NServiceBus.Config;
    using NServiceBus.Config.ConfigurationSource;

    public class ProvideUnicastBusConfiguration : IProvideConfiguration<UnicastBusConfig>
    {
        [ExcludeFromCodeCoverage]
        public UnicastBusConfig GetConfiguration()
        {
            return new UnicastBusConfig
            {
                MessageEndpointMappings = new MessageEndpointMappingCollection
                {
                    new MessageEndpointMapping { Messages = "AcmeCorp.Payments.MyPsp.EndPoint", Endpoint = "someserviceinputqueue" }
                }
            };
        }
    }
}
