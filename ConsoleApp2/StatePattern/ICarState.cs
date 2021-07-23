namespace ConsoleApp2.StatePattern {
    public interface ICarState {
        void Forward(ICarStatable car);
        void Reverse(ICarStatable car);
    }
}
