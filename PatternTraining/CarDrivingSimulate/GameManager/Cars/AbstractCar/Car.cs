namespace PatternTraining.CarDrivingSimulate.GameManager.Cars.AbstractCar {
    public abstract class Car {

        public int EngineForce { get; set; }
        public int GearsCount { get; set; }
        public int MaxEngineRotates { get; set; }
        public int IdlingEngineRotates { get; set; }
        public int CurrentGear { get; set; }
        public int CurrentEngineRotates { get; set; }

    }
}
