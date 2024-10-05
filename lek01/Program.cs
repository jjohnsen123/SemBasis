// See https://aka.ms/new-console-template for more information
using lek01;
using lek01Libary;

Console.WriteLine("Hello, World!");

Person person = new Person("Jeppe");
Console.WriteLine(person);
person.name = "Torben";
Console.WriteLine(person);

var fido = new Animal("Hund", "Fido");
Console.WriteLine(fido.name + " er en hund? " + fido.IsDog());

var newAnimals = new List<Animal>();

while (true) {
    Console.WriteLine("Do you want to create a new animal? y/n");
    string answer = Console.ReadLine();
    if (answer.ToLower().Equals("y"))
    {
        Console.WriteLine("What species is the animal?");
        string species = Console.ReadLine();
        Console.WriteLine("What is the name of the animal?");
        string name = Console.ReadLine();
        newAnimals.Add(new Animal(species, name));
    } else
    {
        break;
    }
}

if(newAnimals.Count > 0)
{
    Console.WriteLine("Animals created: ");
    foreach (var animal in newAnimals)
    {
        Console.WriteLine(animal);
    }
}



var list = new MyList();
list.AddNumber(1);
list.AddNumber(10);
list.AddNumber(100);
list.PrintNumbers();

var rndIntList = new MyList();
var rnd = new Random();

for (int i = 0; i < 10; i++)
{
    rndIntList.AddNumber(rnd.Next(11));
}
Console.WriteLine("Random ints list:");
rndIntList.PrintNumbers();

Console.ReadLine();