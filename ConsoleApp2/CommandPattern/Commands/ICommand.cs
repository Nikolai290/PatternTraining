namespace ConsoleApp2.CommandPattern.Commands {
    public interface ICommand {
        void Execute();
        void Undo();
    }
}
