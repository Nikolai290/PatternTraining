namespace PatternTraining.MediatorPattern.Interfaces {
    public interface IRequestHandler {
        //void Handle(IRequest request);
        //TResponse Handle<TRequest, TResponse>(IRequest<TRequest> request);

    }

    public interface IRequestHandler<TRequest> : IRequestHandler {
       void Handle(TRequest request);
    }

    public interface IRequestHandler<TRequest, TResponse> : IRequestHandler {
        TResponse Handle(TRequest request);
    }
}
