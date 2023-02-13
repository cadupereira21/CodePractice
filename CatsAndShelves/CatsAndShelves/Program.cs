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

FindNumberOfJumps(shelveTower, new Cat());

int FindNumberOfJumps(Shelve[] shelve, Cat cat)
{
    var numberOfJumps = 0;
    cat.JumpToShelve(shelve[0], shelve[0]);

    while (shelve[^1].IsCatHere)
    {
        
    }
    
    return numberOfJumps;
}