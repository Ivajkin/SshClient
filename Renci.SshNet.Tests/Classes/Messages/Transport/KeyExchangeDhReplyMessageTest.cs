﻿using SshNet.Messages.Transport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Messages.Transport
{
    /// <summary>
    ///This is a test class for KeyExchangeDhReplyMessageTest and is intended
    ///to contain all KeyExchangeDhReplyMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KeyExchangeDhReplyMessageTest : TestBase
    {
        /// <summary>
        ///A test for KeyExchangeDhReplyMessage Constructor
        ///</summary>
        [TestMethod()]
        public void KeyExchangeDhReplyMessageConstructorTest()
        {
            KeyExchangeDhReplyMessage target = new KeyExchangeDhReplyMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
