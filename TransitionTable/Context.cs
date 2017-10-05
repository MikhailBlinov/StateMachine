using System.Collections.Generic;
using System.Linq;
using TransitionTable.EnumDefinitions;

namespace TransitionTable
{
     class Context
    {
        public List<Transition> Transitions { get; set; }
         public State TransitionState { get; set; }

         public Context(State transitionState)
         {
             TransitionState = transitionState;
            Transitions = new List<Transition>();
         }

         public void ProcessEvents(Event mEvent)
         {
             Transition transition = Transitions.SingleOrDefault(x => ((x.BeginState == TransitionState) && (x.TransitionEvent == mEvent)));

             if (transition != null)
             {
                 TransitionState = transition.EndState;
                 transition.TransitionAction();
             }

             /*
            foreach (Transition  transition  in Transitions)
            {
                if ((transition.BeginState == TransitionState) && (transition.TransitionEvent == mEvent))
                {
                    TransitionState = transition.EndState;
                    transition.TransitionAction();
                    break;
                }
            }*/

        }

    }
}