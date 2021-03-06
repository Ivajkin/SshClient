﻿using SshNet.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet;
using SshNet.Messages.Transport;
using SshNet.Common;
using SshNet.Tests.Common;

namespace SshNet.Tests
{
    /// <summary>
    ///This is a test class for KeyExchangeDiffieHellmanGroupSha1Test and is intended
    ///to contain all KeyExchangeDiffieHellmanGroupSha1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class KeyExchangeDiffieHellmanGroupSha1Test : TestBase
    {
        internal virtual KeyExchangeDiffieHellmanGroupSha1 CreateKeyExchangeDiffieHellmanGroupSha1()
        {
            // TODO: Instantiate an appropriate concrete class.
            KeyExchangeDiffieHellmanGroupSha1 target = null;
            return target;
        }

        /// <summary>
        ///A test for Finish
        ///</summary>
        [TestMethod()]
        public void FinishTest()
        {
            KeyExchangeDiffieHellmanGroupSha1 target = CreateKeyExchangeDiffieHellmanGroupSha1(); // TODO: Initialize to an appropriate value
            target.Finish();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Start
        ///</summary>
        [TestMethod()]
        public void StartTest()
        {
            KeyExchangeDiffieHellmanGroupSha1 target = CreateKeyExchangeDiffieHellmanGroupSha1(); // TODO: Initialize to an appropriate value
            Session session = null; // TODO: Initialize to an appropriate value
            KeyExchangeInitMessage message = null; // TODO: Initialize to an appropriate value
            target.Start(session, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GroupPrime
        ///</summary>
        [TestMethod()]
        public void GroupPrimeTest()
        {
            KeyExchangeDiffieHellmanGroupSha1 target = CreateKeyExchangeDiffieHellmanGroupSha1(); // TODO: Initialize to an appropriate value
            BigInteger actual;
            actual = target.GroupPrime;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
