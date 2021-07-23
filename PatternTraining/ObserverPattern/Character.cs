using PatternTraining.ObserverPattern;
using PatternTraining.ObserverPattern.Indicators;
using System.Collections.Generic;

namespace PatternTraining.ObserverPattern {
    public class Character : IObservable, IJumping {
        public Health Health { get; private set; }
        public IList<IObserver> Observers { get; set; } 
        public bool IsAlive {
            get {
                return Health.Current > Health.Zero;
            }
        }

        private JumpHandler JumpHandler{ get; set; }

        public Character(int startHealth) {
            Health = new Health(startHealth);
            Observers = new List<IObserver>();
            JumpHandler = new JumpHandler();
        }
        public void AddObserver(IObserver observer) {
            Observers.Add(observer);
            NotifyObservers(this);
        }

        public void RemoveObserver(IObserver observer) {
            Observers.Remove(observer);
        }

        public void NotifyObservers(object obj) {
            foreach (var observer in Observers) {
                observer.Update(obj);
            }
        }

        public void HealthChange(int value) {
            Health.Change(value);
            NotifyObservers(this);
        }

        public void Jump() {
            if(IsAlive) 
                NotifyObservers(JumpHandler.Jump());
        }
    }
}
