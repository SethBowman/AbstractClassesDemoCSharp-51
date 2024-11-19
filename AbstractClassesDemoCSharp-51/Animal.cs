namespace AbstractClassesDemoCSharp_51;

public abstract class Animal
{
    public abstract int Age { get; set; }
    public string Diet { get; set; }
    
    //Abstract methods (stubbed out methods)
    public abstract void Move();
    
    //Virtual methods (non stubbed out methods)
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating..");
    }
}