namespace PatternTraining.CommandPattern.Commands {
    public interface ICommand {
        void Execute();
        void Undo();
    }
}
