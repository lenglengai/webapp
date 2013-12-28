using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace action
{
    public class ActionMgr
    {
        public void _pushActionMessage(
            ActionMessage nActionMessage) {
            mActionMessages.Add(nActionMessage);
        }

        public void _runActionMessage() {
            foreach (ActionMessage i
                in mActionMessages) {
            }
        }

        public ActionMgr() {
            mActionMessages
                = new List<ActionMessage>();
        }

        List<ActionMessage> mActionMessages;
    }
}
