using System;
using TransitionTable.EnumDefinitions;

namespace TransitionTable
{
     class Transition
    {
        public State BeginState { get; set; }

         public Event TransitionEvent { get; set; }

         public Action TransitionAction { get; set; }

         public State EndState { get; set; }

         public Transition(State beginState, Event mEvent, Action transitionAction, State endState)
         {
             this.BeginState = beginState;
             this.TransitionEvent = mEvent;
             this.TransitionAction = transitionAction;
             this.EndState = endState;
         }




    }
}