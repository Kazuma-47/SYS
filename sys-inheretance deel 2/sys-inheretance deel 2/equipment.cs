using System;
using System.Collections.Generic;
using System.Text;

namespace sys_inheretance_deel_2
{
    abstract class equipment
    {
        public int armor;
        public int attack;
        public virtual void equip()
        {
            Console.WriteLine("item equiped!");
        }


    }
}
