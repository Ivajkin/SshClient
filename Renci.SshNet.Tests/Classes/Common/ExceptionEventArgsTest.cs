﻿using SshNet.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SshNet.Tests.Common;

namespace SshNet.Tests.Classes.Common
{
    /// <summary>
    ///This is a test class for ExceptionEventArgsTest and is intended
    ///to contain all ExceptionEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExceptionEventArgsTest : TestBase
    {
        /// <summary>
        ///A test for ExceptionEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void ExceptionEventArgsConstructorTest()
        {
            Exception exception = null; // TODO: Initialize to an appropriate value
            ExceptionEventArgs target = new ExceptionEventArgs(exception);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
