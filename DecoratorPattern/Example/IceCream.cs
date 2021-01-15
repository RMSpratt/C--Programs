//Abstract Component Class
abstract class IceCreamCone {
    
    public string description = "Plain ice cream cone.";
    
    public abstract double GetCost();
    
    public virtual string GetDescription() {
        return description;
    }
}

//Concrete Component Class #1
class ChocolateCone : IceCreamCone {
    
    public ChocolateCone() {
        description = "Chocolate ice cream cone.";
    } 
    
    public override double GetCost() {
        return 1.00;
    }
}

//Concrete Component Class #2
class VanillaCone : IceCreamCone {
    
    public VanillaCone() {
        description = "Vanilla ice cream cone.";
    } 
    
    public override double GetCost() {
        return 1.00;
    }
}

