using System;

namespace ConsoleApp2.StatePattern {
    internal class CarDrivingForward : ICarState {
        public CarDrivingForward() {
            Console.WriteLine("движется вперёд");
        }
        public void Forward(ICarStatable car) {
            Console.WriteLine("движется вперёд быстрее");
            car.State = new CarDrivingForward();
        }

        public void Reverse(ICarStatable car) {
            Console.WriteLine("затормозил");
            car.State = new CarStand();
        }
    }
}