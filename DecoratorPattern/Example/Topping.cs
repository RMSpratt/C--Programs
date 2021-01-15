//Abstract Decorator Class
abstract class Topping : IceCreamCone {
    public override abstract string GetDescription();
}

//Concrete Decorator Class #1
class SprinklesTopping : Topping {
    IceCreamCone cone;
    
    public SprinklesTopping(IceCreamCone cone) {
        this.cone = cone;
    }
    
    public override double GetCost() {
        return 0.15 + cone.GetCost();
    }
    
    public override string GetDescription() {
        return cone.GetDescription() + " Add Sprinkles.";
    }
}

//Concrete Decorator Class #2
class HotFudgeTopping : Topping {
    IceCreamCone cone;
    
    public HotFudgeTopping(IceCreamCone cone) {
        this.cone = cone;
    }
    
    public override double GetCost() {
        return 0.30 + cone.GetCost();
    }
    
    public override string GetDescription() {
        return cone.GetDescription() + " Add Hot Fudge.";
    }
}