using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Context
    {
        private State _localState;
        private Performer _performer;

        public Context(State state, Performer performer)
        {
            _localState = state;
            _performer = performer;
        }

        public void Implement(SwitchCase.Event @event)
        {
            switch (_localState)
            {
                case State.Locked:
                    switch (@event)
                    {
                        case SwitchCase.Event.Coin:
                            _performer.Unlock();
                            _localState = State.Unlocked;
                            break;
                        case SwitchCase.Event.Pass:
                            _performer.Alarm();
                            break;

                    }

                    break;
                case State.Unlocked:
                    switch (@event)
                    {
                        case SwitchCase.Event.Coin:
                            _performer.ThankYou();
                            break;
                        case SwitchCase.Event.Pass:
                            _performer.Lock();
                            _localState = State.Locked;

                            break;
                    }
                    break;
            }
        }

        public SwitchCase.State GetLocalState()
        {
            Console.WriteLine(Enum.GetName(typeof(SwitchCase.State), _localState));
            return _localState;
        }

    }
}
