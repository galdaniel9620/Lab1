//Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
// In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.

Console.WriteLine("Add a number x:");
int x = int.Parse(Console.ReadLine());

string oddOrEven;

if (x % 2 == 0)
{
    oddOrEven = $"{x} is even";
}
else
{
    oddOrEven = $"{x} is odd";
}

Console.WriteLine(oddOrEven);