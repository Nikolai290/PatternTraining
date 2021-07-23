namespace ConsoleApp2.CommandPattern.Commands {
    public class GoRight : ICommand {
        public Character Character { get; set; }

        public GoRight(Character character) {
            Character = character;
        }
        public void Execute() {
            Character.Coord.MoveRight();
        }

        public void Undo() {
            Character.Coord.MoveLeft();
        }
    }
}
