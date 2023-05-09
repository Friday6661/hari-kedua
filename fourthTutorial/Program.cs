// See https://aka.ms/new-console-template for more information
class Human {
    public string name;
    public int age;
    private int _salary;

    //Constructor
    public Human(string name, int age, int salary) {
            this.name = name;
            this.age = age;
            this._salary = salary;
        }

    //Method with parameters
    public void SetSalary(int x) {
        _salary = x;
    }
    public int GetSalary() {
        return _salary;
    }

}

static class Program {
    static void Main() {

        Human h2 = new Human("John", 1, 300);
        int x = h2.GetSalary();
        h2.SetSalary(x + 10);
        Console.WriteLine(x);
        Console.WriteLine(h2.GetSalary());

    }
}
