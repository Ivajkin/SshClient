using SshNet.Messages.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Messages.Authentication
{   
    /// <summary>
    ///This is a test class for SuccessMessageTest and is intended
    ///to contain all SuccessMessageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SuccessMessageTest : TestBase
    {
        /// <summary>
        ///A test for SuccessMessage Constructor
        ///</summary>
        [TestMethod()]
        public void SuccessMessageConstructorTest()
        {
            SuccessMessage target = new SuccessMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
