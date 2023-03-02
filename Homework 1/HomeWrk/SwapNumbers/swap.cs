// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter A1: ");
string a = Console.ReadLine();
Console.WriteLine("Enter B1: ");
string b = Console.ReadLine();

int a1;
int b1;

bool aParse = int.TryParse(a, out b1);
bool bParse = int.TryParse(b, out a1);


Console.WriteLine("A1 is :" + a1);
Console.WriteLine("B1 is :" + b1);