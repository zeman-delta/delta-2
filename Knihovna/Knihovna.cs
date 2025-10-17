namespace Knihovna;

public class Knihovna: IVypisovatelny
{
    public string Nazev { get; set; }
    public List<Kniha> Knihy { get;} = new List<Kniha>();
    
    public List<User> Users { get;} = new List<User>();

    public Knihovna(string nazev)
    {
        Nazev = nazev;
    }

    public void PridejKnihu(Kniha kniha)
    {
        Knihy.Add(kniha);
        Console.WriteLine($"Kniha \"{kniha.Nazev}\" byla přidána do knihovny.");
    }

    public void OdeberKnihu(string nazev)
    {
        Kniha? kniha = NajdiKnihuPodleNazvu(nazev);
        if (kniha != null)
        {
            Knihy.Remove(kniha);
            Console.WriteLine($"Kniha \"{nazev}\" byla odebrána.");
        }
        else
        {
            Console.WriteLine($"Kniha \"{nazev}\" nebyla nalezena.");
        }
    }

    public void VypisVsechnyKnihy()
    {
        if (Knihy.Count == 0)
        {
            Console.WriteLine("📚 Knihovna je prázdná.");
            return;
        }

        Console.WriteLine($"\nSeznam knih v knihovně \"{Nazev}\":");
        foreach (var kniha in Knihy)
        {
            VypisovacInformaci.VypisInformaci(kniha);
        }
    }

    public Kniha? NajdiKnihuPodleNazvu(string nazev)
    {
        return Knihy.Find(k => k.Nazev.Equals(nazev, StringComparison.OrdinalIgnoreCase));
    }

    public void VypisKnihyOdAutora(string autor)
    {
        var knihyOdAutora = Knihy.FindAll(k => k.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));

        if (knihyOdAutora.Count == 0)
        {
            Console.WriteLine($"Nebyly nalezeny žádné knihy od autora {autor}.");
        }
        else
        {
            Console.WriteLine($"\nKnihy od autora {autor}:");
            foreach (var kniha in knihyOdAutora)
            {
                VypisovacInformaci.VypisInformaci(kniha);
            }
        }
    }


    public string VratInformace()
    {
        return $"📚 {Nazev}";
    }
}