
//Data Class to be viewed through the Subject
public class BookCatalog {
    private Dictionary<(string, string), bool> books;
    
    //Constructor
    public BookCatalog() {
        books = new Dictionary<(string, string), bool>();
    }
    
    /* Method: GetBooksAvailable
     * Description: This method scans through the catalog for all of the books available to 
     * be taken out. The list of these books is returned as a list of strings containing  
     * title and author information.
    */
    public List<string> GetBooksAvailable() {
        
        //The list of available books to be returned
        List<string> booksAvailable = new List<string>();;
        
        //Iterate through all of the books in the catalog and get the ones available for 
        //check-out
        foreach ((string title, string author) in books.Keys) {
  
            //If the given book is available, add it to the list to return
            if (books[(title, author)] == true) {
                booksAvailable.Add("Title: " + title + " Author: " + author);
            }
        }
        
        return booksAvailable;
    }
    
    /* Method: IsAvailable
     * Description: This method checks if the book with the given title and author is 
     * available in the catalog. 
    */
    public bool IsAvailable(string title, string author) {
        
        if (books.ContainsKey((title, author)) && books[(title, author)] == true) {
            return true;
        }
        
        else {
            return false;
        }
    }
    
    /* Method: AddBook
     * Description: This method adds the book with the given title and author to the catalog, 
     * if it doesn't already exist within the catalog.
    */
    public void AddBook(string title, string author) {
        
        if ((title is string == false) || title.Length == 0) {
            Console.WriteLine($"The book title \"{title}\" provided is invalid.");
        }
        
        else if ((author is string == false) || author.Length == 0) {
            Console.WriteLine($"The book author \"{author}\" provided is invalid.");
        }
        
        else if (books.ContainsKey((title, author))) {
            Console.WriteLine($"Warn: The book {title} by {author} already exists within the catalog and was not added.");
        }
        
        else {
            books.Add((title, author), true);
        }
    }
    
    /* Method: TakeOutBook
     * Description: This method will mark a book in the catalog as unavailable as if it
     * were checked out from the library. 
    */
    public void TakeOutBook(string title, string author) {
    
        //If the book is available in the catalog, mark it as unavaialable
        if (IsAvailable(title, author)) {
            Console.WriteLine($"The book \"{title}\" by {author} has successfully been taken out. ");
            books[(title, author)] = false;
        }
        
        else {
            Console.WriteLine($"The book {title} by {author} requested is not available to be taken out.");
        }
    }
    
    /* Method: RemoveBook
     * Description: Method to remove the book with the given title and author from the  
     * catalog if it exists within the catalog. 
    */
    public void RemoveBook(string title, string author) {

        //Ensure that the book to remove exists in the catalog
        if (books.ContainsKey((title, author))) {
            books.Remove((title, author));
        }
    }
    
    /* Method: ReturnBook
     * Description: Method to mark the book with the given title and author as available
     * if it exists within the catalog. 
    */
    public void ReturnBook(string title, string author) {
    
        //If the book to be returned exists in the catalog, set it to available
        if (books.ContainsKey((title, author))) {
            Console.WriteLine($"The book \"{title}\" by {author} has successfully been returned. ");
            books[(title, author)] = true;
        }
        
        //Else, inform the user that the book must be entered into the catalog first.
        else {
            Console.WriteLine($"The book {title} by {author} to return has not yet been registered in the catalog.");
        }
    }
}