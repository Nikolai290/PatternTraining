namespace PatternTraining.MediatorPattern.Interfaces {
    public interface IRequest {
    }


    public interface IRequest<TRequest, TResponse> : IRequest {
    }

    public interface IRequest<TRequest> : IRequest {
    }


}
