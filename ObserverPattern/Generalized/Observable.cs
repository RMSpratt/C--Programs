class BasicSubject {

    private List<IObserver<DataObj>> currentObservers;
    
    public BasicSubject() {
        currentObservers = new List<IObserver<DataObj>>();
    }
    
    /* Method: Subscribe
     * Description: This method adds the passed 'observer' to this subject's list of observers. 
     * An Unsubscriber is returned to help detect when the observer stops monitoring this subject.
     *
     * Parameter: observer - The new observer being subscribed
     * Return: Unsubscriber
    */
    public IDisposable Subscribe(IObserver<DataObj> observer) {
        
        //Check that the passed observer isn't already subscribed
        if (!currentObservers.Contains(observer)) {
            currentObservers.Add(observer);
        }
        
        return new Unsubscriber(currentObservers, observer);
    }
    
    /* Internal Class Unsubscriber */
    private class Unsubscriber : IDisposable {
        private List<IObserver<DataObj>> _currentObservers;
        private IObserver<DataObj> _observer;
        
        public Unsubscriber(List<IObserver<DataObj>> currentObservers, IObserver<DataObj> observer) {
            this._catalogDisplays = currentObservers;
            this._display = observer;
        }
        
        /* Method: Dispose
         * Description: This method removes its observer from the list of observers for the 
         * subject, if it hasn't been already. 
        */
        public void Dispose() {
            
            if (this.observer != null && _currentObservers.Contains(this.observer)) {
                this._currentObservers.Remove(this.observer);
            }
        }
    }
    
    /* Method: UpdateObservers
     * Description: This method updates all of the observers of the subject with the new
     * status of the associated Data Object class.
    */
    public void UpdateObservers(DataObj currentObj) {
        
        //Notify each observer of the new updated data object
        foreach (IObserver<DataObj> observer in currentObservers) {
            
            if (currentObj != null) {
                observer.OnNext(currentObj);
            }
            
            //If the data object passed is null, each observer should display an error message
            else {
                observer.OnError(new UnknownObjException());
            }
        }
    }
    
    /* Method: UnsubscribeAll
     * Description: This method unsubscribes all of this subject's observers. 
    */
    public void UnsubscribeAll() {

        foreach (IObserver<DataObj> observer in currentObservers) {
            observer.OnCompleted();
        }
    }
}