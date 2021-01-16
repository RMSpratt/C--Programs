
//The receiver class for various commands
public class Player {
    private int[] position;
    private int arrowAmmo;
    
    public Player(int[] startPosition) {
        position = startPosition;
        arrowAmmo = 10;
    }
    
    public Player() {
        position = new int[]{0, 0};
        arrowAmmo = 10;
    }
    
    /* Method: FireArrow
     * Description: Fires an arrow from the Player's quiver, if they have ammo.
    */
    public void FireArrow() {
        
        if (arrowAmmo > 0) {
            Console.WriteLine("*Fires arrow*");
            arrowAmmo -= 1;
        }
        
        else {
            Console.WriteLine("No arrows remaining!");
        }
    }
    
    /* Method: MovePosition
     * Description: Method to set the player's position based on the received movement        * input. Checks if the move is valid before updating position.
    */
    public void MovePosition(MoveDirections direction) {
        
        int[] newPosition;
        
        //Create the new position coordinates based on the direction received
        switch(direction) {
            case MoveDirections.Up:
                newPosition = new int[] {position[0] + 1, position[1]};
               break;
            case MoveDirections.Down:
                newPosition = new int[] {position[0] - 1, position[1]};
               break;
            case MoveDirections.Left:
                newPosition = new int[] {position[0], position[1] - 1};
               break;
            case MoveDirections.Right:
                newPosition = new int[] {position[0], position[1] + 1};
               break;
            default:
                newPosition = new int[] {-1, -1};
                break;
        }
        
        //If the new position to move to is valid, move the Player
        if (newPosition[0] >=0 && newPosition[0] <= 8 && newPosition[1] >= 0 && newPosition[1] <= 8) {
            Console.WriteLine($"Moving the player to the position {newPosition[0]} {newPosition[1]}.");
            position = newPosition;
        }
        
        //Else, inform the user that the move is invalid
        else {
            Console.WriteLine("The move can't be made for the current position.");
        }
    }
    
    /* Method: ReplenishAmmo
     * Description: Replenishes the player's arrow ammo by the passed amount.
    */
    public void ReplenishAmmo(int ammo) {
        
        if (ammo > 0) {
            Console.WriteLine($"Refilling ammo with {ammo} arrows.");
            arrowAmmo += ammo;
        }
    }
}
