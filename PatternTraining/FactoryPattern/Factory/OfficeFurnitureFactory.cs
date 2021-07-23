using PatternTraining.FactoryPattern.Funiture;

namespace PatternTraining.FactoryPattern {
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
