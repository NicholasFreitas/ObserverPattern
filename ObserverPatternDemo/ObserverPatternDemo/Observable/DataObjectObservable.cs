using System;
using System.Collections.Generic;
using System.Text;
using ObserverPatternDemo.Observers;

namespace ObserverPatternDemo.Observable
{
    class DataObjectObservable : IObservable
    {
        private List<IObserver> Subscribers = new List<IObserver>();
        
        public void Add(IObserver obs)
        {
            Subscribers.Add(obs);
        }

        public void Notify()
        {
            int NewData = GetRandomData();
            foreach (var Sub in Subscribers)
            {
                Sub.Update(NewData);
            }
        }

        public void Remove(IObserver obs)
        {
            if (Subscribers == null)
                throw new Exception("No Registered Subscribers");

            Subscribers.Remove(obs);
        }

        public void RemoveAll()
        {
            //A little defensive programming
            if (Subscribers == null)
                throw new Exception("No Registered Subscribers");

            foreach (var sub in Subscribers)
            {
                Subscribers.Remove(sub);
            }
            
        }

        public int GetRandomData()
        {
            Random rnGenerator = new Random();
            return rnGenerator.Next(1,100);
        }


    }
}
