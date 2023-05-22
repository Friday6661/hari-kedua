## Type of Casting in C#

1. Implicit Casting in C#
   Implicit casting happens automatically when the conversion is safe and does not require extra code. Implicit casting works when the target type is larger than the source type. for example, an int can be implicitly cast to a long, float, or double.

   ```C#
   int num1 = 10;
   long num2 = num1;
   ```
   In this example, the integer variable num1 is implicitly cast to a long when it is assigned to the num2 variable.
2. Explicit Casting in C#

   Explicit casting works when the target type is smaller than the source type or when converting between incompatible types. Explicit casting requires the programmer to define the conversion using the appropriate cast operator explicitly. The syntax for explicit casting encloses the expression to be cast within parentheses, followed by the target type in square brackets.

   ```C#
   double num1 = 10.5;
   int num2 = (int)num1;
   ```
   let's look at a simple story to understand casting in C# better. In this example, we are casting the double value num 1 to an integer using the (int) cast operator. The resulting value is 10, the integer part of the double number.
3. Up-Casting
4. Down-Casting
