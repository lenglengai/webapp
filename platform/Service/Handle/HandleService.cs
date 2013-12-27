using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace platform
{
    public class HandleService
    {
        public void _register(IHandle nHandle) {
            ThreadPool.QueueUserWorkItem(
                new WaitCallback(_runHandle), nHandle);
        }

        public void _runStart() {

        }

        static void _runHandle(object nHandle) {
            IHandle handle_ = (IHandle)nHandle;
            handle_._runHandle();
        }
    }
}
