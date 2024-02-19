//Scrieti un program care interschimba valoarea a doua variabile intregi.

Console.WriteLine("Add a number x:");
int x = int.Parse(Console.ReadLine());

int x1 = x / 10;
int x2 = x % 10;

int sum = x1 + x2;

Console.WriteLine($"digits sum: {sum}");