using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new LockState());
            context.Coin(); // Unlock
            context.Coin(); // ThankYou
            context.Pass(); // Lock
            context.Coin(); // Unlock 

            context = new Context(new LockState());
            context.Pass();//Alarm
            context.Pass();// Alarm
            context.Coin();// Unlock
            context.Coin();// Thank You

            context = new Context(new UnLockState());
            context.Coin(); // Thank you
            context.Coin(); // Thank you
            context.Pass(); // Lock
            context.Coin(); // Unlock

            context = new Context(new UnLockState());
            context.Pass(); // Lock
            context.Pass(); // Alarm
            context.Coin(); // Unlock
            context.Coin(); // Thank you

            Console.ReadLine();
        }
    }
}
