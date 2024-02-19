//Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.

Console.WriteLine("Add first number x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Add second number y:");
int y = int.Parse(Console.ReadLine());

string order;

if (x < y)
{
    order = $"{x} {y}";
}else
{
    order = $"{y} {x}";
}

Console.WriteLine($"Order: {order}");
