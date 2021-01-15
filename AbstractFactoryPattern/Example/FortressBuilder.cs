//Fortress Builder (Factory) Interface
public interface FortressBuilder {
    public abstract Flag SetFlag();
    public abstract OuterDefenses BuildOuterDefenses();
    public abstract Artillery InstallArtillery(); 
    public abstract SecretPassage CreateSecretPassage();
}

//Fortress Builder (Factory) Implementation #1
class IceCastleBuilder : FortressBuilder {
    
    public Flag SetFlag() {
        return new FrostyBlueFlag();
    }
    
    public OuterDefenses BuildOuterDefenses() {
        return new FortifiedIceWalls();
    }
    
    public Artillery InstallArtillery() {
        return new SnowballCannons();
    }
    
    public SecretPassage CreateSecretPassage() {
        return new FrostbittenDungeons();
    }
}

//Fortress Builder (Factory) Implementation #2
class LavaForgeBuilder : FortressBuilder {
    
    public Flag SetFlag() {
        return new FieryRedFlag();
    }
    
    public OuterDefenses BuildOuterDefenses() {
        return new LavaMoat();
    }
    
    public Artillery InstallArtillery() {
        return new FlamingArrowCrossbows();
    }
    
    public SecretPassage CreateSecretPassage() {
        return new VolcanicPassage();
    }
}