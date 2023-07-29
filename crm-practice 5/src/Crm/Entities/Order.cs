using System.String;
namespace Crm.Entites;

public class Order
{

    public readonly ulong Id { get; init; }
    public readonly string Description { get; init; }
    public readonly double Price { get; init; }
    public string DateTime { get; init; }
    public string DeliveryType { get; init; }
    public string deliveryAddress { get; init; }
}