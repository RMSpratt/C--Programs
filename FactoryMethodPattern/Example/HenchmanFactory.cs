//Abstract Creator Class
abstract class HenchmenRUs {
    
    public abstract Henchman OrderHenchman(string type);
}

//Concrete Creator Class #1
class GruntyIndustries : HenchmenRUs {
    
    //Instantiation method to create a Henchman based on the type passed
    public override Henchman OrderHenchman(string type) {
        
        Henchman newRecruit;
        
        if (type == "Guvnor") {
            newRecruit = new Guvnor();
        }
        
        else if (type == "Ugger") {
            newRecruit = new Ugger();
        }
        
        else if (type == "Washup") {
            newRecruit = new Washup();
        }
        
        else {
            newRecruit = null;
        }
        
        return newRecruit;
    }
}

//Concrete Creator Class #2
class FranticFactory : HenchmenRUs {

    //Instantiation method to create a Henchman based on the type passed
    public override Henchman OrderHenchman(string type) {
        
        Henchman newRecruit;
        
        if (type == "Kasplat") {
            newRecruit = new Kasplat();
        }
        
        else if (type == "Krobot") {
            newRecruit = new Krobot();
        }
        
        else if (type == "Mr.Dice") {
            newRecruit = new MrDice();
        }
        
        else {
            newRecruit = null;
        }
        
        return newRecruit;
    }   
}