﻿/*
 * Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
 * 
 * Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
 * Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 * 
 */



using System;
using System.Globalization;
using System.Threading;

class ComparingFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double diff = Math.Abs(a - b);
        double eps = 0.000001;
        Console.WriteLine(diff < eps ? "true" : "false");
        Console.WriteLine();
    }
}
