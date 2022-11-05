public class Student : User
{
    public Student(int userid, string username, int password):base(userid,username,password)
    {
        this.userId = userid;
        this.userName = username;
        this.password = password;
    }
}