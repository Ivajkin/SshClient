﻿using SshNet.Messages.Transport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Messages.Transport
{
    /// <summary>
    ///This is a test class for KeyExchangeDhGroupExchangeGroupTest and is intended
    ///to contain all KeyExchangeDhGroupExchangeGroupTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KeyExchangeDhGroupExchangeGroupTest : TestBase
    {
        /// <summary>
        ///A test for KeyExchangeDhGroupExchangeGroup Constructor
        ///</summary>
        [TestMethod()]
        public void KeyExchangeDhGroupExchangeGroupConstructorTest()
        {
            KeyExchangeDhGroupExchangeGroup target = new KeyExchangeDhGroupExchangeGroup();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
