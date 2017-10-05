using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitionTable.EnumDefinitions;

namespace TransitionTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(State.Locked);
            Controller controller = new Controller();

            Transition item = new Transition(State.Locked, Event.Pass, controller.Alarm, State.Locked );
            context.Transitions.Add(item);

            item = new Transition(State.Locked, Event.Coin, controller.UnLock, State.Unlocked);
            context.Transitions.Add(item);

            item = new Transition(State.Unlocked, Event.Pass, controller.Lock, State.Locked);
            context.Transitions.Add(item);

            item = new Transition(State.Unlocked, Event.Coin, new Action(controller.ThankYou), State.Unlocked);
            context.Transitions.Add(item);


            context.ProcessEvents(Event.Pass); // Ожидется Alarm
            context.ProcessEvents(Event.Coin); // Ожидется Unlock
            context.ProcessEvents(Event.Coin); // Ожидется Thank You
            context.ProcessEvents(Event.Pass); // Ожидется Lock
            context.ProcessEvents(Event.Pass); // Ожидется Alarm

            Console.ReadLine();

        }
    }
}
