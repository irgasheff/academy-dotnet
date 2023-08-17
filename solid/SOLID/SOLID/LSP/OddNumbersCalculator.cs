namespace SOLID.LSP;

public class OddNumbersCalculator : Calculator
{
    public OddNumbersCalculator(int[] numbers) : base(numbers)
    {
    }

    public override int Calculate()
    {
        return _numbers.Where(number => number % 2 != 0).Sum();
    }
}