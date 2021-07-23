using System.Collections.Generic;

namespace PatternTraining.ObserverPattern {
    public interface IObservable {
        IList<IObserver> Observers { get; set; }
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(object obj);
    }
}
