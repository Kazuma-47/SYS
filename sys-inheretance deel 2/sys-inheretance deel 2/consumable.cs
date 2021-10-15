using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class consumable
    {
        public int health;
        public int mana;

        public virtual void use()
        {
            Console.WriteLine("item used!");
        }
    }
}
