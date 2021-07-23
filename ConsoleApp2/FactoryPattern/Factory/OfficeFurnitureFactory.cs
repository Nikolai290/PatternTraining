using ConsoleApp2.FactoryPattern.Funiture;

namespace ConsoleApp2.FactoryPattern {
    class OfficeFurnitureFactory : FurnitureFactory {
        public OfficeFurnitureFactory(string name) : base(name)
        {
        }

        public override Furniture CreateTable() {
            return new OfficeTable();
        }

        public override Furniture CreateChair() {
            return new OfficeChair();
        }
    }
}
