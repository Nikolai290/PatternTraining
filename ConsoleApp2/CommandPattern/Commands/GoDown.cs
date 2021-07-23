namespace PatternTraining.CommandPattern.Commands {
    public class GoDown : ICommand {
        public Character Character { get; set; }

        public GoDown(Character character) {
            Character = character;
        }
        public void Execute() {
            Character.Coord.MoveDown();
        }

        public void Undo() {
            Character.Coord.MoveUp();
        }
    }
}
