using ConsoleApp2.FactoryPattern.Funiture;

namespace ConsoleApp2.FactoryPattern {
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
    