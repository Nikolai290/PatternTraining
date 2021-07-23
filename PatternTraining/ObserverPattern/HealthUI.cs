using System;

namespace PatternTraining.ObserverPattern {
    public class HealthUI : IObserver {
        public void Update(object obj) {
            if (obj is Character) {
                var character = (Character)obj;
                var health = character.Health;
                Console.WriteLine("Здоровье персонажа: " + health.Current);
                if (!character.IsAlive) {
                    Console.WriteLine("Персонаж погиб");
                }
            }
        }
    }
}
