using System.Collections.Concurrent;

public class EBook : Item
{
    string author;
    string language;
    int pageNumber;
    int yearOfPublication;
    int ISBN;
    
    public EBook(string title, string author, string language, int pageNumber, int yearOfPublication, int ISBN){
        this.title = title;
        this.author = author;
        this.language = language;
        this.pageNumber = pageNumber;
        this.yearOfPublication = yearOfPublication;
        this.ISBN = ISBN;
    }

    public string GetAuthor(){
        return author;
    }
    public string GetLanguage(){
        return language;
    }
    public int GetPageNumber(){
        return pageNumber;
    }
    public int GetYearOfPublication(){
        return yearOfPublication;
    }
    public int GetISBN(){
        return ISBN;
    }
}
