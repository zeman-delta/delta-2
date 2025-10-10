namespace Knihovna;

public class DebugAuth: IAuth
{
    
    public User? Auth(List<User> users, string name, string password)
    {
        return users.First();
    }
    
}