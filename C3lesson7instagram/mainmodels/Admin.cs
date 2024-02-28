
namespace C3lesson7instagram.admn;
using C3lesson7instagram.mainmodels;

public class Admin :Person 
{
    public Admin(string name, string surname, string mail, string password, DateTime day) : base(name, surname, mail, password, day) { }
    public override void show()
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($@"
        Name => {Name}
        SurName => {Surname}
        Mail => {Mail}
        PAssword => {Password}
        Entering => {_day} 
       
");
        Console.ForegroundColor = ConsoleColor.White;
    }

}
