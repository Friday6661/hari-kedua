class Program {
    static void Main() {
        int a = 10;
        int b = a;
        b = 11;
        Console.WriteLine(a);
        Console.WriteLine(b);

        MyClass myClassA = new(3,4);
        MyClass myClassB = myClassA;
        myClassB.y = 5;
        Console.WriteLine($"\nMyClassA {myClassA.x}, {myClassA.y}");
        Console.WriteLine($"\nMyClassB {myClassB.x}, {myClassB.y}");

        int[] intArrA = {1, 2, 3};
        int[] intArrB = intArrA;
        intArrB[0] = 4;
        Console.WriteLine("\nintArrA = ");
        foreach(int x in intArrA) {
            Console.WriteLine(x + ", ");
        }
        Console.WriteLine("\nintArrB = ");
        foreach(int x in intArrB) {
            Console.WriteLine(x + ", ");
        }

    }
}
class MyClass {
    public int x;
    public int y;
    public MyClass(int a, int b) {
        x = a;
        y = b;
    }
}