using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange antalet rader för triangeln: ");
        int rader = int.Parse(Console.ReadLine());

        
        for (int i = 1; i <= rader; i++)
        {
            
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine(); 
        }
    }
}

