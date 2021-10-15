using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class weapon : equipment
    {
        public override void equip()
        {
            base.equip();
            attack += 10;
            Console.WriteLine("damage is now: "+ attack);
        }
    }
}
