﻿using Crm;

ClientService clientService = new();
CreateClient();

void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    short age = short.Parse(Console.ReadLine());
    string passportNumber = Console.ReadLine();
    string gender = Console.ReadLine();

    Client newClient = clientService.CreateClient(new ClientInfo() {
        FirstName = firstName,
        LastName = lastName,
    });

    // TODO: Output fields...
}