//Abstract Fortress (Product) Class
abstract class Fortress {
    protected Flag flag;
    protected OuterDefenses outerDefenses;
    protected Artillery artillery;
    protected SecretPassage secretPassage;
    
    public void DamageDefenses(int damage) {
        outerDefenses.Damage(damage);
    }

    public void DescribeArtillery() {
        string artilleryDescription = artillery.GetArtillery();
        
        Console.WriteLine($"Intruders will be faced with {artilleryDescription}.");
    }

    public void DescribeDefenses() {
        string defenseDescription = outerDefenses.GetDefenseType();
        Console.WriteLine($"This fortress is secured by {defenseDescription}.");    
    }
    
    public void DescribeFlag() {
        string flagColour = flag.GetColour();
        Console.WriteLine($"This fortress hosts a {flagColour} flag.");
    }
 
    public void GetPassageAccess(string passCode) {
        secretPassage.RevealPassage(passCode);
    }
    
    public void HoistFlag() {
        flag.Hoist();
    }

    public void ReloadArtillery() {
        artillery.Reload();
    }
    
    public void RepairDefenses() {
        outerDefenses.Repair();
    }
    
    public void TakeDownFlag() {
        flag.TakeDown();
    }
    
    public void UseArtillery() {
        artillery.Fire();
    }
}

//Specific Fortress (Product) Implementation #1
class IceCastle : Fortress {
    
    FortressBuilder builder;
    
    public IceCastle(FortressBuilder builder) {
        this.builder = builder;
        flag = builder.SetFlag();
        outerDefenses = builder.BuildOuterDefenses();
        artillery = builder.InstallArtillery();
        secretPassage = builder.CreateSecretPassage();
    }
}

//Specific Fortress (Product) Implementation #2
class LavaForge : Fortress {
    
    FortressBuilder builder;
    
    public LavaForge(FortressBuilder builder) {
        this.builder = builder;
        flag = builder.SetFlag();
        outerDefenses = builder.BuildOuterDefenses();
        artillery = builder.InstallArtillery();
        secretPassage = builder.CreateSecretPassage();
    }
}