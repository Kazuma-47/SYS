using System;

namespace Les_5_Interface
{
    public class CPUController : ICharacterController
    {
        public void SetCharacter(ICharacter Character)
        {

        }
        public void Logic(IInputDevice input)
        {
            Random rnd = new Random();
            int next_move = rnd.Next(1, 3);
            switch (next_move)
            {
                case 1:
                    Console.WriteLine("CPU does basic attack");
                    break;
                case 2:
                    Console.WriteLine("CPU does heavy attack");
                    break;
                case 3:
                    Console.WriteLine("CPU does special attack");
                    break;
            }
        }
    }
}

