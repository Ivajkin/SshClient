﻿using SshNet.Messages.Connection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Messages.Connection
{
    /// <summary>
    ///This is a test class for ChannelSuccessMessageTest and is intended
    ///to contain all ChannelSuccessMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ChannelSuccessMessageTest : TestBase
    {
        /// <summary>
        ///A test for ChannelSuccessMessage Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelSuccessMessageConstructorTest()
        {
            ChannelSuccessMessage target = new ChannelSuccessMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ChannelSuccessMessage Constructor
        ///</summary>
        [TestMethod()]
        public void ChannelSuccessMessageConstructorTest1()
        {
            uint localChannelNumber = 0; // TODO: Initialize to an appropriate value
            ChannelSuccessMessage target = new ChannelSuccessMessage(localChannelNumber);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}