﻿namespace AcmeCorp.Payments.MyPsp.EndPoint.Configuration
{
    using System;

    internal static class MessageTypeDefinition
    {
        public static Func<Type, bool> IsMessage()
        {
            return IsMessage;
        }

        public static bool IsCommand(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            return
                type.Namespace != null &&
                type.Namespace.Contains(".Commands") &&
                !type.Namespace.StartsWith("NServiceBus", StringComparison.CurrentCulture);
        }

        public static bool IsEvent(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            return
                type.Namespace != null &&
                (type.Namespace.Contains(".Contracts") || type.Namespace.Contains(".Events")) &&
                !type.Namespace.StartsWith("NServiceBus", StringComparison.CurrentCulture);
        }

        public static bool IsTimeout(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            return
                type.Namespace != null &&
                type.Namespace.Contains(".Timeouts") &&
                !type.Namespace.StartsWith("NServiceBus", StringComparison.CurrentCulture);
        }

        public static bool IsMessage(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            return IsCommand(type) || IsEvent(type) || IsTimeout(type);
        }
    }
}
