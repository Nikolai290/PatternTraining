using PatternTraining.MediatorPattern.Interfaces;

namespace PatternTraining.MediatorPattern.Example {
    public class Ping : IRequest<Ping> {
        public readonly int Number = 5;
        public string ping = "ping";
    }
}
