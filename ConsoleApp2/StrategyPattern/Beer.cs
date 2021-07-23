using System;

namespace PatternTraining.StrategyPattern {
    public class Beer : IDrink{
        public void Drink() {
            Console.WriteLine("Попить пивасика");
        }
    }
}
