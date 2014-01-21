﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SshNet.Messages;
using SshNet.Messages.Authentication;
using SshNet.Common;
using System.Threading.Tasks;

namespace SshNet
{
    public partial  class KeyboardInteractiveAuthenticationMethod : AuthenticationMethod
    {
        /// <exception cref="ArgumentNullException"><paramref name="action"/> is null.</exception>
        partial void ExecuteThread(Action action)
        {
            ThreadPool.QueueUserWorkItem((o) => { action(); });
        }
    }
}
