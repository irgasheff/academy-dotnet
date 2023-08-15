﻿using SOLID.SRP;

// -----     SRP     -----
Bookshelf bookshelfAToB = new Bookshelf("A-B", 4, 5, 10);

Book warAndPeace = new Book(2180, "novel", "Lev Tolstoi", "War and Peace");

// This is the wrong type of coding
warAndPeace.AddBookToBookshelf(bookshelfAToB);
Console.WriteLine(bookshelfAToB.ToString());

// This is the right way, adding books to shelf is not the books logic
bookshelfAToB.AddBookToBookshelf(warAndPeace);
Console.WriteLine(bookshelfAToB.ToString());
// -----     SRP     -----