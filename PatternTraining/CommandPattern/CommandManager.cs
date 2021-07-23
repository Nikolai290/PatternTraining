using PatternTraining.CommandPattern.Commands;
using System.Collections.Generic;

namespace PatternTraining.CommandPattern {
    public class CommandManager {
        public Dictionary<CommandType, ICommand> Commands { get; set; }
        public Stack<ICommand> CommandsHistory { get; set; }

        public CommandManager() {
            Commands = new Dictionary<CommandType, ICommand>();
            CommandsHistory = new Stack<ICommand>();
        }

        public void Execute(CommandType type) {
            Commands[type].Execute();
            CommandsHistory.Push(Commands[type]);
        }

        public void Undo() {
            if (CommandsHistory.Count > 0) {
                ICommand command = CommandsHistory.Pop();
                command.Undo();
            }
        }

    }
}
