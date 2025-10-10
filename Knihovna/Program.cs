namespace Knihovna;

class Program
{
    static void Main(string[] args)
    {
        Knihovna knihovna = new Knihovna("Městská knihovna");
        
        knihovna.Users.Add(new User("Karel", "admin", "admin"));
        knihovna.Users.Add(new User("user", "user", "user"));
        
        IAuth auth = new DebugAuth();

        Console.WriteLine("Zadej jmeno:");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Zadej heslo:");
        string heslo = Console.ReadLine();

        User? user = auth.Auth(knihovna.Users, jmeno, heslo);
        
        if (user == null)
        {
            Console.WriteLine("Nespravne jmeno nebo heslo.");
            return;
        }
        
        bool running = true;

        while (running)
        {
            VypisHlavniMenu();
            Console.Write("Zdaej číslo akce: ");
            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    knihovna.PridejKnihu(Kniha.VytvoreniKnihy());
                    break;

                case "2":
                    Console.Write("Zadej název knihy k odebrání: ");
                    string odebratNazev = Console.ReadLine();
                    knihovna.OdeberKnihu(odebratNazev);
                    break;

                case "3":
                    Console.Write("Zadej název knihy: ");
                    string hledanyNazev = Console.ReadLine();
                    var nalezena = knihovna.NajdiKnihuPodleNazvu(hledanyNazev);
                    if (nalezena != null)
                        VypisovacInformaci.VypisInformaci(nalezena);
                    else
                        Console.WriteLine("Kniha nebyla nalezena.");
                    break;

                case "4":
                    Console.Write("Zadej autora: ");
                    string hledanyAutor = Console.ReadLine();
                    knihovna.VypisKnihyOdAutora(hledanyAutor);
                    break;

                case "5":
                    knihovna.VypisVsechnyKnihy();
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Program ukončen.");
                    break;
                
                case "7":
                    VypisovacInformaci.VypisInformaci(user);
                    break;

                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
        }
    }

    public static void VypisHlavniMenu()
    {
        Console.WriteLine("\n===== MENU =====");
        Console.WriteLine("1. Přidat knihu");
        Console.WriteLine("2. Odebrat knihu");
        Console.WriteLine("3. Vyhledat knihu podle názvu");
        Console.WriteLine("4. Vyhledat knihy podle autora");
        Console.WriteLine("5. Vypsat všechny knihy");
        Console.WriteLine("6. Konec");
    }
    
}
