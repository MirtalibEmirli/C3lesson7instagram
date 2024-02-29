
using System.Xml.Linq;

namespace Possts.nets;

public class Post
{
    
  public  int randomid =Random.Shared.Next(0,101);





    private int _likeCount, _viewCount;
    public DateTime _creationDateTime = DateTime.Now;

    private string _content;
    public List<string> comments = new List<string>();



    public Post() { }
    private string _name;
    public Post(string content, string name)
    {
        _likeCount = 0;
        _viewCount = 0 ;
        _name = name;
        Content = content;
    }

    public int LCount { get { return _likeCount; } set { _likeCount = value; } }

    public int ViewCount { get { return _viewCount; } set { _viewCount = value; } }

    public string Content { get { return _content; } init { _content = value; } }

    public void Like()
    {
        _likeCount++;
    }

    public void View()
    {
        _viewCount++;
    }


    public void Commentt()
    {
        Console.Write("Write your opinion about this => ");
        string cm = Console.ReadLine();
        comments.Add(cm);
        Thread.Sleep(1000);


    }


    public void show()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        string v = _creationDateTime.ToString("MMMM  dd yyyy ~hh : mm : ss");
        Console.WriteLine(

$@"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Creator Name => {_name}
        Likecount => {_likeCount}
        Viewcount => {_viewCount}
        Content=> {_content}

        ID => {randomid}

        Creating time => {v} 

"  );
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("Comments ");
        foreach (var item in comments)
        {
            Console.WriteLine(item);    
        }
        Console.ForegroundColor = ConsoleColor.White;
    }


}
