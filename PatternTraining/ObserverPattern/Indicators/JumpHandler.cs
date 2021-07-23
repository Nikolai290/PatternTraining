namespace PatternTraining.ObserverPattern.Indicators {
    public class JumpHandler : IJumpCounter {
        public int Counter { get ; private set; }

        public JumpHandler() {
            Counter = 0;
        }


        public IJumpCounter Jump() {
            Counter++;
            return (IJumpCounter)this;
        }
    }

    public interface IJumpCounter {
        int Counter { get; }
    }
}
