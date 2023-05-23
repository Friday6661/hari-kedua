namespace Object {
    static class Program {

        /*
        static void Main() {
            int x = 5;
            dynamic obj1 = x;// Boxing
            Console.WriteLine(obj1);

            int a = 10;
            dynamic obj2 = a;
            //string str = obj2; // will throw an exception if not use ToString
            string str = obj2.String();
            Console.WriteLine(str);

            int c = 11;
            dynamic obj3 = c;
            long d = obj3;
            Console.WriteLine(d);

            dynamic obj4 = "Hello, World!";
            if (obj4 is string x2) {
                Console.WriteLine(x2);
            }

            dynamic obj5 = "Hello, World!";
            string str5 = obj5;
            if (str5 != null) {
                Console.WriteLine(str5);
            }
        }
    */
    static void Main() {
        int x = 5;
        object obj1 = x;
        int y = (int)obj1;
        Console.WriteLine(y);

        int a = 10;
        object obj2 = a;
        //string str = (string)obj2;
        string str = ((int)obj2).ToString();
        Console.WriteLine(str);

        int c = 11;
        object obj3 = c;
        // long d = (long)(int)obj3;
        long d = (int)obj3;
        Console.WriteLine(d);

        float e = 12.2f;
        object obj6 = e;
        //int i = (int)obj6;
        int i = (int)(float)obj6;
        Console.WriteLine(i);

        object obj4 = "Hello, world! 1";
        if (obj4 is string) {
            string str4 = (string)obj4;
            Console.WriteLine(str4);
        }

        object obj5 = "Hello, world! 2";
        if (obj5 is string str5) {
            Console.WriteLine(str5);
        }

        object obj7 = 23;
        int j = obj7 as int? ?? 0;
        Console.WriteLine(j);
    }
    }
}