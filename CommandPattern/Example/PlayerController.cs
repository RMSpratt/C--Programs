
/* Class: PlayerController
 * Description: Invoker class to handle command requests and invoke them on the
 * receiver (Player) class.
*/
public class PlayerController {
    List<UserCommand> playerCommands;
    UserCommand lastCommand;
    
    public PlayerController() {
        playerCommands = new List<UserCommand> {};
        lastCommand = new NoneCommand();
    }
    
    public void AddCommand(UserCommand newCommand) {
        playerCommands.Add(newCommand);
    }
    
    public void DisableCommand(int commandIndex) {
        playerCommands[commandIndex] = new NoneCommand();
    }
    
    public void InvokeCommand(int commandIndex) {
        playerCommands[commandIndex].Execute();
        lastCommand = playerCommands[commandIndex];
    }

    public void SetCommand(UserCommand newCommand, int index) {
        playerCommands[index] = newCommand;
    }
    
    public void UndoLastCommand() {
        lastCommand.Undo();
        lastCommand = new NoneCommand();
    }
}
