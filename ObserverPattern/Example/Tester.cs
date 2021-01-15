class HelloWorld {
    static void Main() {
        
        BookCatalog currentCatalog = new BookCatalog();
        List<string> bookList = new List<String>();
        
        CatalogManager catalogRecord = new CatalogManager();
        CatalogDisplay firstDisplay = new CatalogDisplay("Front Desk");
        CatalogDisplay secondDisplay = new CatalogDisplay("Second Floor Terminal");
        
        firstDisplay.Subscribe(catalogRecord);
        secondDisplay.Subscribe(catalogRecord);
        secondDisplay.Unsubscribe();

        currentCatalog.AddBook("A Dance of Dragons", "George R.R. Martin");
        currentCatalog.AddBook("A Feast for Crows", "George R.R. Martin");
        currentCatalog.AddBook("Bep", null);
        
        catalogRecord.UpdateAvailability(null);
        //bookList = currentCatalog.GetBooksAvailable();
        // Console.WriteLine("There are: " + bookList.Count + " books in the catalog");
    }
}