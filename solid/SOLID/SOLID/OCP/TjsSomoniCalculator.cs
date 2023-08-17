namespace SOLID.OCP;

public sealed class TjsSomoniCalculator : CurrencyCalculator
{
    // Here we can write some logic like, exactly for this currency
    // For example, convert this currency and than add some extra logic, specially for somoni
    public override double ConvertCurrency(double amount)
    {
        return amount * 42.2;
    }
}