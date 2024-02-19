//Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura

Console.WriteLine("Add first number: a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Add second number: b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Add third number: c");
int c = int.Parse(Console.ReadLine());

int arithmeticMean = (a + b + c) / 3;

Console.WriteLine($"Arithmetic mean is: {arithmeticMean}");
