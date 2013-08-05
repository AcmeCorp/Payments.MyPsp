﻿namespace AcmeCorp.Payments.MyPsp.EndPoint.Tests.Configuration
{
    using EndPoint.Configuration;

    using Messages.Commands;
    using Messages.Events;
    using Messages.Timeouts;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MessageTypeTests
    {
        [TestMethod]
        public void Test_That_Message_Is_Command()
        {
            bool isCommand1 = MessageType.IsCommand(typeof(MyCommandV1));
            Assert.IsTrue(isCommand1);
            bool isCommand2 = MessageType.IsCommand(typeof(MyEventV1));
            Assert.IsFalse(isCommand2);
            bool isCommand3 = MessageType.IsCommand(typeof(MyTimeoutV1));
            Assert.IsFalse(isCommand3);
        }

        [TestMethod]
        public void Test_That_Message_Is_Event()
        {
            bool isEvent1 = MessageType.IsEvent(typeof(MyCommandV1));
            Assert.IsFalse(isEvent1);
            bool isEvent2 = MessageType.IsEvent(typeof(MyEventV1));
            Assert.IsTrue(isEvent2);
            bool isEvent3 = MessageType.IsEvent(typeof(MyTimeoutV1));
            Assert.IsFalse(isEvent3);
        }

        [TestMethod]
        public void Test_That_Message_Is_Message()
        {
            bool isMessage1 = MessageType.IsMessage(typeof(MyCommandV1));
            Assert.IsTrue(isMessage1);
            bool isMessage2 = MessageType.IsMessage(typeof(MyEventV1));
            Assert.IsTrue(isMessage2);
            bool isMessage3 = MessageType.IsMessage(typeof(MyTimeoutV1));
            Assert.IsTrue(isMessage3);
        }

        [TestMethod]
        public void Test_That_Message_Is_Timeout()
        {
            bool isTimeout1 = MessageType.IsTimeout(typeof(MyCommandV1));
            Assert.IsFalse(isTimeout1);
            bool isTimeout2 = MessageType.IsTimeout(typeof(MyEventV1));
            Assert.IsFalse(isTimeout2);
            bool isTimeout3 = MessageType.IsTimeout(typeof(MyTimeoutV1));
            Assert.IsTrue(isTimeout3);
        }
    }
}
