
using lek10ef.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;

Console.WriteLine("Hello.");

BilContext bilContext = new BilContext();
//bilContext.Database.EnsureCreated();

using (var context = new BilContext())
{
    // Hent alle personer med deres biler
    var personer = context.Personer
                           .Include(p => p.Biler)
                           .ToList();

    foreach (var person in personer)
    {
        Console.WriteLine($"Person: {person.Name}");

        foreach (var bil in person.Biler)
        {
            Console.WriteLine($"  Bil: {bil.Name}, År: {bil.Year}, Vægt: {bil.Weight}");
        }

        Console.WriteLine("Vil du ændre navn? Så skriv det ændrede navn:");
        person.Name = Console.ReadLine();
        context.SaveChanges();

        Console.WriteLine($"Person: {person.Name}");

    }
}

