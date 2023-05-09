class Cat {
    public string Name;
    public int Age;
    public int Height;


    public void Eat() {
        Console.WriteLine("Cat Eat");
    }

    public void Sleep() {
        Console.WriteLine("Cat Sleep");
    }
}
class Program {
    static void Main() {
        Cat simba = new Cat();
        
    simba.Age = 1;
    simba.Name = "Simba";
    simba.Height = 1;

    Console.WriteLine(simba.Name);
    Console.WriteLine(simba.Age);
    Console.WriteLine(simba.Height);
    }
    
}
