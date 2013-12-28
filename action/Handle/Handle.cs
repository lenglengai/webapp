using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace action
{
    public abstract class Handle
    {
        public void _pushActionList(
            ActionMgr nActionMgr)
        {
            lock (mSyncObject) {
                mActionMgrs.Enqueue(nActionMgr);
            }
        }

        public void _runHandle() {
            ActionMgr actionMgr = null;
            lock (mSyncObject)
            {
                actionMgr =
                    mActionMgrs.Dequeue();
            }
            actionMgr._runActionMessage();
        }

        public Handle() {
            mActionMgrs =
                new Queue<ActionMgr>();
        }

        Queue<ActionMgr> mActionMgrs;
        readonly object mSyncObject =
            new object();
    }
}
