// program In

/*
class Program {
    static void Main() {
        int number = 10;
        PrintDouble(in number);
    }

    static void PrintDouble(in int x) {
        Console.WriteLine(x * 2);
        x = 20; // error, please read the error
        //error CS8331
//: Cannot assign to variable 'x' or use it as the right hand side of a ref a 
//ssignment because it is a readonly variable [D:\Jamal-bootcamp\hari-kedua\h 
//ari-7\refoutin\refoutin.csproj]
    }
}
*/

// Program Out
class Program {
    static void Main() {
        int number1 = 10;
        MultiplyAndAddByTwo(ref number1, out int number2);
        Console.WriteLine(number1);
        Console.WriteLine(number2);
    }

    static void MultiplyAndAddByTwo(ref int x, out int y) {
        y = (x * 2) + 2;
        x = y + 1;
    }
}