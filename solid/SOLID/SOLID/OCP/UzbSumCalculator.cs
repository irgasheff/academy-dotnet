namespace SOLID.OCP;

public sealed class UzbSumCalculator : CurrencyCalculator
{
    // Here we can write some logic like, exactly for this currency
    // For example, convert this currency and than add some extra logic, specially for SUM
    public override double ConvertCurrency(double amount)
    {
        return amount * 10.5;
    }
}