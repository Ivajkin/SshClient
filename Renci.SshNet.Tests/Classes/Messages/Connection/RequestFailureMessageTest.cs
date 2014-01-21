﻿using SshNet.Messages.Connection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Messages.Connection
{
    /// <summary>
    ///This is a test class for RequestFailureMessageTest and is intended
    ///to contain all RequestFailureMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RequestFailureMessageTest : TestBase
    {
        /// <summary>
        ///A test for RequestFailureMessage Constructor
        ///</summary>
        [TestMethod()]
        public void RequestFailureMessageConstructorTest()
        {
            RequestFailureMessage target = new RequestFailureMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
