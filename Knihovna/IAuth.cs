namespace Knihovna;

public interface IAuth
{

    public User? Auth(List<User> users, string name, string password);

}