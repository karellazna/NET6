using ConsoleTest.Model;
using ConsoleTest.Data;

List<Person> lide = new List<Person>();

for     (int i = 0; i < 50; i++)
{
    lide.Add(RandomPersonGenerator.GetRandomPerson());
}

var result = lide.OrderBy(osoba => osoba.DateOfBirth)
    .Where(osoba => osoba.Address.Mesto == "Brno")
    .First();

Console.WriteLine(result);