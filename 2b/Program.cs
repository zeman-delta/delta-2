namespace _2b;

class Program
{
    public static void Main(string[] args)
    {
        int[] pole = new int[10];
        int min = 100;
        int max = 0;
        float soucet = 0;

        for (int i = 0; i < 10; i++)
        {
            pole[i] = Rnd(1, 100);
            Console.Write(pole[i] + ", ");
            soucet += pole[i];
    
            if (pole[i] < min) min = pole[i];
            if (pole[i] > max) max = pole[i];
        }

        Console.WriteLine();

        Console.WriteLine("Min: {0}, Max: {1}, Prum: {2}", min, max, soucet/10);

        Console.WriteLine("Min: {0}, Max: {1}, Prum: {2}", pole.Min(), pole.Max(), pole.Average());

        Array.Sort(pole);

        for (int i = 0; i < 10; i++)
        {
            Console.Write(pole[i] + ", ");
        }

        Console.WriteLine();

        Console.Read();
    }

    private static int Rnd(int min, int max)
    {
        Random rnd = new Random();
        return rnd.Next(min, max - 1);
    }
}
