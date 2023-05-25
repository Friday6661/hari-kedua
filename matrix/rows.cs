namespace RowLib;
using System;

public class Row
{
    private int[] elements;

    //Constructor
    public Row(int[] rowElements)
    {
        elements = rowElements;
    }

    public int Length
    {
        get { return elements.Length; }
    }

    public int this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    public override string ToString()
    {
        return string.Join(" ", elements);
    }

}