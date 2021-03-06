﻿using System;
using SshNet.Messages.Connection;

namespace SshNet.Common
{
    /// <summary>
    /// Provides data for <see cref="SshNet.Channels.Channel.RequestReceived"/> event.
    /// </summary>
    internal class ChannelRequestEventArgs : EventArgs
    {
        /// <summary>
        /// Gets request information.
        /// </summary>
        public RequestInfo Info { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelRequestEventArgs"/> class.
        /// </summary>
        /// <param name="info">Request information.</param>
        public ChannelRequestEventArgs(RequestInfo info)
        {
            this.Info = info;
        }
    }
}
