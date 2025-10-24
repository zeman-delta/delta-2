// 1)
public class Osoba
{
    public string Jmeno { get; set; }

    public void PredstavSe()
    {
        Console.WriteLine($"Jméno: {Jmeno}");
    }
}

public class Student : Osoba
{
    public string Skola { get; set; }

    public void Studuj()
    {
        Console.WriteLine($"{Jmeno} studuje na {Skola}");
    }
}

class Program
{
    static void Main()
    {
        // Student s = new Student { Jmeno = "Petr", Skola = "DELTA" };
        
        Student s = new Student();
        s.Jmeno = "Petr";
        s.Skola = "DELTA";
        
        s.PredstavSe();
        s.Studuj();
    }
}



// 2)
public class Vozidlo
{
    public virtual void Jizda()
    {
        Console.WriteLine("Vozidlo jede");
    }
}

public class Auto : Vozidlo
{
    public override void Jizda()
    {
        Console.WriteLine("Auto jede po silnici");
    }
}

public class Kolo : Vozidlo
{
    public override void Jizda()
    {
        Console.WriteLine("Kolo jede po silnici");
    }
}



// 3)
public class Zamestnanec 
{
    public string Jmeno { get; set; }
    public double Plat { get; set; }
    
    public Zamestnanec(string jmeno, double plat)
    {
        Jmeno = jmeno;
        Plat = plat;
    }
}

public class Manazer : Zamestnanec
{
    public double Bonus { get; set; }

    public Manazer(string jmeno, double plat, double bonus) : base(jmeno, plat)
    {
        Bonus = bonus;
    }
}



// 4)
public class Postava
{
    public int SilaUtoku { get; set; }

    public Postava(int silaUtoku)
    {
        SilaUtoku = silaUtoku;
    }

    public virtual void Utoc()
    {
        Console.WriteLine($"Postava utoci s silou {SilaUtoku}");
    }
}

public class Bojovnik : Postava
{
    public Bojovnik(int silaUtoku) : base(silaUtoku)
    {
    }
    
    public override void Utoc()
    {
        Console.WriteLine($"Bojovnik utoci s silou {SilaUtoku * 2}");
    }
}

public class Mag : Postava
{
    public int Mana { get; set; }

    public Mag(int silaUtoku, int mana) : base(silaUtoku)
    {
        Mana = mana;
    }
    
    public override void Utoc()
    {
        Console.WriteLine($"Mag utoci s silou {SilaUtoku + Mana}");
    }
}



// 5)
public abstract class Tvar
{
    public abstract double VypocitejObsah();
}

public class Kruh : Tvar
{
    public double Radius { get; set; }

    public Kruh(double radius)
    {
        Radius = radius;
    }

    public override double VypocitejObsah()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Obdelnik : Tvar
{
    public double Sirka { get; set; }
    public double Vyska { get; set; }

    public Obdelnik(double sirka, double vyska)
    {
        Sirka = sirka;
        Vyska = vyska;
    }

    public override double VypocitejObsah()
    {
        return Sirka * Vyska;
    }
}

public class Trojuhelnik : Tvar
{
    public double Základ { get; set; }
    public double Vyska { get; set; }

    public Trojuhelnik(double základ, double vyska)
    {
        Základ = základ;
        Vyska = vyska;
    }

    public override double VypocitejObsah()
    {
        return (Základ * Vyska) / 2;
    }
}

