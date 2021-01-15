//Abstract Creator Class
abstract class Creator {
    
    public abstract Product OrderProduct(string type);
}

//Concrete Creator Class #1
class CreatorTypeOne : Creator {
    
    //Instantiation method to create a Product based on the type passed
    public override Creator OrderProduct(string type) {
        
        Product newProduct;
        
        if (type == "One") {
            newProduct = new ProductOneTypeOne();
        }
        
        else if (type == "Two") {
            newProduct = new ProductOneTypeTwo();
        }

        else {
            newProduct = null;
        }
        
        return newProduct;
    }
}

//Concrete Creator Class #2
class CreatorTypeTwo : Creator {
    
    //Instantiation method to create a Product based on the type passed
    public override Creator OrderProduct(string type) {
        
        Product newProduct;
        
        if (type == "One") {
            newProduct = new ProductTwoTypeOne();
        }

        else {
            newProduct = null;
        }
        
        return newProduct;
    }
}