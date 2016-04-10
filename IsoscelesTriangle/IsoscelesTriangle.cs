/*
 * 
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©

*
*/

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        int triangleSideSize = 4;
        int triangleSideCount = 1;
        int spaceCount = 1;
        char symbol = '\u00A9';
        while (spaceCount <= (triangleSideSize - triangleSideCount))
        {
            Console.Write(" ");
            spaceCount++;
        }
        Console.WriteLine(symbol);
        triangleSideCount++;
        spaceCount = 1;
        while (triangleSideCount <= triangleSideSize - 1)
        {
            while (spaceCount <= (triangleSideSize - triangleSideCount))
            {
                Console.Write(" ");
                spaceCount++;
            }
            Console.Write(symbol);
            spaceCount = 1;
            while (spaceCount <= (triangleSideCount * 2 - 3))
            {
                Console.Write(" ");
                spaceCount++;
            }
            Console.WriteLine(symbol);
            triangleSideCount++;
            spaceCount = 1;
        }
        while (spaceCount <= triangleSideSize)
        {
            Console.Write(symbol + " ");
            spaceCount++;
        }
        Console.WriteLine();
    }
}
