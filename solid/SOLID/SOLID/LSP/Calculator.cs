namespace SOLID.LSP;

public abstract class Calculator
{
    protected readonly int[] _numbers;

    protected Calculator(int[] numbers)
    {
        _numbers = numbers;
    }

    public abstract int Calculate();
}