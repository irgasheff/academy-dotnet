using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;

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

// -----     OCP     -----
CurrencyCalculator usdCalculator = new UsdDollarCalculator();
CurrencyCalculator tjsCalculator = new TjsSomoniCalculator();
CurrencyCalculator uzbCalculator = new UzbSumCalculator();

const double amount = 10;
double convertedToUsd = usdCalculator.ConvertCurrency(amount);
Console.WriteLine($"Your {amount} amount is equals to {convertedToUsd} USD dollar");

double convertedToTjs = tjsCalculator.ConvertCurrency(amount);
Console.WriteLine($"Your {amount} amount is equals to {convertedToTjs} TJS somoni");

double convertedToUzb = uzbCalculator.ConvertCurrency(amount);
Console.WriteLine($"Your {amount} amount is equals to {convertedToUzb} UZB sum");
// -----     OCP     -----

// -----     LSP     -----
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
Calculator sumCalculator = new SumCalculator(numbers);
Console.WriteLine(sumCalculator.Calculate());

Calculator evenNumbersCalculator = new EvenNumbersCalculator(numbers);
Console.WriteLine(evenNumbersCalculator.Calculate());

Calculator oddNumbersCalculator = new OddNumbersCalculator(numbers);
Console.WriteLine(oddNumbersCalculator.Calculate());
// -----     LSP     -----
