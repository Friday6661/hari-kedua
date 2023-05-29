﻿using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        ArrayList myArrayList = new();

        // Adding elements to the array list
        myArrayList.Add("Apple");
        myArrayList.Add("Banana");
        myArrayList.Add("Cherry");
        myArrayList.Add("Cat");

        // Accessing elements in the ArrayList
        Console.WriteLine("Element at index 1: " + myArrayList[1]);
        Console.WriteLine("Element at index 2: " + myArrayList[2]);

        // Displaying all elements in the ArrayList
        Console.WriteLine("All elements: ");
        foreach (string element in myArrayList)
        {
            Console.WriteLine(element);
        }

        // Removing elements from the ArrayList
        myArrayList.RemoveRange(1, 3);

        // Displaying all elements in the ArrayList
        Console.WriteLine("All elements: ");
        foreach (string element in myArrayList)
        {
            Console.WriteLine(element);
        }

    }
}