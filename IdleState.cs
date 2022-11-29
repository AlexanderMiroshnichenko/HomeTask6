using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class IdleState : State
    {
        public override void Enter()
        { 
            base.Enter();
            Console.WriteLine("Начал стоять");

        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Перестал стоять");

        }

       


    }
}
