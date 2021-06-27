using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject suject)
        {
            if ((suject as Subject).State == 0 || (suject as Subject).State >= 1)
            {
                Console.WriteLine("SUBJECT B HAS REACTED TO EVENT");
            }
        }
    }
}
