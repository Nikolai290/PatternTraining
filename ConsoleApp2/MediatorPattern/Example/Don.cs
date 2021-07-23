using ConsoleApp2.MediatorPattern.Interfaces;

namespace ConsoleApp2.MediatorPattern.Example {
    public class Don : IRequestHandler<Din, string> {

        public string Handle(Din request) {
            return request.din + " don";
        }
    }
}
