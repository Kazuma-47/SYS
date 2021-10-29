using System;

namespace Les_5_Interface
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PlayerController playerController = new PlayerController();
            CPUController CPUcontroller = new CPUController();
            InputDevice input = new InputDevice();

            playerController.Logic(input);
            CPUcontroller.Logic(input);
        }
    }
}
