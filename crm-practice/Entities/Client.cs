using crm_practice.Enums;

namespace crm_practice.Entities;

public class Client
{
    private string? _name;
    public string Name
    {
        get => _name ?? string.Empty;
        init => _name = value is { Length: > 0} ? _name = value : throw new ArgumentOutOfRangeException();
    }

    private string? _surname;
    public string Surname
    {
        get => _surname ?? string.Empty; 
        init => _surname = value is { Length: > 0} ? _surname = value : throw new ArgumentOutOfRangeException();
    }

    private string? _patronimyc;
    public string Patronimyc
    {
        get => _patronimyc ?? string.Empty; 
        init => _patronimyc = value is { Length: > 0} ? _patronimyc = value : throw new ArgumentOutOfRangeException();
    }

    private ushort _age;
    public ushort Age
    {
        get => _age;
        init => _age = value < 120 ? _age = value : throw new ArgumentOutOfRangeException();
    }

    private string? _passportNumber;
    public string PassportNumber 
    { 
        get => _passportNumber ?? string.Empty;
        init => _passportNumber = value is { Length: > 0} ? _passportNumber = value : throw new ArgumentOutOfRangeException();
    }
    
    public Gender Gender { get; set; }

    private string? _phone;
    public string Phone
    { 
        get => _phone ?? string.Empty;
        init => _phone = value is { Length: > 0} ? _phone = value : throw new ArgumentOutOfRangeException();
    }

    private string? _email;
    public string Email 
    { 
        get => _email ?? string.Empty;
        init => _email = value is { Length: > 0} ? _email = value : throw new ArgumentOutOfRangeException();
    }

    // TODO: encryption
    private string? _password;
    public string Password 
    { 
        get => _password ?? string.Empty;
        init => _password = value is { Length: > 0} ? _password = value : throw new ArgumentOutOfRangeException();
    }}