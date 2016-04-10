using System;

class ASCIITable
{
    static void Main()
    {
        int i;
        for (i = 33; i <= 126; i++)
        {
            Console.Write((char)i);
        }
        Console.WriteLine();
    }
}
