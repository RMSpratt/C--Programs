//Abstract Product Class
abstract class Product {
    
    //Basic attack output method
    public abstract void MethodOne();
    
    //Basic sound cryout method, triggered when the enemy spots the player
    public abstract void MethodTwo();
} 


//Specific Product created by the first sub-type of a factory/creator
class ProductOneTypeOne : Product {
    
    public override void MethodOne() {
        Console.WriteLine("Factory Type One, Product One.");
    }
    
    public override void MethodTwo() {
        Console.WriteLine("One is the loneliest number...");
    }
}

//Specific Product created by the first sub-type of a factory/creator
class ProductTwoTypeOne : Product {
    
    public override void MethodOne() {
        Console.WriteLine("Factory Type One, Product Two.");
    }
    
    public override void MethodTwo() {
        Console.WriteLine("Two is just as bad as one...");
    }
}


//Specific Product created by the first sub-type of a factory/creator
class ProductOneTypeTwo : Product {
    
    public override void MethodOne() {
        Console.WriteLine("Factory Type Two, Product One.");
    }
    
    public override void MethodTwo() {
        Console.WriteLine("Another One Bites the Dust!");
    }
}