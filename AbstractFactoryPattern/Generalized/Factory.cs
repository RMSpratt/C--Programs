//Factory interface for defining specific factories
public interface Factory {

    public abstract SubComponentOne SetSubOne();
    public abstract SubComponentTwo SetSubTwo();
}

//Specific factory class for Variant A Products
public class FactoryVariantA : Factory {

    public SubComponentOne SetSubOne() {
        return new SubComponentOneVariantA();
    }

    public SubComponentTwo SetSubTwo() {
        return new SubComponentTwoVariantA();
    }
}

//Specific factory class for Variant B Products
public class FactoryVariantB : Factory {

    public SubComponentOne SetSubOne() {
        return new SubComponentOneVariantB();
    }

    public SubComponentTwo SetSubTwo() {
        return new SubComponentTwoVariantB();
    }
}