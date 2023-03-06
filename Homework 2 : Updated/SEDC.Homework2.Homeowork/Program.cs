#region Task 1 / Homework 

Console.WriteLine("Press any key to start Task 1");
var test = Console.ReadKey();
Console.WriteLine();

int[] intArray = new int[6];

Console.Write("Enter you first number now: ");
bool tryParse1 = int.TryParse(Console.ReadLine(), out int num1);
Console.Write("Enter you second number now: ");
bool tryParse2 = int.TryParse(Console.ReadLine(), out int num2);
Console.Write("Enter you third number now: ");
bool tryParse3 = int.TryParse(Console.ReadLine(), out int num3);
Console.Write("Enter you fourth number now: ");
bool tryParse4 = int.TryParse(Console.ReadLine(), out int num4);
Console.Write("Enter you fifth number now: ");
bool tryParse5 = int.TryParse(Console.ReadLine(), out int num5);
Console.Write("Enter you sixt number now: ");
bool tryParse6 = int.TryParse(Console.ReadLine(), out int num6);

intArray[0] = num1;
intArray[1] = num2;
intArray[2] = num3;
intArray[3] = num4;
intArray[4] = num5;
intArray[5] = num6;

if (tryParse1 && tryParse2 && tryParse3 && tryParse4 && tryParse5 && tryParse6 == true)
{
    int sum = 0;

    if (num1 % 2 == 0) { sum += num1; }
    if (num2 % 2 == 0) { sum += num2; }
    if (num3 % 2 == 0) { sum += num3; }
    if (num4 % 2 == 0) { sum += num4; }
    if (num5 % 2 == 0) { sum += num5; }
    if (num6 % 2 == 0) { sum += num6; }

    Console.WriteLine($"The sum of the even numbers in the array is {sum}");


}
else
{
    Console.WriteLine("Invalid input");
}

#endregion

#region Task 2 / Homework

Console.WriteLine();
Console.WriteLine("Press any key to start Task 2");
Console.ReadKey();
Console.WriteLine();


Console.Write("Enter a number 1 OR 2 to pick a group of students: ");

bool studentNumberInput = int.TryParse(Console.ReadLine(), out int studentNumber);

string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
string[] studentsG2 = new string[] {"Mario", "Dimitar", "Mitko", "Angel", "Zodran" };

if (studentNumber == 1)
{
    foreach (string Arrayitem in studentsG1)
    {
        Console.WriteLine(Arrayitem);
    }
}
else if (studentNumber == 2)
{
    foreach (string Arrayitem in studentsG2)
    {
        Console.WriteLine(Arrayitem);
    }
}
else Console.WriteLine("Incorrect input, please pick number 1 or 2");

#endregion

#region Exercise 4

string[] arrayWithWords = new string[] { "Random", "Words" };
double[] arrayWithDecimalNumbers = new double[] {2.4, 6.5};
char[] arrayWithChars = new char[] {'A', 'B'};
bool[] arrayWithTrueOrFalse = new bool[] {true, false};
int[][] arrayWithArray = new int[][]
{
    new int[] {1},
    new int[] {2}
};

#endregion

#region Exercise 6

Console.WriteLine();
Console.WriteLine("Press any key to start Exercise 6");
Console.ReadKey();
Console.WriteLine();

string[] namesArray = new string[] { }; 
int count = 0;
int arrayCount = 0;

while (true)
{
    arrayCount++;
    Array.Resize(ref namesArray, arrayCount);
    Console.Write("Enter a name: ");
    string firstName = Console.ReadLine();
    namesArray[count] = firstName;
    count++; 

    Console.Write("Do you want to enter another name? (Y/N): ");
    string choice = Console.ReadLine();

    if (choice.ToUpper() != "Y") 
    {
        break; 
    }
}

Console.WriteLine("\nAll names entered:");

for (int i = 0; i < count; i++) 
{
    Console.WriteLine(namesArray[i]);
}

#endregion

#region Exercise 5

Console.WriteLine();
Console.WriteLine("Press any key to start Exercise 5");
Console.ReadKey();
Console.WriteLine();

int[] numArray = new int[5];

Console.Write("Enter you first number now: ");
bool tryParse7 = int.TryParse(Console.ReadLine(), out int num7);
Console.Write("Enter you second number now: ");
bool tryParse8 = int.TryParse(Console.ReadLine(), out int num8);
Console.Write("Enter you third number now: ");
bool tryParse9 = int.TryParse(Console.ReadLine(), out int num9);
Console.Write("Enter you fourth number now: ");
bool tryParse10 = int.TryParse(Console.ReadLine(), out int num10);
Console.Write("Enter you fifth number now: ");
bool tryParse11 = int.TryParse(Console.ReadLine(), out int num11);

numArray[0] = num7;
numArray[1] = num8;
numArray[2] = num9;
numArray[3] = num10;
numArray[4] = num11;

if (tryParse7 && tryParse8 && tryParse9 && tryParse10 && tryParse11 == true)
{
    int sum = num7 + num8 + num9 + num10 + num11;

    Console.WriteLine($"The sum of the even numbers in the array is {sum}");

}
else { Console.WriteLine("Invalid input"); }

#endregion