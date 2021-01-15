//Observer Class
class BasicObserver : IObserver<DataObj> {
    
    IDisposable unsubscriber;
    string observerName;
    
    public BasicObserver(string observerName) {
        this.observerName = observerName;
    }
    
    /* Method: OnNext
     * Description: This method is called by the subject when the associated data object is changed.
    */
    public void OnNext(DataObj data) {
        Console.WriteLine("Handle the update here!");
    }

    /* Method: OnError
     * Description: This method is called by the subject when an error occurs with the data object.
    */    
    public void OnError(Exception e) {
        Console.WriteLine("Handle the exception here!");
    }
    
    /* Method: OnCompleted
     * Description: This method is invoked by the subject when it is done broadcasting updates.
    */
    public void OnCompleted() {
        Console.WriteLine("The observer has been unsubscribed from the Subject, by the subject.");
    }
    
    /* Method: Subscribe
     * Description: This method is used to subscribe this 'observer' to the passed 'subject'.
     * The observer's IDisposable is set so that it can unsubscribe from the subject at will.
    */
    public void Subscribe(BasicSubject observable) {
        powerOff = manager.Subscribe(this);
        Console.WriteLine("This observer has subscribed to a subject.");  
    }
    
    /* Method: Unsubscribe
     * Description: This method is used to unsubscribe this 'observer' from its 'subject'.
     * The observer makes use of its IDisposable to remove itself from the subject's list
     * of observers.
    */
    public void Unsubscribe() {
        unsubscriber.Dispose();
        Console.WriteLine("This observer has unsubscribed from a subject.");    
    }
}
