namespace AbstractClassesDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        var beagle = new Dog();
        beagle.Move();
        beagle.Eat();

        var python = new Snake();
        python.Move();
        python.Eat();

        var circleA = new Circle(25);
        var areaOfCircleA = circleA.CalculateArea();
        Console.WriteLine(areaOfCircleA);
    }
}
