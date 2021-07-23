using PatternTraining.MediatorPattern.Interfaces;

namespace PatternTraining.MediatorPattern.Example {
    public class Don : IRequestHandler<Din, string> {

        public string Handle(Din request) {
            return request.din + " don";
        }
    }
}
