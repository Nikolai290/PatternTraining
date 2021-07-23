namespace ConsoleApp2.CommandPattern.Commands {
    public class GoUp : ICommand {
        public Character Character { get; set; }

        public GoUp(Character character) {
            Character = character;
        }
        public void Execute() {
            Character.Coord.MoveUp();
        }

        public void Undo() {
            Character.Coord.MoveDown();
        }
    }
}
