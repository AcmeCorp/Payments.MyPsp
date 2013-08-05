namespace AcmeCorp.Payments.MyPsp.EndPoint.Configuration
{
    using NServiceBus;

    public class UnobtrusiveConventionsConfiguration : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
                .DefiningCommandsAs(MessageType.IsCommand)
                .DefiningEventsAs(MessageType.IsEvent)
                .DefiningExpressMessagesAs(MessageType.IsMessage);
        }
    }
}
