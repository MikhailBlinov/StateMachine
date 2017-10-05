using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal enum State
    {
        Locked,
        Unlocked
    };

    internal enum Event
    {
        Coin, Pass
    };

    class Program
    {
        static void Main(string[] args)
        {
            Performer performer = new Performer();

            Context context = new Context(SwitchCase.State.Locked, performer);

            context.GetLocalState();
            context.Implement(SwitchCase.Event.Pass);//В закрытом сотсоянии попробовали пройти
            context.GetLocalState();

            context.Implement(SwitchCase.Event.Coin);//В закрытом сотсоянии опустили монету
            context.GetLocalState();

            context.Implement(SwitchCase.Event.Coin);//В открытом сотсоянии опустили монету
            context.GetLocalState();


            context.Implement(SwitchCase.Event.Pass);//В открытом сотсоянии прошли
            SwitchCase.State localState = context.GetLocalState();
            Debug.Assert(SwitchCase.State.Unlocked == localState,"Не сработало закрытие состояния");

            context.Implement(SwitchCase.Event.Pass);//В закрытом сотсоянии попробовали пройти
            context.GetLocalState();

            Console.ReadLine();

        }
    }
}
