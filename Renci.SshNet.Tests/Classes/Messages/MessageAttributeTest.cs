﻿using SshNet.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Messages
{
    /// <summary>
    ///This is a test class for MessageAttributeTest and is intended
    ///to contain all MessageAttributeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MessageAttributeTest : TestBase
    {
        /// <summary>
        ///A test for MessageAttribute Constructor
        ///</summary>
        [TestMethod()]
        public void MessageAttributeConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            byte number = 0; // TODO: Initialize to an appropriate value
            MessageAttribute target = new MessageAttribute(name, number);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            byte number = 0; // TODO: Initialize to an appropriate value
            MessageAttribute target = new MessageAttribute(name, number); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Number
        ///</summary>
        [TestMethod()]
        public void NumberTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            byte number = 0; // TODO: Initialize to an appropriate value
            MessageAttribute target = new MessageAttribute(name, number); // TODO: Initialize to an appropriate value
            byte expected = 0; // TODO: Initialize to an appropriate value
            byte actual;
            target.Number = expected;
            actual = target.Number;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
