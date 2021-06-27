using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject suject)
        {
            if((suject as Subject).State == 0 || (suject as Subject).State >= 1)
            {
                Console.WriteLine("SUBJECT A HAS REACTED TO EVENT");
            }
        }
    }
}
