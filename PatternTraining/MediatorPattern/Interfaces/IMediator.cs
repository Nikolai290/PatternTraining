using System;

namespace PatternTraining.MediatorPattern.Interfaces {
    public interface IMediator {
        void Send<TRequest> (IRequest<TRequest> request);
        TResponse Send<TRequest, TResponse> (IRequest<TRequest, TResponse> request);
        void AddHandler<TResponse>(IRequestHandler<TResponse> handler);
        void AddHandler<TResponse, TRequest>(IRequestHandler<TResponse, TRequest> handler);
        void RemoveHandler<T>(T type);
    }
}
