namespace Knihovna;

public class BasicAuth: IAuth
{
    
    public User? Auth(List<User> users, string name, string password)
    {
        User? user = null;
        
        foreach (User u in users)
        {
            if (u.Name == name && u.Login(password))
            {
                user = u;
                break;
            }
        }
        
        return user;
    }
    
}
