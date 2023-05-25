namespace vectorSubstractionLib;
using System;

public class VectorSubstraction
{
    public int X { get; set; }
    public int Y { get; set; }

    public VectorSubstraction(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Operator overloading untuk pengurangan vektor
    public static VectorSubstraction operator -(VectorSubstraction v4, VectorSubstraction v5)
    {
        return new VectorSubstraction(v4.X - v5.X, v4.Y - v5.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}