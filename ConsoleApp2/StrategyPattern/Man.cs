namespace ConsoleApp2.StrategyPattern {
    public class Man {
        private IDrink Glass { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Man PutInGlass(IDrink drink) {
            Glass = drink;
            return this;
        }

        public Man Drink() {
            Glass.Drink();
            return this;
        }
    }
}
