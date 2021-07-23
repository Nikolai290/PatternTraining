using ConsoleApp2.MediatorPattern.Interfaces;

namespace ConsoleApp2.MediatorPattern.Example {
    public class Din : IRequest<Din, string> {
        public string din = "din";
    }
}
