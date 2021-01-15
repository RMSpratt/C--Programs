class Driver {
    static void Main() {
        FortressBuilder forgeBuilder = new LavaForgeBuilder();
        FortressBuilder castleBuilder = new IceCastleBuilder();
        
        Fortress lavaForge = new LavaForge(forgeBuilder);
        Fortress iceCastle = new IceCastle(castleBuilder);
        
        Console.WriteLine("Running through Lava Forge Analysis and Methods.");
        lavaForge.DescribeFlag();
        lavaForge.DescribeArtillery();
        lavaForge.DescribeDefenses();
        lavaForge.DamageDefenses(50);
        lavaForge.RepairDefenses();
        lavaForge.UseArtillery();
        lavaForge.ReloadArtillery();
        lavaForge.TakeDownFlag();
        lavaForge.HoistFlag();
        lavaForge.GetPassageAccess("Spicy Meet Special");
        
        Console.WriteLine("Running through Ice Castle Analysis and Methods.");
        iceCastle.DescribeFlag();
        iceCastle.DescribeArtillery();
        iceCastle.DescribeDefenses();
        iceCastle.DamageDefenses(100);
        iceCastle.RepairDefenses();
        iceCastle.UseArtillery();
        iceCastle.ReloadArtillery();
        iceCastle.TakeDownFlag();
        iceCastle.HoistFlag();
        iceCastle.GetPassageAccess("Anchovy Deluxe");
    }
}