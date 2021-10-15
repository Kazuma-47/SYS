using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class money :pickups
    {
        public int coinvalue = 1;
        public override void pickup()
        {
            base.pickup();
            int NewValue = coins + coinvalue;
            coins = NewValue;
            Console.WriteLine("Coins are now:"+coins );
        }
    }
}
