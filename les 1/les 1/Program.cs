using System;
using System.Threading;

namespace les_1
{
    class Program
    {


        static void Main(string[] args)
        {
            //  int Dot = 0;
            //  int enemyHealth = 10;
            enemy enemy = new enemy();
            enemy.Health = 10;
            MoveSets moveSets = new MoveSets();
            string choice;
            

              while (enemy.Health > 0)
            {
                // Console.Clear();
                // enemy.Health--;
                Console.WriteLine("enemy health remaining: " + enemy.Health);               
                Console.WriteLine("Pick a move \nA. Kick \nB. Punch\nC. Throw Item");
                choice = Console.ReadLine();
                int damage =moveSets.Move(choice);
                enemy.Health -= damage;

                // Thread.Sleep(1000);
            }



        }    
    }
    public class enemy 
    {
        public int Health;
    }
}
