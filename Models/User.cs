namespace AuthApp.Models;

public class User
{
    public int UId{get;}
    public string UName { get;}
    public string UPassword {get;}
    public string UEmail {get;}
    public int UAge {get;}
    public User(int uId,string uName, string uPassword, string uEmail, int uAge)
    {
        UId = uId;
        UName = uName;
        UPassword = uPassword;
        UEmail = uEmail;
        UAge = uAge;
    }


}