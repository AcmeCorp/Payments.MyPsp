namespace AcmeCorp.Payments.MyPsp.EndPoint.Configuration
{
    using System.Diagnostics.CodeAnalysis;

    using NServiceBus;

    public class SerializationConfiguration : IWantToRunBeforeConfiguration
    {
        [ExcludeFromCodeCoverage]
        public void Init()
        {
            Configure
                .Serialization
                .Xml();
        }
    }
}
