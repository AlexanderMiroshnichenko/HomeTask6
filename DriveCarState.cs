using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class DriveCarState : State
    {

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Сел за руль");
           
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Заглушил автомобиль, вышел из него");
           

        }
        
    }
}
