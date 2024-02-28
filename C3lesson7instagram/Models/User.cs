﻿

namespace C3lesson7instagram.Models;
using C3lesson7instagram.mainmodels;

public class User:Person
{
    public User(string name, string surname, string mail, string password, DateTime day) : base(name, surname, mail, password, day) { }
    Guid randomguid = Guid.NewGuid();

    public override void show()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        string v = _day.ToString("MMMM dd yyyy ");
        Console.WriteLine(

$@"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Name => {Name}
        SurName => {Surname}
        Mail => {Mail}
        PAssword => {Password}

        ID => {randomguid}

        Entering => {v} 

");
        Console.ForegroundColor = ConsoleColor.White;
    }

}
