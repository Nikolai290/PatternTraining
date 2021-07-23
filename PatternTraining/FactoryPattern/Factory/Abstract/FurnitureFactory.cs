using System;

namespace PatternTraining.FactoryPattern {
    abstract class FurnitureFactory {
        public string Name { get; }

        public FurnitureFactory(string name) {
            Name = name;
            Console.WriteLine(Name + " was been created");
        }

        public abstract Table CreateTable();
        public abstract Chair CreateChair();
    }
}
