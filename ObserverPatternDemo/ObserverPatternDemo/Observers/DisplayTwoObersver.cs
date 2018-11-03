using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatternDemo.Display;
using ObserverPatternDemo.Observable;

namespace ObserverPatternDemo.Observers
{
    class DisplayTwoObersver : IObserver, IDisplay
    {
        private IObservable registeredObservable;
        int DisplayValue = 0;


        public DisplayTwoObersver(IObservable observable)
        {
            registeredObservable = observable;
        }

        public void Display()
        {
            Console.WriteLine(DisplayValue.ToString());
        }

        public void Update(int data)
        {
            DisplayValue = data;
        }

        

    }
}
