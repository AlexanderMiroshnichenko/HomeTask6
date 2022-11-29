using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class RunState :State
    {
        public override void Enter()
        {
           
            base.Enter();
            Console.WriteLine("Начал бежать");
           
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Перестал бежать");
            
        }

        
    }
}
