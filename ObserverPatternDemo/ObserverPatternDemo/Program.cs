using System;
using ObserverPatternDemo.Observable;
using ObserverPatternDemo.Observers;
namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataObservable = new DataObjectObservable();

            var observer1 = new DisplayOneObserver(dataObservable);
            var observer2 = new DisplayTwoObersver(dataObservable);

            dataObservable.Add(observer1);
            dataObservable.Add(observer2);

            dataObservable.Notify();

            observer1.Display();
            observer2.Display();

            dataObservable.Notify();

            observer1.Display();
            observer2.Display();

            Console.ReadLine();

        }
    }
}
