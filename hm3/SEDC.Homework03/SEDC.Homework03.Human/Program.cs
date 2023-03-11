using SEDC.Homework03.Human;

Console.Write("Enter first name: ");
string personName = Console.ReadLine();

Console.Write("Enter last name: ");
string lastName = Console.ReadLine();

Console.Write("Enter age: ");
bool tryParseAge = int.TryParse(Console.ReadLine(), out int personAge);

if (personName != "")
{
    if (lastName != "")
    {
        if (tryParseAge)
        {
            Human inputHuman = new Human(personName, lastName, personAge);

        }
        else { Console.WriteLine("Invalid input"); }
    }
    else { Console.WriteLine("Invalid input"); }

}
else { Console.WriteLine("Invalid input"); }

