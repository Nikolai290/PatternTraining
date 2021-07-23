using ConsoleApp2.ObserverPattern.Indicators;
using System.Collections.Generic;

namespace ConsoleApp2.ObserverPattern {
    public class Character : IObservable{
        public Health Health { get; private set; }
        public IList<IObserver> Observers { get; set; } 
        public bool IsAlive {
            get {
                return Health.Current > Health.Zero;
            }
        }

        public Character(int startHealth) {
            Health = new Health(startHealth);
            Observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer) {
            Observers.Add(observer);
            NotifyObservers();
        }

        public void RemoveObserver(IObserver observer) {
            Observers.Remove(observer);
        }

        public void NotifyObservers() {
            foreach (var observer in Observers) {
                observer.Update(this);
            }
        }

        public void HealthChange(int value) {
            Health.Change(value);
            NotifyObservers();
        }
    }
}
