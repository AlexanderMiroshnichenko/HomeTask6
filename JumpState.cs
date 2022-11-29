using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class JumpState : State
    {

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Начал прыгать");

        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Перестал прыгать");

        }

       

    }
}
