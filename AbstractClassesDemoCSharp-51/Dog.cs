namespace AbstractClassesDemoCSharp_51;

public class Dog : Animal
{
    //Override keyword must provided when implementing abstract members
    public override int Age { get; set; }

    public override void Move()
    {
        Console.WriteLine("Dog is running..");
    }
}