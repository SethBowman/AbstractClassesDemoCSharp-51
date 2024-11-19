namespace AbstractClassesDemoCSharp_51;

public class Snake : Animal
{
    public override int Age { get; set; }

    public override void Move()
    {
        Console.WriteLine("Snake is slithering..");
    }

    public override void Eat()
    {
        Console.WriteLine("Snake is eating..");
    }
}