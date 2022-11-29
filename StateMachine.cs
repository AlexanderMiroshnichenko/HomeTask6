using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class StateMachine
    {
        public State CurrentState { get; set; }

        public void Initialize(State startState)
        {
            CurrentState = startState;
            CurrentState.Enter();
        }

        public void ChangeState(State newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            CurrentState.Enter();


        }
        



    }
}
