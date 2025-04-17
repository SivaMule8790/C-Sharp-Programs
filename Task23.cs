using System;
class Book{
    static int BookID=34;
    static string Title="Book1";
    static string Author="ab1";
    static decimal Price=540.00m; 
    static int copies=23;
    static void display(){
        Console.WriteLine("Book details:");
        Console.WriteLine(BookID);
        Console.WriteLine(Title);
        Console.WriteLine(Author);
        Console.WriteLine(Price);
        Console.WriteLine(copies);
    }
    static decimal toatl(){
        return Price*copies;
    }
    static void Main(){
        display();
        Console.WriteLine("Total stock is: "+toatl());
    }
}
/*You are developing a simple application to manage a book store. Each book has an ID, a title, an author, a price, and the number of copies available in the store. You need to create a program that will display the details of a book and calculate the total value of the books in stock.
Requirements:
Create a class Book with the following properties:
int BookID: The unique identifier for the book.
string Title: The title of the book.
string Author: The author of the book.
decimal Price: The price of the book.
int CopiesAvailable: The number of copies available in the store
 Create a method DisplayDetails() in the Book class to display the book's details.
Create  a method  CalculatetotalValue()  in the book class to calculate the total value of the books in stock.
*/