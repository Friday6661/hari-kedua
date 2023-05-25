namespace vectorAdditionLib;
using System;

public class VectorAddition
{
    public int X { get; set; }
    public int Y { get; set; }

    public VectorAddition(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Operator overloading untuk penjumlahan vektor
    public static VectorAddition operator +(VectorAddition v1, VectorAddition v2)
    {
        return new VectorAddition(v1.X + v2.X, v1.Y + v2.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }


}