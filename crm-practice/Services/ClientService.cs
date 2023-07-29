using crm_practice.Dtos;
using crm_practice.Entities;

namespace crm_practice.Services;

public class ClientService
{
    public Client CreateClient(ClientDto client)
    {
        return new Client()
        {
            Name = client.Name,
            Surname = client.Surname,
            Patronimyc = client.Patronymic,
            Age = client.Age,
            PassportNumber = client.PassportNumber,
            Gender = client.Gender,
        };
    }
}