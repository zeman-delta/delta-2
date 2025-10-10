namespace Slovnik;

class Program
{
    // 1. Vytvoří a naplní slovník studentů
    static Dictionary<string, int> VytvorStudenty()
    {
        Dictionary<string, int> studenti = new Dictionary<string, int>
        {
            { "Petr", 1 },
            { "Jana", 2 },
            { "Karel", 3 },
            { "Lucie", 1 },
            { "Eva", 2 }
        };
        return studenti;
    }

    // 2. Výpis všech studentů a známek
    static void VypisStudenty(Dictionary<string, int> studenti)
    {
        Console.WriteLine("\nSeznam studentů:");
        foreach (var pair in studenti)
        {
            Console.WriteLine($"{pair.Key} → {pair.Value}");
        }
    }

    // 3. Úprava známky zadaného studenta
    static void UpravZnamku(Dictionary<string, int> studenti)
    {
        Console.Write("\nZadej jméno studenta, kterému chceš změnit známku: ");
        string jmeno = Console.ReadLine();

        if (studenti.ContainsKey(jmeno))
        {
            Console.Write($"Zadej novou známku pro {jmeno}: ");
            if (int.TryParse(Console.ReadLine(), out int novaZnamka))
            {
                studenti[jmeno] = novaZnamka;
                Console.WriteLine($"Známka studenta {jmeno} byla změněna na {novaZnamka}.");
            }
            else
            {
                Console.WriteLine("Neplatný vstup – očekává se číslo.");
            }
        }
        else
        {
            Console.WriteLine("Student nebyl nalezen.");
        }
    }

    // 4. Výpis známky podle zadaného jména
    static void VypisZnamkuStudenta(Dictionary<string, int> studenti)
    {
        Console.Write("\nZadej jméno studenta, jehož známku chceš zjistit: ");
        string jmeno = Console.ReadLine();

        if (studenti.TryGetValue(jmeno, out int znamka))
        {
            Console.WriteLine($"Student {jmeno} má známku: {znamka}");
        }
        else
        {
            Console.WriteLine("Student nebyl nalezen.");
        }
    }

    static void Main()
    {
        Dictionary<string, int> studenti = VytvorStudenty();

        VypisStudenty(studenti);      // výpis všech
        UpravZnamku(studenti);        // úprava
        VypisStudenty(studenti);      // znovu výpis po změně
        VypisZnamkuStudenta(studenti); // výpis jednoho studenta
    }
}
