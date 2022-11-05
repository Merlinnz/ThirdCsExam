public class Teacher : User
{
    public Teacher(int userid, string username, int password):base(userid,username,password)
    {
        this.userId = userid;
        this.userName = username;
        this.password = password;
    }
}