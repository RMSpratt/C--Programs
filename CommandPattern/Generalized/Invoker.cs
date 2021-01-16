public class Invoker {

    List<Command> commands;
    Command lastCommand;

    public Invoker() {
        commands = new List<Command>();
        lastCommand = new NoneCommand();
    }

    public void DisableCommand(int index) {
        commands[index] = new NoneCommand();
    }

    public void ExecuteCommand(int index) {
        commands[index].Execute();
        lastCommand = commands[index];
    }

    public void RegisterCommand(Command command) {
        commands.Add(command);
    }

    public void RegisterCommand(Command command, int index) {
        commands[index] = command;
    }

    public void UndoLastCommand() {
        lastCommand.Undo();
        lastCommand = new NoneCommand();
    }
}