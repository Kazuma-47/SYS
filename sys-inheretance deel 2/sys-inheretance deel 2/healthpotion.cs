using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class healthpotion :consumable
    {
        public override void use()
        {
            base.use();
            health += 2;
            Console.WriteLine("Current Health is now: "+ health);
        }
    }
}
