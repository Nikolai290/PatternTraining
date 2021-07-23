using ConsoleApp2.FactoryPattern.Funiture;

namespace ConsoleApp2.FactoryPattern {
    class OfficeFurnitureFactory : FurnitureFactory {
        public OfficeFurnitureFactory(string name) : base(name)
        {
        }

        public override Table CreateTable() {
            return new OfficeTable();
        }

        public override Chair CreateChair() {
            return new OfficeChair();
        }
    }
}
