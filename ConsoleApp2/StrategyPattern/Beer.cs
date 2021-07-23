using System;

namespace ConsoleApp2.StrategyPattern {
    public class Beer : IDrink{
        public void Drink() {
            Console.WriteLine("Попить пивасика");
        }
    }
}
