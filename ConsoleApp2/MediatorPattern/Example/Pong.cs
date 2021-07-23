using PatternTraining.MediatorPattern.Interfaces;
using System;

namespace PatternTraining.MediatorPattern.Example {
    public class Pong : IRequestHandler<Ping> {
        public int Number { get; private set; }
        public string pong = "pong";

        public void Handle(Ping request) {
            this.Number = request.Number * 2;
            Console.WriteLine(this.Number.ToString() + " " + request.ping + " " + pong);
        }
    }
}