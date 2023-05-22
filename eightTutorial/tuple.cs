namespace Namespace {
    static class Program {
        static void Main() {
            const int a = 5;
            const string b = "Hell";

            (int c, string d) = MyMethod(a, b);
            Console.WriteLine($"c = {c}, d = {d}");

            (int, string) tuple = MyMethod(a, b);
            Console.WriteLine($"tuple.Item1 = {tuple.Item1}, tuple.Item = {tuple.Item2}");
            
            int x = MyMethodInt(a);
            Console.WriteLine($"x = {x}");
        }

        static (int, string) MyMethod(string b, int a) {
            return (a, b);
        }

        static (int, string) MyMethod(int a, string b) {
            return (a, b);
        }

        static int MyMethodInt(int a) {
            return a;
        }

    }
}