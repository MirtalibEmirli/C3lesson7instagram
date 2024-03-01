
namespace C3lesson7instagram.Models;


public partial class Databasee
{

    public partial void showadmins()
    {
        foreach (var item in adminss)
        {
            item.show();
        }
    }


    public partial void showusers()
    {
        foreach (var item in users)
        {
            item.show();    
        }

    }
    public partial void showallposts()
    {
        foreach (var item in posts)
        {
            item.show();
        }
    }

    public partial void showallnotify()
    {
        foreach (var item in notificls)
        {
            item.show();
        }
    }


}
