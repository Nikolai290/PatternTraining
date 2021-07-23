using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.StatePattern {
    public class CarStand :ICarState{

        public CarStand() {
            Console.WriteLine("стоит на месте");
        }
        public void Forward(ICarStatable car) {
            Console.WriteLine("поехал вперёд");
            car.State = new CarDrivingForward();
        }

        public void Reverse(ICarStatable car) {
            Console.WriteLine("поехал назад");
            car.State = new CarDrivingBackward();
        }
    }
}
