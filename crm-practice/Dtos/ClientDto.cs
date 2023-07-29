using crm_practice.Enums;

namespace crm_practice.Dtos;

public struct ClientDto
{
    public string Name { get; }
    public string Surname { get; }
    public string Patronymic { get; }
    public ushort Age { get; }
    public string PassportNumber { get; }
    public Gender Gender { get; }
}