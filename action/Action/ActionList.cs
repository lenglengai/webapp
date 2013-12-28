using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace action
{
    public class ActionList
    {
        public void _pushActionMessage(
            ActionMessage nActionMessage)
        {
            mActionMessages.Add(nActionMessage);
        }

        public void _runActionMessage() {
            foreach (ActionMessage i in mActionMessages) {
            }
        }

        public ActionList() {
            mActionMessages
                = new List<ActionMessage>();
        }

        List<ActionMessage> mActionMessages;
    }
}
