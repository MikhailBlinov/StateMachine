using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TransitionTable
{
    class Controller
    {
        public void Lock()
        {
            Console.WriteLine("Controller lock");
        }
        public void UnLock()
        {
            Console.WriteLine("Controller UnLock");
        }
        public void Alarm()
        {
            Console.WriteLine("Controller Alarm");
        }
        public void ThankYou()
        {
            Console.WriteLine("Controller Thank You");
        }
    }
}
