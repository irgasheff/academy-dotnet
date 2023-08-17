namespace SOLID.LSP;

public class EvenNumbersCalculator : Calculator
{
    public EvenNumbersCalculator(int[] numbers) : base(numbers)
    {
    }

    public override int Calculate()
    {
        return _numbers.Where(number => number % 2 == 0).Sum();
    }
}