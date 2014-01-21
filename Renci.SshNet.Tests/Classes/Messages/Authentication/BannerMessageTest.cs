using SshNet.Messages.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Messages.Authentication
{   
    /// <summary>
    ///This is a test class for BannerMessageTest and is intended
    ///to contain all BannerMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BannerMessageTest : TestBase
    {
        /// <summary>
        ///A test for BannerMessage Constructor
        ///</summary>
        [TestMethod()]
        public void BannerMessageConstructorTest()
        {
            BannerMessage target = new BannerMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
