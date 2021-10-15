using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    class armor : equipment
    {
        public override void equip()
        {
            base.equip();
            armor += 10;
            Console.WriteLine("armor is now: "+ armor);
        }
    }
}
