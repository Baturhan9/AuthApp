using System.ComponentModel.DataAnnotations;

namespace AuthApp.Models;

public class User
{
    [Key]
    public int UId{get;set;}
    public string UName { get;set;}
    public string UPassword {get;set;}
    public string UEmail {get;set;}
    public int UAge {get;set;}
    public User(int uId, string uName, string uPassword, string uEmail, int uAge)
    {
        UId = uId;
        UName = uName;
        UPassword = uPassword;
        UEmail = uEmail;
        UAge = uAge;
    }
}