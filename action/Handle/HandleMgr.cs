using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace action
{
    public abstract class HandleMgr
    {
        public _HandleSlot m_tRegisterHandle;
        public void _registerHandle(Handle nHandle) {
            if (null != m_tRegisterHandle) {
                this.m_tRegisterHandle(nHandle);
            }
        }

        public abstract ulong _getId();

        public HandleMgr() {
            m_tRegisterHandle = null;
        }
    }
}
