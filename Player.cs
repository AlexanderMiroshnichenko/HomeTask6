using System;

namespace HomeTask6
{
    class Player

       
    {



        public static StateMachine brain;

        

        static void Main(string[] args)
        {
            brain = new StateMachine();
            brain.Initialize(new StudyInXLabState());


            
          if(brain.CurrentState.ToString()== new StudyInXLabState().ToString())
            {
                brain.ChangeState(new DriveCarState());
            }
            if (brain.CurrentState.ToString() == new DriveCarState().ToString())
            {
                brain.ChangeState(new DoHomeTaskState());
            }
            if (brain.CurrentState.ToString() == new DoHomeTaskState().ToString())
            {
                brain.ChangeState(new DriveCarState());
            }
            if (brain.CurrentState.ToString() == new DriveCarState().ToString())
            {
                brain.ChangeState(new StudyInXLabState());
            }



           













        }
    }
}
