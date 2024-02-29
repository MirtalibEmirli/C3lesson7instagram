
namespace C3lesson7instagram.Models;
using C3lesson7instagram.admn;
using Notfcs.nets;
using Possts.nets;

public partial class Databasee
{



   public List<Admin> adminss = new List<Admin>() ;
   public List<User> users = new List<User>();
   public List<Post> posts = new List<Post>();
   public List<notificl> notificls = new List<notificl>(); 
    public partial void showadmins();
    public partial void showusers();
    public partial void showallposts();
    public partial void showallnotify();

     

}
