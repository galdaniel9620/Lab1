//Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y.
// In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar, “indivizibil”.

Console.WriteLine("Add first number x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Add second number y:");
int y = int.Parse(Console.ReadLine());

string str;

if (x % y == 0)
{
    str = $"{x} is divisible with {y}";
}
else
{
    str = $"{x} is indivisible with {y}";
}

Console.WriteLine(str);
