﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SshNet.Common;
using SshNet.Tests.Common;
using SshNet.Tests.Properties;

namespace SshNet.Tests.Classes
{
    /// <summary>
    /// Implementation of the SSH File Transfer Protocol (SFTP) over SSH.
    /// </summary>
    public partial class SftpClientTest : TestBase
    {
        [TestMethod]
        [TestCategory("Sftp")]
        [ExpectedException(typeof(SftpPathNotFoundException))]
        public void Test_Sftp_ChangeDirectory_Root_Dont_Exists()
        {
            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();
                sftp.ChangeDirectory("/asdasd");
            }
        }

        [TestMethod]
        [TestCategory("Sftp")]
        [ExpectedException(typeof(SftpPathNotFoundException))]
        public void Test_Sftp_ChangeDirectory_Root_With_Slash_Dont_Exists()
        {
            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();
                sftp.ChangeDirectory("/asdasd/");
            }
        }

        [TestMethod]
        [TestCategory("Sftp")]
        [ExpectedException(typeof(SftpPathNotFoundException))]
        public void Test_Sftp_ChangeDirectory_Subfolder_Dont_Exists()
        {
            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();
                sftp.ChangeDirectory("/asdasd/sssddds");
            }
        }

        [TestMethod]
        [TestCategory("Sftp")]
        [ExpectedException(typeof(SftpPathNotFoundException))]
        public void Test_Sftp_ChangeDirectory_Subfolder_With_Slash_Dont_Exists()
        {
            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();
                sftp.ChangeDirectory("/asdasd/sssddds/");
            }
        }

        [TestMethod]
        [TestCategory("Sftp")]
        public void Test_Sftp_ChangeDirectory_Which_Exists()
        {
            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();
                sftp.ChangeDirectory("/usr");
                Assert.AreEqual("/usr", sftp.WorkingDirectory);
            }
        }

        [TestMethod]
        [TestCategory("Sftp")]
        public void Test_Sftp_ChangeDirectory_Which_Exists_With_Slash()
        {
            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();
                sftp.ChangeDirectory("/usr/");
                Assert.AreEqual("/usr", sftp.WorkingDirectory);
            }
        }
    }
}