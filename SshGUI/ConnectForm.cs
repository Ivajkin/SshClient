using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SshNet;
using System.Configuration;

namespace SshGUI
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
            hostnameOrIp.Text = Properties.Settings.Default.hostnameOrIp;
            username.Text = Properties.Settings.Default.username;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new SshClient(hostnameOrIp.Text, username.Text, password.Text))
                {
                    client.Connect();
                    this.Hide();
                    (new RemoteConsole(client)).ShowDialog();

                    Properties.Settings.Default.hostnameOrIp = hostnameOrIp.Text;
                    Properties.Settings.Default.username = username.Text;
                    Properties.Settings.Default.Save();

                    client.Disconnect();
                    this.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}