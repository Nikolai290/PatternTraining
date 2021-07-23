using System;
using System.Security.Cryptography.X509Certificates;

namespace PatternTraining.StatePattern {
    public class Car : ICarStatable {
        public string Name { get; set; }
        public ICarState State { get; set; }

        public Car(string name, ICarState state) {
            if (state == default) state = new CarStand();
            State = state;
            Name = name;
        }

        public void Forward() {
            Console.Write(Name +" ");
            State.Forward(this);
        }

        public void Reverse() {
            Console.Write(Name +" ");
            State.Reverse(this);
        }

    }
}
