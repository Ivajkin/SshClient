using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SshNet.Common;
using SshNet.Messages.Authentication;
using SshNet.Messages;
using System.Threading.Tasks;

namespace SshNet
{
    public partial class PasswordAuthenticationMethod : AuthenticationMethod
    {
        /// <exception cref="ArgumentNullException"><paramref name="action"/> is null.</exception>
        partial void ExecuteThread(Action action)
        {
            ThreadPool.QueueUserWorkItem((o) => { action(); });
        }
    }
}
