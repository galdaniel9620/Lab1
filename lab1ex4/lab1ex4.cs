//Scrieti un program care va afisa semnul unui numar citit de la tastatura
//• Daca numarul este pozitiv, va afisa “+”
//• Daca numarul este negativ, va afisa “-”
//• Daca numarul este 0, va afisa “0”

Console.WriteLine("Add a number: a");
int a = int.Parse(Console.ReadLine());


string symbol;

if (a == 0)
{
    symbol = "0";
}else if (a < 0)
{
    symbol="-";
}else
{
    symbol = "+";
}

Console.WriteLine($"Symbol of the number is: {symbol}");
