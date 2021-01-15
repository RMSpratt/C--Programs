//Observer Class
class CatalogDisplay : IObserver<BookCatalog> {
    
    IDisposable powerOff;
    string displayName;
    
    public CatalogDisplay(string displayName) {
        this.displayName = displayName;
    }
    
    /* Method: OnNext
     * Description: This method is called on each update of the BookCatalog and will read
     * through and display the books now available in the catalog.
    */
    public void OnNext(BookCatalog catalog) {
        
        List<string> bookList = catalog.GetBooksAvailable();
        
        Console.WriteLine($"Reporting from the {displayName} catalog display.");
        Console.WriteLine($"There are currently {bookList.Count} books available to take out.");
    }
    
    public void OnError(Exception e) {
        Console.WriteLine("Err: Something went wrong retrieving the updated catalog.");
    }
    
    /* Method: OnCompleted
     * Description: This method is invoked by this 'observer's' associated 'subject'.
     * After which, this observer will no longer be subscribed to the subject.
    */
    public void OnCompleted() {
        Console.WriteLine($"The display {displayName} is going offline. Goodbye!");
    }
    
    /* Method: Subscribe
     * Description: This method is used to subscribe this 'observer' to the passed 'subject'.
     * The observer's IDisposable is set so that it can unsubscribe from the subject at will.
    */
    public void Subscribe(CatalogManager manager) {
        powerOff = manager.Subscribe(this);
        Console.WriteLine($"The display {displayName} is now online.");  
    }
    
    /* Method: Unsubscribe
     * Description: This method is used to unsubscribe this 'observer' from its 'subject'.
     * The observer makes use of its IDisposable to remove itself from the subject's list
     * of observers.
    */
    public void Unsubscribe() {
        powerOff.Dispose();
        Console.WriteLine($"The display {displayName} is going offline. Goodbye!");    
    }
}
