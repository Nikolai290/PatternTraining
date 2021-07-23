using System;

namespace PatternTraining.StrategyPattern {
    public class Tea : IDrink {
        public void Drink() {
            Console.WriteLine("Выпить чаю");
        }
    }
}
