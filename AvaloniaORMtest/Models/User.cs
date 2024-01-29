namespace AvaloniaORMtest.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Group Group { get; set; }


    public User()
    {
        
    }
    public User(string username, string password, Group group)
    {
        Username = username;
        Password = password;
        Group = group;
    }
}