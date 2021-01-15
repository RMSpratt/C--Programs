//Exception Class
public class UnknownCatalogException : Exception
{
   internal UnknownCatalogException()
   { }
}


//Subject Class (Observable)
class CatalogManager : IObservable<BookCatalog> {

    private List<IObserver<BookCatalog>> catalogDisplays;
    
    public CatalogManager() {
        catalogDisplays = new List<IObserver<BookCatalog>>();
    }
    
    /* Method: Subscribe
     * Description: This method adds the passed Observer display to this Catalog's list of  
     * displays or 'observers'. An Unsubscriber is returned to detect if the CatalogDisplay 
     * stops observing this BookCatalog. 
     *
     * Parameter: display - The new observer CatalogDisplay
     * Return: Unsubscriber
    */
    public IDisposable Subscribe(IObserver<BookCatalog> display) {
        
        //Check that the BookCatalog isn't already being observed by the new observer
        if (!catalogDisplays.Contains(display)) {
            catalogDisplays.Add(display);
        }
        
        return new Unsubscriber(catalogDisplays, display);
    }
    
    /* Internal Class Unsubscriber */
    private class Unsubscriber : IDisposable {
        private List<IObserver<BookCatalog>> _catalogDisplays;
        private IObserver<BookCatalog> _display;
        
        public Unsubscriber(List<IObserver<BookCatalog>> catalog, IObserver<BookCatalog> display) {
            this._catalogDisplays = catalog;
            this._display = display;
        }
        
        /* Method: Dispose
         * Description: This method removes its observer (CatalogDisplay) from the list of
         * observers for the BookCatalog, if it hasn't been already. 
        */
        public void Dispose() {
            
            if (this._display != null && _catalogDisplays.Contains(this._display)) {
                this._catalogDisplays.Remove(this._display);
            }
        }
    }
    
    /* Method: UpdateAvailability
     * Description: This method updates all of the obsevers of the BookCatalog with new
     * status of available and unavailable books. 
    */
    public void UpdateAvailability(BookCatalog currentCatalog) {
        
        //Notify each observer of the new catalog
        foreach (IObserver<BookCatalog> display in catalogDisplays) {
            
            if (currentCatalog != null) {
                display.OnNext(currentCatalog);
            }
            
            //If the catalog passed is null, each observer should display an error message
            else {
                display.OnError(new UnknownCatalogException());
            }
        }
    }
    
    /* Method: ShutdownDisplays
     * Description: This method simulates the catalog manager shutting down and unsubscribes
     * all of its observers immediately. 
    */
    public void ShutdownDisplays() {
    
        //Unsubscribe each observer from this catalog manager
        foreach (IObserver<BookCatalog> display in catalogDisplays) {
            display.OnCompleted();
        }
    }
}