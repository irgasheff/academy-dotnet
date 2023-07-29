using crm_practice.Enums;

namespace crm_practice.Entities;

public class Order
{
    public ulong Id { get; init; }
    public string Description { get; init; }
    public double Price { get; init; }
    public string DateTime { get; init; }
    public DeliveryType DeliveryType { get; init; }
    public string DeliveryAddress { get; init; }
}