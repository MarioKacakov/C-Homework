using SEDC.Homework03.Dog;

Console.Write("Enter dog name: ");
string dogName = Console.ReadLine();

Console.Write("Enter dog race: ");
string dogRace = Console.ReadLine();

Console.Write("Enter dog color: ");
string dogColor = Console.ReadLine();

Console.Write("Enter 1, 2 or 3 to see what the dog is doing: ");
bool dogMood = int.TryParse(Console.ReadLine(), out int mood);

if (dogName != "")
{
    if (dogRace != "")
    {
        if (dogColor != "")
        {
            if (dogMood)
            {
                if (mood == 1)
                {
                    Dog userInput = new Dog(dogName, dogRace, dogColor);
                    Console.WriteLine($"This is {dogName} it is a {dogRace}, it's colour is {dogColor}");
                    userInput.dogEat();
                }
                else if (mood == 2)
                {
                    Dog userInput = new Dog(dogName, dogRace, dogColor);
                    Console.WriteLine($"This is {dogName} it is a {dogRace}, it's colour is {dogColor}");
                    userInput.dogPlay();
                }
                else if (mood == 3)
                {
                    Dog userInput = new Dog(dogName, dogRace, dogColor);
                    Console.WriteLine($"This is {dogName} it is a {dogRace}, it's colour is {dogColor}");
                    userInput.dogChaseTail();
                }
                else { Console.WriteLine("Invalid input"); }
            }
            else { Console.WriteLine("Invalid input"); }
        }
        else { Console.WriteLine("Invalid input"); }
    }
    else { Console.WriteLine("Invalid input"); }
}
else { Console.WriteLine("Invalid input"); }
