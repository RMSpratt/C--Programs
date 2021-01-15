//Abstract Product Class
public abstract class Product {
    SubComponentOne sub1;
    SubComponentTwo sub2;

    public DescribeSubComponentOne() {
        Console.WriteLine($" This product's first sub-component is: {sub1.GetName()}.");
    }

    public DescribeSubComponentTwo() {
        Console.WriteLine($" This product's second sub-component is: {sub2.GetName()}.");
    }
}

//Specific variant A of the Product class
public class ProductVariantA : Product {

    public ProductVariantA(Factory productFactory) {
        productFactory.SetSubOne();
        productFactory.SetSubTwo();
    }
}

//Specific variant B of the Product class
public class ProductVariantB : Product {
    public ProductVariantB(Factory productFactory) {
        productFactory.SetSubOne();
        productFactory.SetSubTwo();
    }
}