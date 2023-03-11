using SEDC.Homework03.Student;

Student student = new Student("Mario", "SEDC", "G5");
Student student2 = new Student("Vasko", "SEDC", "G7");
Student student3 = new Student("David", "SEDC", "G3");
Student student4 = new Student("Mirko", "SEDC", "G1");
Student student5 = new Student("Marija", "SEDC", "G9");

string[] arrayStudent = new string[] {student.Name, student2.Name, student3.Name, student4.Name, student5.Name};

Console.Write("Enter the name of the student: ");
string userInput = Console.ReadLine();

if (userInput.ToUpper() == arrayStudent[0].ToUpper())
{
    Console.WriteLine($"The student's name is {student.Name}, he goes to {student.Academy}, he is in {student.Group} group");

}
else if (userInput.ToUpper() == arrayStudent[1].ToUpper())
{
    Console.WriteLine($"The student's name is {student2.Name}, he goes to {student2.Academy}, he is in {student2.Group} group");
}
else if (userInput.ToUpper() == arrayStudent[2].ToUpper())
{
    Console.WriteLine($"The student's name is {student3.Name}, he goes to {student3.Academy}, he is in {student3.Group} group");
}
else if (userInput.ToUpper() == arrayStudent[3].ToUpper())
{
    Console.WriteLine($"The student's name is {student4.Name}, he goes to {student4.Academy}, he is in {student4.Group} group");
}
else if (userInput.ToUpper() == arrayStudent[4].ToUpper())
{
    Console.WriteLine($"The student's name is {student5.Name}, she goes to {student5.Academy}, he is in {student5.Group} group");
}
else 
{
    Console.WriteLine("No user by that name has been found");
}
