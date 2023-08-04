using crm_practice.Dtos;
using crm_practice.Entities;
using crm_practice.Services;

void CreateClient()
{
    Console.WriteLine("Введите имя клиента: ");
    string name = Console.ReadLine();
    
    Console.WriteLine("Введите фамилие клиента: ");
    string surname = Console.ReadLine();
    
    Console.WriteLine("Введите отчество клиента: ");
    string patronimyc = Console.ReadLine();
    
    Console.WriteLine("Введите возраст клиента: ");
    ushort age = ushort.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите серию паспорта клиента: ");
    string passportNumber = Console.ReadLine();
    
    Console.WriteLine("Введите отчество клиента: ");
    string gender = Console.ReadLine();
    
    Console.WriteLine("Введите номер телефона клиента: ");
    string phone = Console.ReadLine();
    
    Console.WriteLine("Введите почту клиента: ");
    string email = Console.ReadLine();
    
    Console.WriteLine("Введите пароль для клиента: ");
    string password = Console.ReadLine();

    ClientDto clientDto = new ClientDto()
    {
        Name = name,
        Surname = surname,
        Patronymic = patronimyc,
        Age = age,
        PassportNumber = passportNumber,
        Gender = gender,
        Phone = phone,
        Email = email,
        Password = password,
    };
    
    Client client = ClientService.CreateClient(clientDto);
}