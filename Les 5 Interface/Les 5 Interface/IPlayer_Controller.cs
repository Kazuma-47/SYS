using System;
using System.Collections.Generic;
using System.Text;

namespace Les_5_Interface
{
    public interface ICharacterController 
    {
        public void SetCharacter(ICharacter Character);


        public void Logic(IInputDevice input);

    }
}
