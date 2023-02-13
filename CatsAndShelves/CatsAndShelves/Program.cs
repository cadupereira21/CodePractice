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

var cat = new Cat();

Console.Write("Número de pulos: " + cat.FindNumberOfJumps(shelveTower));