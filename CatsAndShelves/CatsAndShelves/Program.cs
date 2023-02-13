// See https://aka.ms/new-console-template for more information
using System;
using CatsAndShelves;

Console.Write("Insira a quantidade de prateleiras: ");
var numberOfShelves = int.Parse(Console.ReadLine()!);

Shelve[] shelveTower = new Shelve[numberOfShelves];

for (var i = 0; i < shelveTower.Length; i++)
{
    shelveTower[i] = new Shelve(i);
}

Console.Write("Número de pulos: " + FindNumberOfJumps(shelveTower, new Cat()));

int FindNumberOfJumps(Shelve[] shelve, Cat cat)
{
    var numberOfJumps = 0;
    cat.JumpToShelve(shelve[0], shelve[0]);
    
    // Console.WriteLine($"Cat Position: {cat.Position}");
    // foreach (var s in shelve)
    // {
    //     Console.WriteLine($"Is cat here? {s.IsCatHere}");
    // }

    while (!shelve[^1].IsCatHere)
    {
        try
        {
            cat.JumpToShelve(shelve[cat.Position], shelve[cat.Position+3]);
        }
        catch (IndexOutOfRangeException e)
        {
            cat.JumpToShelve(shelve[cat.Position], shelve[cat.Position + 1]);
        }

        numberOfJumps += 1;
    }
    
    return numberOfJumps;
}