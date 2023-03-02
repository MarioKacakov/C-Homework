// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();
string d = Console.ReadLine();


int a1;
int b1;
int c1;
int d1;

bool aParse = int.TryParse(a, out a1);
bool bParse = int.TryParse(b, out b1);
bool cParse = int.TryParse(c, out c1);
bool dParse = int.TryParse(d, out d1);

int sum = (a1 + b1 + c1 + d1) / 4;

Console.WriteLine("The average of these four number is: " + sum);


