public class User
{
    public int userId { get; set; }
    public string? userName { get; set; }
    public int password { get; set; }
    public User(int userid, string username, int password)
    {
        this.userId = userid;
        this.userName = username;
        this.password = password;
    }
    public virtual void GetUserInfo()
    {
        Console.WriteLine("userId: " + userId + " || " +  "Username: " + userName + " || " + "Password: " + password);
    }
}

