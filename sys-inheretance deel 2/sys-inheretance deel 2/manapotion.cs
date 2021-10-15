using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class manapotion : consumable
    {
        public override void use()
        {
            base.use();
            mana += 2;
            Console.WriteLine("Current mana is now: " + mana);
        }
    }
}
