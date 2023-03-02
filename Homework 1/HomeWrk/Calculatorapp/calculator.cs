// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter you first number");
string a = Console.ReadLine();
Console.WriteLine("Enter you second number");
string b = Console.ReadLine();
Console.WriteLine("One the next one please select one of the operators +, - , * , /");
string c = Console.ReadLine();

int a1;
int b1;

bool aParse = int.TryParse(a, out a1);
bool bParse = int.TryParse(b, out b1);


if (c == "+")
{
    Console.WriteLine(a1 + b1);
}
else if (c == "-")
{
    Console.WriteLine(a1 - b1);

}
else if (c == "*") {
    Console.WriteLine(a1 * b1);

} else if (c == "/") {

    Console.WriteLine(a1 / b1);

}

