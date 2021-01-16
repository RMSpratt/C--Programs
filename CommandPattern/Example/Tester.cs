
class Tester {
    static void Main() {

        Player gamePlayer = new Player();
        PlayerController controller = new PlayerController();
        
        UserCommand upCommand = new MoveCommand(gamePlayer, MoveDirections.Up);
        UserCommand downCommand = new MoveCommand(gamePlayer, MoveDirections.Down);
        UserCommand leftCommand = new MoveCommand(gamePlayer, MoveDirections.Left);
        UserCommand rightCommand = new MoveCommand(gamePlayer, MoveDirections.Right);
        UserCommand attackCommand = new AttackCommand(gamePlayer);
        
        controller.AddCommand(upCommand);
        controller.AddCommand(downCommand);
        controller.AddCommand(leftCommand);
        controller.AddCommand(rightCommand);
        controller.AddCommand(attackCommand);
    }
}