// -----     Generic methods example     -----
// List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
// List<double> doubles = new List<double> { 1.2, 2.3, 3.4, 4.5, 5.6 };
//
// T Sum<T>(List<T> numbers)
// {
//     dynamic result = 0;
//
//     foreach (T number in numbers)
//     {
//         result += number;
//     }
//
//     return result;
// }
//
// int intsSum = Sum(ints);
// Console.WriteLine("Ints sum is " + intsSum);
// double doublesSum = Sum(doubles);
// Console.WriteLine("Doubles sum is " + doublesSum);
//
// T Sub<T>(List<T> numbers)
// {
//     dynamic result = 0;
//
//     foreach (T number in numbers)
//     {
//         result -= number;
//     }
//
//     return result;
// }
// int intsSub = Sub(ints);
// Console.WriteLine("Ints sub is " + intsSub);
// double doublesSub = Sub(doubles);
// Console.WriteLine("Doubles sub is " + doublesSub);
// -----     Generic methods example     -----

// -----     Generic classes example     -----
// List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
// List<double> doubles = new List<double> { 1.2, 2.3, 3.4, 4.5, 5.6 };
//
// Calculator<int> intCalc = new Calculator<int>();
// int intSum = intCalc.Sum(ints);
// Console.WriteLine("Sum of numbers of class equals to " + intSum);
// int intSub = intCalc.Sub(ints);
// Console.WriteLine("Sub of numbers of class equals to " + intSub);
//
// Calculator<double> doubleCalc = new Calculator<double>();
// double doublesSum = doubleCalc.Sum(doubles);
// Console.WriteLine("Sum of double numbers of class equals to " + doublesSum);
// double doublesSub = doubleCalc.Sub(doubles);
// Console.WriteLine("Sub of double numbers of class equals to " + doublesSub);
//
// public class Calculator<T>
// {
//     public T Sum(List<T> numbers)
//     {
//         dynamic result = 0;
//
//         foreach (T number in numbers)
//         {
//             result += number;
//         }
//
//         return result;
//     }
//
//     public T Sub(List<T> numbers)
//     {
//         dynamic result = 0;
//
//         foreach (T number in numbers)
//         {
//             result -= number;
//         }
//
//         return result;
//     }
// }
// -----     Generic classes example     -----

// -----     Generic classes constraint example     -----
// This is will show error
// Calculator<string> stringCalc = new Calculator<string>();
//
// // This is will work
// Calculator<int> intCalc = new Calculator<int>();
//
// public class Calculator<T> 
//     where T : struct
// {
//     public T Sum(List<T> numbers)
//     {
//         dynamic result = 0;
//
//         foreach (T number in numbers)
//         {
//             result += number;
//         }
//
//         return result;
//     }
// }
// -----     Generic classes constraint example     -----