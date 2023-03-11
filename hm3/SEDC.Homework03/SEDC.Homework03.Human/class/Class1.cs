namespace SEDC.Homework03.Human
{
    public class Human
    {

        public Human(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            GetPersonStats();
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetPersonStats()
        {
            Console.WriteLine($"Hello, this is {FirstName} {LastName} and he is {Age} years old");
        }


    }
}
