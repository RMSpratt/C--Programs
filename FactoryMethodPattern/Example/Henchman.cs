//Abstract Product Class
abstract class Henchman {
    
    //Basic attack output method
    public abstract void Attack();
    
    //Basic sound cryout method, triggered when the enemy spots the player
    public abstract void CryOut();
} 


/*** BANJO-TOOIE ENEMIES ***/

//Grunty Industries Guvnor Baddy
class Guvnor : Henchman {
    
    public override void Attack() {
        Console.WriteLine("*Swing wrench*.");
    }
    
    public override void CryOut() {
        Console.WriteLine("AIIIIEEEEE!");
    }
}

//Grunty Industries Washup Baddy
class Washup : Henchman {
    
    public override void Attack() {
        Console.WriteLine("*Glomps you*.");
    }
    
    public override void CryOut() {
        Console.WriteLine("*Silence*");
    }
}

//Isle O' Hags Ugger Baddy
class Ugger : Henchman {
    
    public override void Attack() {
        Console.WriteLine("*Punch*.");
    }
    
    public override void CryOut() {
        Console.WriteLine("Ugghh!");
    }
}


/*** DONKEY KONG 64 ENEMIES ***/

//General Purpose Kasplat Baddy
class Kasplat : Henchman {
    
    public override void Attack() {
        Console.WriteLine("*Punch*");
        Console.WriteLine("*Punch*");
        Console.WriteLine("*KA-SLAM*");
    }
    
    public override void CryOut() {
        Console.WriteLine("Ka-SPLAT!");
    }
}

//Frantic Factory Krobot Baddy
class Krobot : Henchman {
    
    public override void Attack() {
        Console.WriteLine("*Double Punch*");
    }
    
    public override void CryOut() {
        Console.WriteLine("*Frantic Winding*");
    }
}

//Frantic Factory MrDice Baddy
class MrDice : Henchman {
    
    public override void Attack() {
        Console.WriteLine("*Glomps You*");
    }
    
    public override void CryOut() {
        Console.WriteLine("*Menacing silence*");
    }
}