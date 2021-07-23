using PatternTraining.MediatorPattern.Interfaces;

namespace PatternTraining.MediatorPattern.Example {
    public class Din : IRequest<Din, string> {
        public string din = "din";
    }
}
