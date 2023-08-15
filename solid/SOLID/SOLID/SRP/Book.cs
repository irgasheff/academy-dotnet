namespace SOLID.SRP;

public class Book
{
    private int Pages { get; set; }
    private string Genre { get; set; }
    private string Author { get; set; }
    private string Title { get; set; }

    public Book(int pages, string genre, string author, string title)
    {
        Pages = pages;
        Genre = genre;
        Author = author;
        Title = title;
    }

    public void SetPages(int pages)
    {
        Pages = pages;
    }

    public int GetPages()
    {
        return Pages;
    }

    public void SetGenre(string genre)
    {
        Genre = genre;
    }

    public string GetGenre()
    {
        return Genre;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public string GetTitle()
    {
        return Title;
    }

    // This is the wrong type of coding
    public void AddBookToBookshelf(Bookshelf bookshelf)
    {
        bookshelf.Books.Add(this);
    }
}