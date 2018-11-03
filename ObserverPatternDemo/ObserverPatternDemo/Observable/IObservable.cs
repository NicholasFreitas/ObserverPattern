using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatternDemo.Observers;

namespace ObserverPatternDemo.Observable
{
    interface IObservable
    {
        void Add(IObserver obs);
        void Remove(IObserver obs);
        void Notify();

    }
}
