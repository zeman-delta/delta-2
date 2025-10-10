namespace Knihovna;

public static class VypisovacInformaci
{
    
    public static void VypisInformaci(IVypisovatelny objekt)
    {
        Console.WriteLine(objekt.VratInformace());
    }
    
}