namespace SOLID.OCP;

public class UsdDollarCalculator: CurrencyCalculator
{
    // Here we can write some logic like, exactly for this currency
    // For example, convert this currency and than add some extra logic, specially for dollar
    public override double ConvertCurrency(double amount)
    {
        return amount * 11.1;
    }
}