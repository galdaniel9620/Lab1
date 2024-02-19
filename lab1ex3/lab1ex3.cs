//Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura


Console.WriteLine("Add a number: a");
int a = int.Parse(Console.ReadLine());


int lastDigit = a % 10;
Console.WriteLine($"The last digit of a number is: {lastDigit}");
