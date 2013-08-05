namespace AcmeCorp.Payments.MyPsp.EndPoint.Configuration
{
    using NServiceBus;

    public class UnobtrusiveConventionsConfiguration : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
                .DefiningCommandsAs(MessageTypeDefinition.IsCommand)
                .DefiningEventsAs(MessageTypeDefinition.IsEvent)
                .DefiningMessagesAs(MessageTypeDefinition.IsMessage);
        }
    }
}
