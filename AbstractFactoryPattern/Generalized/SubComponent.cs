/* First abstract sub-component hierarchy */
public abstract class SubComponentOne {
    string componentName;

    public string GetName() {
        return componentName;
    }
}

public class SubComponentOneVariantA : SubComponentOne {

    public SubComponentOneVariantA() {
        componentName = "Sub-component One Variant A";
    }
}

public class SubComponentOneVariantB : SubComponentOne {
    public SubComponentOneVariantA() {
        componentName = "Sub-component One Variant B";
    }
}


/* Second abstract sub-component hierarchy */
public abstract class SubComponentTwo {
    string componentName;

    public string GetName() {
        return componentName;
    }
}

public class SubComponentTwoVariantA : SubComponentTwo {

    public SubComponentTwoVariantA() {
        componentName = "Sub-component Two Variant A";
    }
}

public class SubComponentTwoVariantB : SubComponentTwo {
    public SubComponentTwoVariantB() {
        componentName = "Sub-component Two Variant B";
    }
}