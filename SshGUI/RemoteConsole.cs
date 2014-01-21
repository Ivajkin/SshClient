using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SshNet;

namespace SshGUI
{
    public partial class RemoteConsole : Form
    {
        private SshNet.SshClient client;

        public RemoteConsole(SshClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            SshCommand executed = client.RunCommand(runSshTextBox.Text);
            outputTextBox.Text += Environment.NewLine + executed.Result.Replace("\n", Environment.NewLine);
        }
    }
}
