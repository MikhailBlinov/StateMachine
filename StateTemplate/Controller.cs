using System;

namespace StateTemplate
{
    public class Controller
    {
        public void Lock()
        {
           Console.WriteLine("Lock"); 
        }

        public void UnLock()
        {
            Console.WriteLine("UnLock");
        }

        public void TankYou()
        {
            Console.WriteLine("Thank You");
        }

        public void Alarm()
        {
            Console.WriteLine("Alarm");
        }
    }
}