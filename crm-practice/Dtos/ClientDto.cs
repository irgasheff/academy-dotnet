namespace crm_practice.Dtos;

public struct ClientDto
{
    public readonly string Name { get; init; }
    public readonly string Surname { get; init; }
    public readonly string Patronymic { get; init; }
    public readonly ushort Age { get; init; }
    public readonly string PassportNumber { get; init; }
    public readonly string Gender { get; init; }
    public readonly string Phone { get; init; }
    public readonly string Email { get; init; }
    public readonly string Password { get; init; }
}