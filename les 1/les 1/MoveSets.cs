using System;
using System.Collections.Generic;
using System.Text;

namespace les_1
{
    class MoveSets
    {
        int damage;
        
        public int Move(string move)
        {
            
            switch (move)
            {
                case "A":
                    damage = 1;
                    break;
                case "B":
                    damage =2;
                    break;
                case "C":
                    damage =3;
                    break;
                default:
                    Console.WriteLine("Wrong answer");
                    break;
                    
            }            
                
            return damage;
      
        }
    }
}
