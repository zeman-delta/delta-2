namespace List;

class Program
{
    // --- Hlavní metoda ---
    static void Main()
    {
        // 1. vytvoření listu
        List<int> cisla = VytvorList(20, 1, 100);
        VypisList(cisla, "Původní hodnoty:");

        // 2. přidání náhodného čísla
        PridatNahodneCislo(cisla, 1, 100);
        VypisList(cisla, "Po přidání čísla:");

        // 3. odstranění sudých čísel
        OdeberSudaCisla(cisla);
        VypisList(cisla, "Po odstranění sudých čísel:");

        // 4. odstranění prvků na sudých indexech
        OdeberSudeIndexy(cisla);
        VypisList(cisla, "Po odstranění sudých indexů:");

        // 5. vložení čísla na konkrétní pozici
        VlozNaPozici(cisla, 999, 2); // např. číslo 999 na index 2
        VypisList(cisla, "Finální obsah Listu:");
    }
    
    
    // 1. Vytvoření Listu s náhodnými čísly
    static List<int> VytvorList(int pocet, int min, int max)
    {
        Random rnd = new Random();
        List<int> list = new List<int>();
        for (int i = 0; i < pocet; i++)
        {
            list.Add(rnd.Next(min, max + 1));
        }
        return list;
    }

    // 2. Výpis hodnot v Listu
    static void VypisList(List<int> list, string popis)
    {
        Console.WriteLine(popis);
        foreach (int c in list)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\n");
    }

    // 3. Přidání jednoho náhodného čísla
    static void PridatNahodneCislo(List<int> list, int min, int max)
    {
        Random rnd = new Random();
        int nove = rnd.Next(min, max + 1);
        list.Add(nove);
        Console.WriteLine($"Přidáno číslo: {nove}\n");
    }

    // 4. Odstranění všech sudých hodnot
    static void OdeberSudaCisla(List<int> list)
    {
        list.RemoveAll(x => x % 2 == 0);
        Console.WriteLine("Odstraněna všechna sudá čísla.\n");
    }

    // 5. Odstranění všech prvků na sudých indexech
    static void OdeberSudeIndexy(List<int> list)
    {
        // Jdeme od konce, aby se indexy neposouvaly
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                list.RemoveAt(i);
            }
        }
        Console.WriteLine("Odstraněny všechny prvky na sudých indexech.\n");
    }

    // 6. Přidání zadaného čísla na konkrétní pozici
    static void VlozNaPozici(List<int> list, int cislo, int index)
    {
        if (index < 0 || index > list.Count)
        {
            Console.WriteLine("Neplatný index!");
            return;
        }

        list.Insert(index, cislo);
        Console.WriteLine($"Vloženo číslo {cislo} na pozici {index}.\n");
    }

}
