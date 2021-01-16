/* Class: Command
 * Description: Command interface which all specific concrete Command classes must implement.
*/
public interface Command {

    public void Execute();
    public void Undo();
}


/* Class: FirstCommand
 * Description: Specific Command class to execute some command on a Receiver.
*/
public class FirstCommand : Command {

    Receiver commandReceiver;

    public FirstCommand(Receiver receiver) {
        commandReceiver = receiver;
    }

    public void Execute() {
        Console.WriteLine("Executing the command in FirstCommand.");
    }

    public void Undo() {
        Console.WriteLine("Undoing the previous FirstCommand action.");
    }
}


/* Class: SecondCommand
 * Description: Specific Command class to execute some command on a Receiver.
*/
public class SecondCommand : Command {

    Receiver commandReceiver;

    public SecondCommand(Receiver receiver) {
        commandReceiver = receiver;
    }

    public void Execute() {
        Console.WriteLine("Executing the command in SecondCommand.");
    }

    public void Undo() {
        Console.WriteLine("Undoing the previous SecondCommand action.");
    }
}


/* Class: NoneCommand
 * Description: Empty Command class used to simulate a 'NULL Object', which will do nothing when invoked.
*/
public class NoneCommand : Command {

    public void Execute() {

    }

    public void Undo() {

    }
}