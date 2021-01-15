//Abstract Component Class
abstract class BaseComponennt {
    
    public string message = "This is the Base Component!";
    
    public abstract double FirstMethod();
    
    public virtual string SecondMethod() {
        return message;
    }
}

//Concrete Component Class #1
class ComponentOne : BaseComponennt {
    
    public ComponentOne() {
        message = "This is the first Component variant!";
    } 
    
    public override double FirstMethod() {
        return 1.11;
    }
}

//Concrete Component Class #2
class ComponentTwo : BaseComponennt {
    
    public ComponentTwo() {
        message = "This is the second Component variant.";
    } 
    
    public override double FirstMethod() {
        return 1.00;
    }
}

