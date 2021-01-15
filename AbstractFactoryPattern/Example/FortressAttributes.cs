/* Sub-component Hierarchy #1: Flag */

//Flag Base Class
public abstract class Flag {
    protected bool flagHoisted;
    protected string colour;
    
    public string GetColour() {
        return colour;
    }
    
    public void Hoist() {
        flagHoisted = true;
    }
    
    public void TakeDown() {
        flagHoisted = false;
    }
}

//Ice Castle sub-class
class FrostyBlueFlag : Flag {
    
    public FrostyBlueFlag() {
        colour = "Frosty Blue";
    }
}

//Lava Forge sub-class
class FieryRedFlag : Flag {
    
    public FieryRedFlag() {
        colour = "Fiery Red";
    }
}


/***** Sub-component Hierarchy #2: Artillery *****/

//Artillery Base Class
public abstract class Artillery {
    protected int ammoAmount;
    protected int reloadTime;
    protected string artilleryDescription;
    
    
    public string GetArtillery() {
        return artilleryDescription;
    }
    
    public abstract void Fire();
    public abstract void Reload();
}

//SnowballCannons sub-class
class SnowballCannons : Artillery {
    
    public SnowballCannons() {
        ammoAmount = 40;
        reloadTime = 25;
        artilleryDescription = "Powerful Snowball Cannons";
    }
    
    public override void Reload() {
        Console.WriteLine("Reloading the cannons...");
        Console.WriteLine("Packing snow...");
        Console.WriteLine("Rolling snowballs...");
        Console.WriteLine("Breaking for hot chocolate...... .....");
        Console.WriteLine("Stocking the cannons...");
        Console.WriteLine("The cannons are reloaded!");
        ammoAmount = 40;
    }
    
    public override void Fire() {
        
        if (ammoAmount > 0) {
            Console.WriteLine("Firing the cannons!");
            ammoAmount -= 8;
        }
        
        else {
            Console.WriteLine("The cannons are empty!");
        }
    }
}

//Flaming Arrow Crossbows sub-class
class FlamingArrowCrossbows : Artillery {

    public FlamingArrowCrossbows() {
        ammoAmount = 100;
        reloadTime = 15;
        artilleryDescription = "Quickfire Flaming Arrows";
    }
    
    public override void Reload() {
        Console.WriteLine("Reloading the crossbows...");
        Console.WriteLine("Exploring the stockroom...");
        Console.WriteLine("Lighting arrows...");
        Console.WriteLine("Treating minor burn wounds...");
        Console.WriteLine("Filling heatproof crossbow storage...");
        Console.WriteLine("The crossbows are stocked!");
        ammoAmount = 100;
    }
    
    public override void Fire() {
        Console.WriteLine("Firing the crossbows!");
        ammoAmount -= 10;
    }
}


/***** Sub-component Hierarchy #3: Outer Defenses *****/

//OuterDefenses Base Class
public abstract class OuterDefenses {
    protected int defenseHealth;
    protected string defenseDescription;
    
    public string GetDefenseType() {
        return defenseDescription;
    }
    
    public abstract void Repair();
    public abstract void Damage(int damage);
}

//FortifiedIceWalls sub-class
class FortifiedIceWalls : OuterDefenses {

    public FortifiedIceWalls() {
        defenseHealth = 500;
        defenseDescription = "Frigid Walls made of ice and magic";
    }

    public override void Damage(int damage) {

        //Check that the walls can still be damaged
        if (defenseHealth > 0) {
            defenseHealth = defenseHealth - damage;

            if (defenseHealth > 400) {
                Console.WriteLine("The walls have sustained minor damage.");
            }

            else if (defenseHealth > 250) {
                Console.WriteLine("The walls have sustained significant damage!");
            }

            else if (defenseHealth > 50) {
                Console.WriteLine("The walls are crumbling!");
            }

            else if (defenseHealth > 0) {
                Console.WriteLine("The walls are nearly destroyed!!");
            }

            else {
                Console.WriteLine("The walls are done for!");
            }
        }
    }

    public override void Repair() {
        Console.WriteLine("Repairing defenses...");
        Console.WriteLine("Rushing to the walls...");
        Console.WriteLine("Moving bricks around...");
        Console.WriteLine("Fighting off the undead...");
        Console.WriteLine("The defenses are repaired!");
        defenseHealth = 500;
    }
}

//ScorchingLavaMoat sub-class
class LavaMoat : OuterDefenses {
    
    public LavaMoat() {
        defenseHealth = 10000;
        defenseDescription = "An indestructible scorching-hot lava moat";
    }
    
    public override void Damage(int damage) {
        Console.WriteLine("You can't damage lava!");
    }
    
    public override void Repair() {
        Console.WriteLine("Aren't there more important things you should be doing??");
    }
}
    

/***** Sub-component Hierarchy #4: SecretPassage *****/

//SecretPassage Base Class
public abstract class SecretPassage {
    protected string passageLocation;
    protected string passagePasscode;
    
    public void RevealPassage(string passcode) {
        if (passcode == this.passagePasscode) {
            Console.WriteLine(passageLocation);
        }
        
        else {
            Console.WriteLine("Access Denied.");
        }
    }
}

//FrostbittenDungeons sub-class
class FrostbittenDungeons : SecretPassage {
    
    public FrostbittenDungeons() {
        passageLocation = "Gloomy Frostbitten Dungeons. Enter under the third tower.";
        passagePasscode = "Anchovy Deluxe";
    }
}

//VolcanicPassage sub-class
class VolcanicPassage : SecretPassage {

    public VolcanicPassage() {
        passageLocation = "Underground Volcanic Passage. Enter near the big red boulder.";
        passagePasscode = "Spicy Meat Special";
    }
}
