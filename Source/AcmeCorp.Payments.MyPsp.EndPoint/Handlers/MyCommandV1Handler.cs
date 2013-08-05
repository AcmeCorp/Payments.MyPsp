namespace AcmeCorp.Payments.MyPsp.EndPoint.Handlers
{
    using Messages.Commands;
    using NServiceBus;

    public class MyCommandV1Handler : IHandleMessages<MyCommandV1>
    {
        public void Handle(MyCommandV1 message)
        {
            System.Console.WriteLine("Received command.");
        }
    }
}
