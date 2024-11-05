// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
string title = Console.ReadLine();
Library library = new Library();
library.AddBook("igi", "bejani", 2020);
library.AddBook("maia", "karlo", 1998);
library.AddBook("taro", "kote", 1876);
Book Arqivi = library.FindBook(title);
Console.WriteLine(Arqivi.Author +" "+ Arqivi.Title);
public class Book
{     
    public Book(string title, string author, int year) //construcror
    { Title = title;
      Author = author;
        Year = year;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

}
public class Library
{ List <Book   > books = new List <Book > ();
 public void AddBook (string title, string authotor, int year ) 
      { books.Add (new Book (title, authotor, year)); }
 
 public Book FindBook (string title) {  return books.Where(X => X.Title == title).FirstOrDefault() ; }
}