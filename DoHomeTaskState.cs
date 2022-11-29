using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class DoHomeTaskState : State
    {
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Сел делать дз");
          
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Перестал делать дз");
           


        }

    }
}
