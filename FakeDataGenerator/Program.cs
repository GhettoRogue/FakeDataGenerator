using FakeDataGenerator;
using FakeDataGenerator.creators;
using FakeDataGenerator.generator;

var factory = new PersonFactory(10);
var repository = new PersonRepository(factory);

var listPersons1 = repository.GetPersons().Take(2); 
var listPersons2 = repository.GetPersonsWithAge().Take(2); 
var listPersons3 = repository.GetPersonsFullInfo().Take(2); 

Console.WriteLine();

foreach (var person in listPersons1)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Patronymic}"); 
}

Console.WriteLine();

foreach (var person in listPersons2)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Patronymic} : {person.Age}"); 
}

Console.WriteLine();

foreach (var person in listPersons3)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} {person.Patronymic} : {person.Age} - {person.PhoneNumber}"); 
}