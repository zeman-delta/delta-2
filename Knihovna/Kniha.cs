namespace Knihovna;

public class Kniha: IVypisovatelny
{
    public string Nazev { get; set; }
    public string Autor { get; set; }
    public int RokVydani { get; set; }
    public int PocetStran { get; set; }

    public Kniha(string nazev, string autor, int rokVydani, int pocetStran)
    {
        Nazev = nazev;
        Autor = autor;
        RokVydani = rokVydani;
        PocetStran = pocetStran;
    }

    public string VratInformace()
    {
        return $"📖 {Nazev} | {Autor} | {RokVydani} | {PocetStran} stran";
    }


    public static Kniha VytvoreniKnihy()
    {
        Console.Write("Zadej název knihy: ");
        string nazev = Console.ReadLine();

        Console.Write("Zadej autora: ");
        string autor = Console.ReadLine();

        Console.Write("Zadej rok vydání: ");
        int rok = int.Parse(Console.ReadLine());

        Console.Write("Zadej počet stran: ");
        int pocetStran = int.Parse(Console.ReadLine());

        return new Kniha(nazev, autor, rok, pocetStran);
    }
    
}