namespace Metody;

using System;

class Program
{
    static void Main()
    {
        int[] pole = VytvorPole(10, 1, 100);

        Console.WriteLine("Pole:");
        VypisPole(pole);

        Console.WriteLine("Minimum: " + NajdiMinimum(pole));
        Console.WriteLine("Maximum: " + NajdiMaximum(pole));
        Console.WriteLine("Průměr: " + VypocitejPrumer(pole));
    }
    
    
    static int[] VytvorPole(int velikost, int min, int max)
    {
        Random rnd = new Random();
        int[] pole = new int[velikost];

        for (int i = 0; i < pole.Length; i++)
        {
            pole[i] = rnd.Next(min, max + 1);
        }

        return pole;
    }

    
    static void VypisPole(int[] pole)
    {
        foreach (int prvek in pole)
        {
            Console.Write(prvek + " ");
        }
        Console.WriteLine();
    }

    
    static int NajdiMinimum(int[] pole)
    {
        int min = pole[0];
        foreach (int prvek in pole)
        {
            if (prvek < min)
            {
                min = prvek;
            }
        }
        return min;
    }

    
    static int NajdiMaximum(int[] pole)
    {
        int max = pole[0];
        foreach (int prvek in pole)
        {
            if (prvek > max)
            {
                max = prvek;
            }
        }
        return max;
    }

    
    static double VypocitejPrumer(int[] pole)
    {
        int soucet = 0;
        foreach (int prvek in pole)
        {
            soucet += prvek;
        }
        return (double)soucet / pole.Length;
    }
    
}