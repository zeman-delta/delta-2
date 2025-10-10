namespace Knihovna;

public class User: IVypisovatelny
{
    
    public string Name { get; set; }
    public string Password { get; set; }
    public string Nickname { get; set; }


    public User(string name, string password, string nickname)
    {
        Name = name;
        Password = password;
        Nickname = nickname;
    }
    
    
    public bool Login(string password)
    {
        return Password == password;
    }
    
    public string VratInformace()
    {
        return $"{Name} | {Nickname}";
    }
    
}