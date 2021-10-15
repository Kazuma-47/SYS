using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class pickups
    {
        public int coins;
        public virtual void pickup()
    {
        Console.WriteLine("item found!");
    }
}
}
