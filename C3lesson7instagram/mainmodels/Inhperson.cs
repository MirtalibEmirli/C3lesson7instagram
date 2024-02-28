
namespace C3lesson7instagram.mainmodels;

public abstract class Person
{
    protected string _name; 
    protected string _surname; 
    protected string _mail; 
    protected string _password;
    public   DateTime _day   ;
    protected Person(string name, string surname, string mail, string password, DateTime day)
    {
        Name = name;
        Surname = surname;
        Mail = mail;
        Password = password;
        this._day=day;

    }

    public string Name { get { return _name; } set { _name = value; } }
    public string Surname { get { return _surname; } set { _surname = value; } }
    public  string  Mail { get { return _mail; } set { _mail = value; } }
    public string Password { get { return _password; } set { _password = value; } }
     
    public   abstract void show();
}
