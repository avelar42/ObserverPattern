using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject add to Observer!");
            this._observers.Add(observer);

        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject remove to Observer!");
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notify observers...");
            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void doSomeLogic()
        {
            Console.WriteLine("\nSubject: State has been changed");
            this.State = new Random().Next(0, 10);
            Console.WriteLine("My State has been changed: " + this.State);
            this.Notify();
        }
    }
}
