using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();
            var subject = new Subject();
            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.doSomeLogic();


            Console.WriteLine("----------------------------");
            subject.Detach(observerA);
            subject.doSomeLogic();

        }

        
    }
}
