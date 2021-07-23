using PatternTraining.ObserverPattern.Indicators;
using System;

namespace PatternTraining.ObserverPattern {
    class JumpCounterUI : IObserver {
        public void Update(object obj) {
            if (obj is IJumpCounter) {
                var jumpCounter = (IJumpCounter)obj;
                Console.WriteLine(jumpCounter.Counter);
            }
        }
    }
}
