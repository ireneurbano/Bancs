namespace Bancs.Classes;

public class User
{
    public int id;
    public string Name { get; set; }
    private string password;

    public User(int id, string name, string password)
    {
        this.id = id;
        this.Name = name;
        this.password = password;
    }

    public bool CheckPassword(string pass)
    {
        return pass == password;
    }

}