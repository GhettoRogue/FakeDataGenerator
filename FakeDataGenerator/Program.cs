using FakeDataGenerator.ConsoleHelper;
using FakeDataGenerator.creators;
using FakeDataGenerator.generator;

var factory = new PersonFactory(5);
var repository = new PersonRepository(factory);

var listPersons1 = repository.GetPerson().Take(2); 
var listPersons2 = repository.GetPersonWithAge().Take(2); 
var listPersons3 = repository.GetPersonWithWithAgeAndName().Take(2); 

Console.WriteLine();

PersonView.PrintPerson(listPersons1);

Console.WriteLine();

PersonView.PrintPersonWithAge(listPersons2);

Console.WriteLine();

PersonView.PrintPersonWithAgeAndName(listPersons3);