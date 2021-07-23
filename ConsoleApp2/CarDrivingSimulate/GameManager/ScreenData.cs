using System;

namespace PatternTraining.CarDrivingSimulate {
    public class ScreenData {
        public string EngineSpeed { get; set; }
        public string VechicleSpeed { get; set; }

        public string Gear { get; set; }


        public void Show() {
            Console.WriteLine(VechicleSpeed + " км/ч");
            Console.WriteLine(EngineSpeed + " об/мин");
            Console.WriteLine(Gear + " передача");
        }
    }
}