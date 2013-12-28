using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace action
{
    public abstract class Handle
    {
        public void _pushActionList(
            ActionList nActionList) {
            lock (mSyncObject) {
                mActionLists.Enqueue(nActionList);
            }
        }

        public void _runHandle() {
            ActionList actionList = null;
            lock (mSyncObject)
            {
                actionList =
                    mActionLists.Dequeue();
            }
            actionList._runActionMessage();
        }

        public Handle() {
            mActionLists =
                new Queue<ActionList>();
        }

        Queue<ActionList> mActionLists;
        readonly object mSyncObject = new object();
    }
}
