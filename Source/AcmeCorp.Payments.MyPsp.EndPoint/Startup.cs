namespace AcmeCorp.Payments.MyPsp.EndPoint
{
    using System.Diagnostics.CodeAnalysis;

    using NServiceBus;

    [ExcludeFromCodeCoverage]
    public class Startup : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {
            // Set the subscriptions in configuration so that:
            // - Endpoint behaviour can be identified at run time by looking at the config (subscriptions in compiled code can't be looked at).
            // - An Endpoint can be scaled out (different instances of the same endpoint dealing with different message types).
        }

        public void Stop()
        {
            // Do not unsubscribe so that between deployments or when 
            // the service is stopped this service continues to receive 
            // messages from the publisher.
        }
    }
}
