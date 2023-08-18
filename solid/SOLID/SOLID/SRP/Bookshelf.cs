using System.Net;

namespace SOLID.SRP;

public sealed class Bookshelf
{
    public string Title { get; set; }
    public int Row { get; set; }
    public int ShelfCount { get; set; }
    public int BooksQuantity { get; set; }
    
    public List<Book> Books { get; set; } = new();

    public Bookshelf(string title, int row, int shelfCount, int booksQuantity)
    {
        Title = title;
        Row = row;
        ShelfCount = shelfCount;
        BooksQuantity = booksQuantity;
    }

    public override string ToString()
    {
        return $"Книги: {Title}, Ряд: {Row}, Количество полок: {ShelfCount} Количество книг: {BooksQuantity}";
    }

    public void AddBookToBookshelf(Book book)
    {
        Books.Add(book);
    }
}