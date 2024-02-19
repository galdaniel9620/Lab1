//Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui

Console.WriteLine("Introduceti lungimea");
int lungime = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti latimea");
int latime = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti inaltimea");
int inaltime = int.Parse(Console.ReadLine());

int volum = lungime * latime * inaltime;
Console.WriteLine($"Volumul paralelipiped dreptunghic este: {volum}");
