/* Class: Receiver
 * Description: Generic 'Receiver' class that would receive command prompts from the 'Invoker' class.
*/
public class Receiver {

    public void HandleFirstCommand() {
        Console.WriteLine("I've been invoked for the FirstCommand!");
    }

    public void HandleSecondCommand() {
        Console.WriteLine("I've been invoked for the SecondCommand!");
    }
}
