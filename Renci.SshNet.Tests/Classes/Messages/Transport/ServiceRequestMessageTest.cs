﻿using SshNet.Messages.Transport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Messages;

namespace SshNet.Tests.Classes.Messages.Transport
{
    /// <summary>
    ///This is a test class for ServiceRequestMessageTest and is intended
    ///to contain all ServiceRequestMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ServiceRequestMessageTest
    {
        /// <summary>
        ///A test for ServiceRequestMessage Constructor
        ///</summary>
        [TestMethod()]
        public void ServiceRequestMessageConstructorTest()
        {
            ServiceName serviceName = new ServiceName(); // TODO: Initialize to an appropriate value
            ServiceRequestMessage target = new ServiceRequestMessage(serviceName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
