using crm_practice.Dtos;
using crm_practice.Entities;
using crm_practice.Enums;

namespace crm_practice.Services;

public class ClientService
{
    public static Client CreateClient(ClientDto clientDto)
    {
        Gender gender = clientDto.Gender switch
        {
            "male" => Gender.Male,
            "female" => Gender.Female,
            _ => Gender.Male
        };

        return new Client()
        {
            Name = clientDto.Name,
            Surname = clientDto.Surname,
            Patronimyc = clientDto.Patronymic,
            Age = clientDto.Age,
            PassportNumber = clientDto.PassportNumber,
            Gender = gender,
            Phone = clientDto.Phone,
            Email = clientDto.Email,
            Password = clientDto.Password
        };
    }
}