using System;
using System.Collections.Generic;
using System.Text;

namespace Les_5_Interface
{
    class PlayerController : ICharacterController
    {
        public void Logic(IInputDevice input)
        {
            throw new NotImplementedException();
        }

        public void SetCharacter(ICharacter Character)
        {
            throw new NotImplementedException();
        }
    }
}
