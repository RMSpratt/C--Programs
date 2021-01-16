public enum MoveDirections {Up, Down, Left, Right};

/* Interface: UserCommand
 * Description: Base interface for defining concrete commands.
*/
public interface UserCommand {
    public abstract void Execute();
    public abstract void Undo();
}

public class MoveCommand : UserCommand {
    public Player gamePlayer;
    public MoveDirections direction;

    public MoveCommand(Player gamePlayer, MoveDirections direction) {
        this.gamePlayer = gamePlayer;
        this.direction = direction;
    }
    
    public void Execute() {
        gamePlayer.MovePosition(direction);
    }
    
    public void Undo() {
        
        switch (direction) {
                
            case MoveDirections.Up:
                gamePlayer.MovePosition(MoveDirections.Down);
                break;
                
            case MoveDirections.Down:
                gamePlayer.MovePosition(MoveDirections.Up);
                break;
                
            case MoveDirections.Left:
                gamePlayer.MovePosition(MoveDirections.Right);
                break;
                
            case MoveDirections.Right:
                gamePlayer.MovePosition(MoveDirections.Left);
                break;
                
            default:
                break;
        }
    }
}

/* Class: AttackCommand
 * Description: Command class to handle a request for the Player to attack.     
*/
public class AttackCommand : UserCommand {
    Player gamePlayer;
    
    public AttackCommand(Player gamePlayer) {
        this.gamePlayer = gamePlayer;
    }
    public void Execute() {
        gamePlayer.FireArrow();
    }
    
    public void Undo() {
        gamePlayer.ReplenishAmmo(1);
    }
}

/* Class: NoneCommand
 * Description: Command class simulating a NULL object that does nothing when invoked.
*/
public class NoneCommand : UserCommand {
    
    public void Execute() {
        //Do nothing
    }
    
    public void Undo() {
        //Do nothing
    }
}
