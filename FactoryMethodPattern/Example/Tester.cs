class Tester {
    static void Main() {
        
        HenchmenRUs BTFactory = new GruntyIndustries();
        HenchmenRUs DKFactory = new FranticFactory();
        
        Console.WriteLine("You encounter an Ugger!");
        Henchman ugger = BTFactory.OrderHenchman("Ugger");
        ugger.CryOut();
        ugger.Attack();

        Console.WriteLine("\nYou encounter a Mr. Dice!");
        Henchman mrDice = DKFactory.OrderHenchman("Mr.Dice");
        mrDice.CryOut();
        mrDice.Attack();
    }
}