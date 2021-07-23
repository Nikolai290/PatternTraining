using ConsoleApp2.FactoryPattern.Funiture;

namespace ConsoleApp2.FactoryPattern {
    class ComfortableFunitureFactory : FurnitureFactory {
        public ComfortableFunitureFactory(string name) : base(name)
        {
        }

        public override Furniture CreateTable() {
            return new ComfortTable();
        }

        public override Furniture CreateChair() {
            return new ComfortChair();
        }
    }
}
    