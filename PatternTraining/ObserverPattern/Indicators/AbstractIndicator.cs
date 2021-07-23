namespace PatternTraining.ObserverPattern.Indicators {
    public abstract class AbstractIndicator {
        public int Max { get; private set; }
        public int Current { get; private set; }
        public int Zero { get; }

        public AbstractIndicator(int startValue) {
            Max = startValue;
            Current = Max;
            Zero = 0;
        }

        public void Change(int value) {
            if (Current + value > Max) Current = Max;
            else if (Current + value < Zero) Current = Zero;
            else Current += value;
        }
    }
}
