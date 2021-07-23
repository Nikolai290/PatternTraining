using PatternTraining.MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace PatternTraining.MediatorPattern.Implementation {
    public class Mediator : IMediator {

        public static IMediator Instance;

        public static IMediator GetInstance() {
            if (Instance == default) {
                Instance = new Mediator();
            }

            return Instance;
        }
        public Dictionary<Type, IRequestHandler> Handlers { get; }
        public Mediator() {
            Handlers = new Dictionary<Type, IRequestHandler>();
        }

        public void Send<TRequest>(IRequest<TRequest> request) {
            var handler = (IRequestHandler<TRequest>)Handlers[request.GetType()];
            handler.Handle((TRequest)request);
        }

        public TResponse Send<TRequest, TResponse>(IRequest<TRequest, TResponse> request) {
            var handler = (IRequestHandler<TRequest, TResponse>)Handlers[request.GetType()];
            return handler.Handle((TRequest)request);
        }

        public void AddHandler<TRequest>(IRequestHandler<TRequest> handler) {
            Handlers.Add(typeof(TRequest), handler);
        }
        public void AddHandler<TRequest, TResponse>(IRequestHandler<TRequest, TResponse> handler) {
            Handlers.Add(typeof(TRequest), handler);
        }

        public void RemoveHandler<T>(T type) => Handlers.Remove(type.GetType());
    }
}
