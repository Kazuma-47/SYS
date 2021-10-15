using System;

namespace sys_inheretance_deel_2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            weapon weapon = new weapon();
            armor armor = new armor();
            money money = new money();
            healthpotion healthpotion = new healthpotion();
            manapotion manapotion = new manapotion();



            action();

            void action()
            {
                Console.WriteLine("what item do you want to use?");
                string answer = Console.ReadLine();
                if (answer == "potion")
                {
                    healthpotion.use();
                    action();
                }
                else if (answer == "weapon")
                {
                    if(weapon.attack == 20)
                    {
                        Console.WriteLine("you have 3 hands??");
                        action();
                    }
                    weapon.equip();
                    action();
                }
                else if (answer == "armor")
                {
                    if (armor.armor == 10)
                    {
                        Console.WriteLine("you can't wear armor on armor right?");
                        action();
                    }
                    armor.equip();
                    action();
                }
                else if (answer == "mana potion")
                {
                    manapotion.use();
                    action();
                }
                else if (answer == "look around")
                {
                    money.pickup();
                    action();
                }
            }
            
        }
    }
}
