namespace AuthApp.Models;

public class User
{

    public string UName { get;}
    public string UPassword {get;}
    public string UEmail {get;}
    public int UAge {get;}
    public User(string uName, string uPassword, string uEmail, int uAge)
    {
        UName = uName;
        UPassword = uPassword;
        UEmail = uEmail;
        UAge = uAge;
    }


}