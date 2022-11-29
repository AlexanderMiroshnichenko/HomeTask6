using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class StudyInXLabState : State
    {
        
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Начал учиться");
           
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Перестал учиться");
            
            
            

        }
    }
}
