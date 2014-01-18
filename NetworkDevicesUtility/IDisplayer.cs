using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkDevicesUtility
{
    interface IDisplayer<T>
    {
        void DisplayMessage(string Message);
        T DisplayAndReturnMessage(string Message);
    }
}
