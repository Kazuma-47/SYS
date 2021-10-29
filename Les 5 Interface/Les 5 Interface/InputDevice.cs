using System;
using System.Collections.Generic;
using System.Text;

namespace Les_5_Interface
{
    class InputDevice : IInputDevice
    {
        public float GetHorizontalAnalog()
        {
            return 1;
        }

        public bool IsDown(GameButton button)
        {
            return true;
        }
    }
}
