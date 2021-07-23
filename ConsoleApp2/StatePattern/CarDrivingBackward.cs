using System;

namespace PatternTraining.StatePattern {
    internal class CarDrivingBackward : ICarState {
        public CarDrivingBackward() {
            Console.WriteLine("движется назад");
        }
        public void Forward(ICarStatable car) {
            Console.WriteLine("затормозил");
            car.State = new CarStand();
        }

        public void Reverse(ICarStatable car) {
            Console.WriteLine("поехал назад быстрее");
            car.State = new CarDrivingBackward();
        }
    }
}