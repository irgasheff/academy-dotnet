using System.Net;

namespace SOLID.SRP;

public class Bookshelf
{
    private string Title { get; set; }
    private int Row { get; set; }
    private int ShelfCount { get; set; }
    private int BooksQuantity { get; set; }
    
    public List<Book> Books { get; set; } = new();

    public Bookshelf(string title, int row, int shelfCount, int booksQuantity)
    {
        Title = title;
        Row = row;
        ShelfCount = shelfCount;
        BooksQuantity = booksQuantity;
    }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public string GetTitle()
    {
        return Title;
    }

    public void SetRow(int row)
    {
        Row = row;
    }

    public int GetRow()
    {
        return Row;
    }

    public void SetShelfCount(int shelfCount)
    {
        ShelfCount = shelfCount;
    }

    public int GetShelfCount()
    {
        return ShelfCount;
    }

    public void SetBooksQuantity(int booksQuantity)
    {
        BooksQuantity = booksQuantity;
    }

    public int GetBooksQuantity()
    {
        return Books.Count;
    }

    public override string ToString()
    {
        return $"Книги: {GetTitle()}, Ряд: {GetRow()}, Количество полок: {GetShelfCount()} Количество книг: {GetBooksQuantity()}";
    }

    public void AddBookToBookshelf(Book book)
    {
        Books.Add(book);
    }
}