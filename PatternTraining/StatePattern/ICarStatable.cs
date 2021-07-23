namespace PatternTraining.StatePattern {
    public interface ICarStatable {
        ICarState State { get; set; }
        void Forward();
        void Reverse();
    }
}
