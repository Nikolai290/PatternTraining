namespace PatternTraining.CommandPattern.Commands {
    public class GoLeft : ICommand {
        public Character Character { get; set; }

        public GoLeft(Character character) {
            Character = character;
        }
        public void Execute() {
            Character.Coord.MoveLeft();
        }

        public void Undo() {
            Character.Coord.MoveRight();
        }
    }
}
