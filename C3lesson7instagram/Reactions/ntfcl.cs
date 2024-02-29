
using C3lesson7instagram.Models;

namespace Notfcs.nets;
public class notificl
{

    public int randomid = Random.Shared.Next(0, 101);
    private DateTime _creationDateTime ;
    string text = "Liked your post ";
   string _u1;
  public  notificl( DateTime creationDateTime, string u1)
    {
        _creationDateTime = creationDateTime;
        _u1 = u1;
    }

    public void show()
    {
        Console.ForegroundColor = ConsoleColor.Green;   
        Console.WriteLine($@"
        ID => {randomid}
        Text =>{text}
        DAte {_creationDateTime}
        User => {_u1}

"

);
        Console.ForegroundColor = ConsoleColor.White;

    }
}
