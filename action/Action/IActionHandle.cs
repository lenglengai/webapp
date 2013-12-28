using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace action
{
    public interface IActionHandle
    {
        void _runActionMessage(
            ActionMessage nActionMessage);

        ulong _getId();
    }
}
