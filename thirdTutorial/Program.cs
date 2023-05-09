// See https://aka.ms/new-console-template for more information
class Cat {

    //Variables
    public int age;
    public string name;
    public string race;

    //Constructors
    public Cat() {}
    

    //Methode
    public void Eat(){
        Console.WriteLine("Eat Cat");
    }

    public void Sleep(){
        Console.WriteLine("Sleep Cat");
    }
}

static class Program {
    static void Main() {
        Cat simba = new Cat();
        simba.age = 1;
        simba.name = "Simba";
        simba.race = "Lion";

        simba.Sleep();
        simba.Eat();


        // Simbol $ digunakan untuk menambahkan {class dan methode} bisa ditambahkan dalam string 
        Console.WriteLine($"Cat name is {simba.name} age is {simba.age} race is {simba.race}");
    }
}