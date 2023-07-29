using crm_practice.Enums;

namespace crm_practice.Entities;

public class Client
{
    public string Name { get; init; }
    public string Surname { get; set; }
    public string Patronimyc { get; set; }
    public ushort Age { get; set; }
    public string PassportNumber { get; set; }
    public Gender Gender { get; set; }
}