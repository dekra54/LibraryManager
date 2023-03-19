           
        
       Library Manager
=========================================================================



  Classes , Methods and Attributes  
----------------------------------------------------------------------------------------------



  **  1.       Class 1 â€“ Book  
   
  **

   1.1.    Attributes 

 1.1.1.Id (int)

 1.1.2.Title (string)

 1.1.3.Author (string)

 1.1.4.Publisher (string)

 1.1.5. QuantityExemplars (int)  
   
 

   1.2.    Methods 

 1.2.1. BorrowBook(int BorrowedQuantity) - You must decrement the 

 1.2.2.QuantityCopy copies of the book;

 1.2.3. DevolverBook(int returnedQuantity) - Should increment the 

 1.2.4.QuantityCopy copies of the book;



  **  2.       Class 2 â€“ Person  
   
  **

  **  2.1.   **  Attributes 

  **  2.1.1.   ** Id (int)****

  **  2.1.2.   ** Name (string)****

  **  2.1.3.   ** Cpf (string)****

  **  2.1.4.   ** Phone (string)****

  **  2.1.5.   ** Borrowed Books (List&lt;Books&gt;)****

  **   

  **

  **  2.2.   **  Methods 

  **  2.2.1.   ** AddBookList(Book)****

  **  2.2.2.   ** RemoveBookList(int Bookid)****

  **   

  **

  **  3.      Class 3 â€“ Library **

  **   

  **

  **  3.1.   ** Attributes****

  **  3.1.1.   ** People (List&lt;Person&gt;)****

  **  3.1.2.   ** Â Books (List&lt;Books&gt;)****

 

    
 

Basic Functionality
-----------------------------------------------------------------------------



  Methods 

RegisterPerson(Person)

  Create a new Person in the Library register to be able to rent out books 

 //Add Functionality description here

 

  RegisterBook(Book) 

 Create a new Book in the Library 

 //Add Functionality description here

 

  LendBookLibrary(int Bookid, int PersonID) 

 Method to rent out a book to a Person

 //Add Functionality description here

 

  Â   BorrowBook 

  of the Book object and Add a Book to the Borrowed Books list of the 

  Person object through the AddBookList method; 



  Â ● DevolverLivroLibrary(int idBook, int idPerson) - You must call the method 

  Â ReturnBook of the Book object and Remove a Book in the Borrowed Books list of the 

  Â Person object through the RemoveBookList method; 

  Â After creating the classes, it will be necessary to prepare the â€œinterfaceâ€

