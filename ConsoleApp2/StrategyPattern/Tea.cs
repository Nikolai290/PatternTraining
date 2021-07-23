using System;

namespace ConsoleApp2.StrategyPattern {
    public class Tea : IDrink {
        public void Drink() {
            Console.WriteLine("Выпить чаю");
        }
    }
}
