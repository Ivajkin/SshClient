﻿using SshNet.Messages.Transport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Messages.Transport
{
    /// <summary>
    ///This is a test class for DebugMessageTest and is intended
    ///to contain all DebugMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DebugMessageTest : TestBase
    {
        /// <summary>
        ///A test for DebugMessage Constructor
        ///</summary>
        [TestMethod()]
        public void DebugMessageConstructorTest()
        {
            DebugMessage target = new DebugMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}