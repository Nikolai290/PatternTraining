using ConsoleApp2.MediatorPattern.Interfaces;

namespace ConsoleApp2.MediatorPattern.Example {
    public class Ping : IRequest<Ping> {
        public readonly int Number = 5;
        public string ping = "ping";
    }
}
