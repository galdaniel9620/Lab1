//Se citesc trei numere de la tastatura, x, y, z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.

Console.WriteLine("Add first number x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Add second number y:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Add third number z:");
int z = int.Parse(Console.ReadLine());
int temp;

if (x < y)
{
    temp = x;
    x = y;
    y = temp;
}
if (x < z)
{
    temp = x;
    x = z;
    z = temp;
}
if (y < z)
{
    temp = y;
    y = z;
    z = temp;
}


Console.WriteLine($"Numbers in descending order: {x}, {y}, {z}");