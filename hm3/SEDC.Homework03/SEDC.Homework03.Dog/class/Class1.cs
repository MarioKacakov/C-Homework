namespace SEDC.Homework03.Dog 
{
    public class Dog
    {
        public Dog(string name, string race, string color) 
        { 
            dogName = name;
            dogRace = race;
            dogColor = color;

            dogEat();
            dogPlay();
            dogChaseTail();
        }

        public string dogName { get; set; }
        public string dogRace { get; set; }
        public string dogColor { get; set; }


        public void dogEat()
        {
            Console.WriteLine("The dog is now eating");
        }

        public void dogPlay()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void dogChaseTail()
        {
            Console.WriteLine("The dog is now chasing its tail");
        }





    }

}
