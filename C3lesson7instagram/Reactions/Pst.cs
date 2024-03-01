
using System.Xml.Linq;

namespace Possts.nets;

public class Post
{

    public Guid randomid;


    /*
        public Guid _id { get; }
        public string Id { get; }*/

    private int _likeCount;
    public DateTime _creationDateTime = DateTime.Now;

    private string _content;



    public Post() { }
    private string _name;
    public Post(string content, string name)
    {
        _likeCount = 0;
        _name = name;
        Content = content;
        randomid = Guid.NewGuid();
        
    }

    public int LCount { get { return _likeCount; } set { _likeCount = value; } }


    public string Content { get { return _content; } init { _content = value; } }

    public void Like()
    {
        _likeCount++;
    }

   




    public void show()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        string v = _creationDateTime.ToString("MMMM  dd yyyy ~hh : mm : ss");
        Console.WriteLine(

$@"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Creator Name => {_name}
        Likecount => {_likeCount}
        Content=> {_content}
        ID => {randomid}
        Creating time => {v} 

"  );
        Console.ForegroundColor = ConsoleColor.White;
    }


}
