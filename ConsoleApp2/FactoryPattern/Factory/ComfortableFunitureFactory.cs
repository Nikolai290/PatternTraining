using PatternTraining.FactoryPattern.Funiture;

namespace PatternTraining.FactoryPattern {
    class ComfortableFunitureFactory : FurnitureFactory {
        public ComfortableFunitureFactory(string name) : base(name)
        {
        }

        public override Table CreateTable() {
            return new ComfortTable();
        }

        public override Chair CreateChair() {
            return new ComfortChair();
        }
    }
}
    