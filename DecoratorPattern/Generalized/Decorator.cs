//Abstract Decorator Class
abstract class BaseDecorator : BaseComponent {
    public override abstract string SecondMethod();
}

//Concrete Decorator Class #1
class DecoratorOne : BaseDecorator {
    BaseComponent baseComp;
    
    public DecoratorOne(BaseComponennt baseComp) {
        this.baseComp = baseComp;
    }
    
    //Override an inherited method from the component
    public override double FirstMethod() {
        return 1 + baseComp.FirstMethod();
    }
    
    //Override a second method from the component
    public override string SecondMethod() {
        return baseComp.SecondMethod() + " From the first Decorator!";
    }
}

//Concrete Decorator Class #2
class DecoratorTwo : BaseDecorator {
    BaseComponent baseComp;
    
    public DecoratorTwo(BaseComponent baseComp) {
        this.baseComp = baseComp;
    }

    //Override an inherited method from the component
    public override double FirstMethod() {
        return 2 + baseComp.FirstMethod();
    }
    
    //Override a second method from the component
    public override string SecondMethod() {
        return baseComp.SecondMethod() + " From the second Decorator!";
    }
}