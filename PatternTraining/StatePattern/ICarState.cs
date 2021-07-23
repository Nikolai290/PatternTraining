namespace PatternTraining.StatePattern {
    public interface ICarState {
        void Forward(ICarStatable car);
        void Reverse(ICarStatable car);
    }
}
