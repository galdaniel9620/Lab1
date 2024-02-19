//Scrieti un program care interschimba valoarea a doua variabile intregi.

Console.WriteLine("Add first number x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Add second number y:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine($"Initial: x={x}, y={y}");
int temp;

temp = x;
x = y;
y = temp;

Console.WriteLine($"After swapping: x={x}, y={y}");