using C3lesson7instagram.Models;
using C3lesson7instagram.admn;
using System.Net;
using System.Net.Mail;
using Possts.nets;
using System.Data;
using Notfcs.nets;
/*using System.Drawing;
using Notfcs.nets;
using Possts.nets;
using  C3lesson7instagram.mainmodels;*/

#region  fonss  
string fonq = (@"               
          .:-==============--.          
        :+***+============++***:        
       -**=.                .=**=       
      .+*=        .::.   -**: -**:      
      .++-     -+******+-.::  :**-      
      .++:    +**-.  .:+**:   :**-      
      .==:   -**:      .***   :**-      
      .==:   -++.       ***   :**-      
      .==:    =++:    :+**:   :**-      
      .-=:     -+++++***=.    :**-      
       --:       .::::.       -**:      
       :--:                  -**+       
        .:---::::---------=+**+-        
           .:::----------==--. 
");
string fon = (@" 
                                      _         _                            
                                     (_)_ _  __| |_ __ _ __ _ _ _ __ _ _ __  
                                     | | ' \(_-<  _/ _` / _` | '_/ _` | '  \ 
                                     |_|_||_/__/\__\__,_\__, |_| \__,_|_|_|_|
                                                        |___/                                                                   
");
string fon3 = @"
                
                   |              o     
                   |    ,---.,---..,---.
                   |    |   ||   |||   |
                   `---'`---'`---|``   '
                             `---' 
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


";

string fon4 = @"
                      ^    ^    ^    ^    ^    ^    ^    ^  
                     /r\  /e\  /g\  /i\  /s\  /t\  /e\  /r\ 
                    <___><___><___><___><___><___><___><___>
";

string fon5 = (@"
 __  ___  _______     _______. _______  _______ .___________.
|  |/  / |   ____|   /       ||   ____||   ____||           |
|  '  /  |  |__     |   (----`|  |__   |  |__   `---|  |----`
|    <   |   __|     \   \    |   __|  |   __|      |  |     
|  .  \  |  |____.----)   |   |  |     |  |____     |  |     
|__|\__\ |_______|_______/    |__|     |_______|    |__|     
");

string[] menu1 = {
                   "\t\t\t\t[1] => Login",
                  "\t\t\t\t[2] => Register" };
int select = 1; Console.WriteLine();
int select2 = 1;
int select3 = 1;
int select4 = 1;

string[] menu2 = {
                   "\t\t\t\t[1] => Admin",
                   "\t\t\t\t[2] => User",
                  "\t\t\t\t[3] => Exit" };


string[] menuadmin = {
                   "\t\t\t\t[1] => Add Post",
                   "\t\t\t\t[2] => Show Users",
                   "\t\t\t\t[3] => Delete Post",
                   "\t\t\t\t[4] => Exit",
                   "\t\t\t\t[5] => Show all posts",
                   "\t\t\t\t[6] => Notifilications"
};

#endregion

#region datas 
DateTime brd = DateTime.Now;
Admin admin1 = new Admin("admin", "adminone", "admin@gmail.com", "admin4321", brd);
Admin admin2 = new Admin("admin2", "admin2", "admin2@gmail.com", "admin123", brd);
Admin admin3 = new Admin("admin3", "admin3", "admin3@gmail.com", "admin21", brd);



DateTime brd1 = new DateTime(2005, 07, 04);
DateTime brd2 = new DateTime(2008, 09, 07);
DateTime brd3 = new DateTime(2003, 06, 03);
DateTime brd4 = new DateTime(2004, 11, 13);
User user1 = new User("Adil", "Pashayev", "mirtalibemirli498@gmail.com", "adil21", brd1);
User user2 = new User("Mirtalib", "Emirli", "mirtalibemirli498@gmail.com", "miri321", brd2);
User user3 = new User("Kamal", "Eliyev", "mirtalibemirli498@gmail.com", "kamal421", brd3);
User user4 = new User("Yagmur", "Novruz", "mirtalibemirli498@gmail.com", "ril421", brd4);

Post PP = new Post(" ", "");
Post p1 = new Post("Formula1", admin1.Name);
Post p2 = new Post("Around city", admin2.Name);
Post p3 = new Post("in nature with my pet", admin3.Name);


Databasee db1 = new Databasee();
db1.adminss.Add(admin1);
db1.adminss.Add(admin2);
db1.adminss.Add(admin3);
db1.users.Add(user1);
db1.users.Add(user2);
db1.users.Add(user3);
db1.users.Add(user4);
db1.posts.Add(p1);
db1.posts.Add(p2);
db1.posts.Add(p3);



/*

db1.showallposts();

Thread.Sleep(555555);*/
#endregion


while (true)
{

    #region firstentering
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine(fon);
    Console.WriteLine(fonq);
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;


    if (select == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menu1[0]);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(menu1[1]);

    }
    else if (select == 2)
    {
        Console.WriteLine(menu1[0]);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menu1[1]);
        Console.ForegroundColor = ConsoleColor.White;


    }

    ConsoleKeyInfo key = Console.ReadKey();



    if (key.Key == ConsoleKey.UpArrow)
    {
        if (select == 1) select = 2;
        else select -= 1;

    }

    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (select == 2) select = 1;
        else select += 1;

    }




    #endregion


    if (key.Key == ConsoleKey.Enter)
    {
        //logining
        if (select == 1)
        {
            while (true)
            {

                #region login

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(fon3);
                Console.ForegroundColor = ConsoleColor.White;

                if (select2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menu2[0]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(menu2[1]);
                    Console.WriteLine(menu2[2]);

                }
                else if (select2 == 2)
                {
                    Console.WriteLine(menu2[0]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menu2[1]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(menu2[2]);


                }

                else if (select2 == 3)
                {
                    Console.WriteLine(menu2[0]);
                    Console.WriteLine(menu2[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menu2[2]);

                    Console.ForegroundColor = ConsoleColor.White;


                }


                ConsoleKeyInfo key2 = Console.ReadKey();


                if (key2.Key == ConsoleKey.UpArrow)
                {
                    if (select2 == 1) select2 = 3;
                    else select2 -= 1;

                }

                else if (key2.Key == ConsoleKey.DownArrow)
                {
                    if (select2 == 3) select2 = 1;
                    else select2 += 1;

                }

                #endregion


                if (key2.Key == ConsoleKey.Enter) //user ve ya adminin secilen hssedi enter edmeyidi loginde
                {


                    if (select2 == 1) //bu adminin edmeyidi
                    {

                        #region scentering

                        try
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Gmail :");
                            string gm = Console.ReadLine();

                            Console.Write("Password :");
                            string pw = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.White;


                            if (gm == admin1.Mail || gm == admin2.Mail || gm == admin3.Mail)
                            {
                                if (pw == admin1.Password || pw == admin2.Password || pw == admin3.Password)
                                {
                                    while (true)
                                    {

                                        #region menuadmin
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(fon5);

                                        Console.ForegroundColor = ConsoleColor.White;

                                        if (select4 == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(menuadmin[0]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(menuadmin[1]);
                                            Console.WriteLine(menuadmin[2]);
                                            Console.WriteLine(menuadmin[3]);
                                            Console.WriteLine(menuadmin[4]);
                                            Console.WriteLine(menuadmin[5]);

                                        }
                                        else if (select4 == 2)
                                        {
                                            Console.WriteLine(menuadmin[0]);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(menuadmin[1]);
                                            Console.ForegroundColor = ConsoleColor.White;

                                            Console.WriteLine(menuadmin[2]);
                                            Console.WriteLine(menuadmin[3]);
                                            Console.WriteLine(menuadmin[4]);
                                            Console.WriteLine(menuadmin[5]);


                                        }

                                        else if (select4 == 3)
                                        {
                                            Console.WriteLine(menuadmin[0]);
                                            Console.WriteLine(menuadmin[1]);
                                            Console.ForegroundColor = ConsoleColor.Green;

                                            Console.WriteLine(menuadmin[2]);
                                            Console.ForegroundColor = ConsoleColor.White;

                                            Console.WriteLine(menuadmin[3]);
                                            Console.WriteLine(menuadmin[4]);
                                            Console.WriteLine(menuadmin[5]);


                                        }
                                        else if (select4 == 4)
                                        {
                                            Console.WriteLine(menuadmin[0]);
                                            Console.WriteLine(menuadmin[1]);

                                            Console.WriteLine(menuadmin[2]);
                                            Console.ForegroundColor = ConsoleColor.Green;

                                            Console.WriteLine(menuadmin[3]);

                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(menuadmin[4]);
                                            Console.WriteLine(menuadmin[5]);


                                        }
                                        else if (select4 == 5)
                                        {
                                            Console.WriteLine(menuadmin[0]);
                                            Console.WriteLine(menuadmin[1]);

                                            Console.WriteLine(menuadmin[2]);

                                            Console.WriteLine(menuadmin[3]);
                                            Console.ForegroundColor = ConsoleColor.Green;

                                            Console.WriteLine(menuadmin[4]);

                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine(menuadmin[5]);


                                        }

                                        else if (select4 == 6)
                                        {
                                            Console.WriteLine(menuadmin[0]);
                                            Console.WriteLine(menuadmin[1]);

                                            Console.WriteLine(menuadmin[2]);

                                            Console.WriteLine(menuadmin[3]);

                                            Console.WriteLine(menuadmin[4]);
                                            Console.ForegroundColor = ConsoleColor.Green;

                                            Console.WriteLine(menuadmin[5]);
                                            Console.ForegroundColor = ConsoleColor.White;

                                        }

                                        ConsoleKeyInfo key3 = Console.ReadKey();


                                        if (key3.Key == ConsoleKey.UpArrow)
                                        {
                                            if (select4 == 1) select4 = 6;
                                            else select4 -= 1;

                                        }

                                        else if (key3.Key == ConsoleKey.DownArrow)
                                        {
                                            if (select4 == 6) select4 = 1;
                                            else select4 += 1;

                                        }

                                        #endregion


                                        //burda baslayr isleemler

                                        if (key3.Key == ConsoleKey.Enter)
                                        {
                                            Console.Clear();
                                            if (select4 == 1)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Please enter posts content");
                                                string cnt = Console.ReadLine();

                                                Console.WriteLine("Please enter name");
                                                string name = Console.ReadLine();

                                                Post p9 = new Post(cnt, name);

                                                db1.posts.Add(p9);

                                            }
                                            else if (select4 == 2)
                                            {
                                                db1.showusers();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Please enter Esc for returning");
                                                ConsoleKeyInfo k2 = Console.ReadKey(true);

                                                if (k2.Key == ConsoleKey.Escape)
                                                {
                                                    break;
                                                }

                                            }
                                            else if (select4 == 3)
                                            {
                                                //yaz
                                                try
                                                {
                                                    Console.WriteLine();
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("Here are all the posts:");
                                                    Console.WriteLine();
                                                    Console.Write("Enter the ID of the post you want to remove: ");
                                                    string? idguid = Console.ReadLine();

                                                    if (int.TryParse(idguid, out int id1))
                                                    {
                                                        if (db1.posts.Count == 1)
                                                        {
                                                            db1.posts.Clear();

                                                        }
                                                        else
                                                        {
                                                            for (int i = 0; i < db1.posts.Count; i++)
                                                            {
                                                                if (db1.posts[i].randomid == id1)
                                                                {
                                                                    db1.posts.RemoveAt(i);
                                                                }
                                                            }
                                                        }

                                                        Console.Write("");
                                                        Console.WriteLine("Please press Enter to return to the menu ");
                                                        ConsoleKeyInfo keyguid = Console.ReadKey(true);
                                                    }

                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);

                                                }



                                                Console.ForegroundColor = ConsoleColor.White;

                                            }

                                            else if (select4 == 5)
                                            {
                                                db1.showallposts();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Please enter Esc for returning");
                                                ConsoleKeyInfo k2 = Console.ReadKey(true);

                                                if (k2.Key == ConsoleKey.Escape)
                                                {
                                                    break;
                                                }
                                                //showposts
                                            }
                                            else if (select4 == 4)
                                            {

                                                break;
                                            }
                                            else if (select4 == 6)
                                            {
                                                db1.showallnotify();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Please enter Esc for returning");
                                                ConsoleKeyInfo k2 = Console.ReadKey(true);

                                                if (k2.Key == ConsoleKey.Escape)
                                                {
                                                    break;
                                                }
                                            }






                                        }





                                    }


                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;


                                    throw new Exception("Wrong password ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;


                                throw new Exception("Wrong gmail ");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);

                        }
                        #endregion





                    }///


                    else if (select2 == 2)
                    {


                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Username :");
                        string gm = Console.ReadLine();
                        try
                        {


                            Console.Write("Password :");
                            string pw = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.White;


                            if (gm == user1.Name || gm == user2.Name || gm == user3.Name || gm == user4.Name)
                            {
                                if (pw == user1.Password || pw == user2.Password || pw == user3.Password || pw == user4.Password)
                                {



                                    Console.Clear();
                                    db1.showallposts();

                                    Console.WriteLine(@"
If you want Like post press L key and enter ID
For go back  press enter key ");
                                    ConsoleKeyInfo keyu = Console.ReadKey(true);
                                    if (keyu.Key == ConsoleKey.L)
                                    {
                                        Console.Write("Enter id =>");

                                        int idd = Convert.ToInt32(Console.ReadLine());
                                        foreach (var item in db1.posts)
                                        {
                                            if (item.randomid == idd)
                                            {
                                                DateTime tm = DateTime.Now;
                                                notificl n1 = new notificl(tm, gm);

                                                db1.notificls.Add(n1);
                                                item.Like();

                                            }
                                        }
                                    }
                                    else if (keyu.Key == ConsoleKey.Enter)
                                    {
                                        break;
                                    }

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;


                                    throw new Exception("Wrong password ");

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;


                                throw new Exception("Wrong gmail ");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Thread.Sleep(1500);

                        }





                    }

                    else if (select2 == 3)
                    {
                        break;

                    }


                }

            }
        }


        // register part
        #region Register
        else if (select == 2)
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(fon4);
                Console.ForegroundColor = ConsoleColor.White;

                string name, surname, mail, password;
                int day, mon, yr;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("name =>");
                name = Console.ReadLine();
                Console.WriteLine("surname =>");
                surname = Console.ReadLine();

                Console.WriteLine("new  mail =>");
                mail = Console.ReadLine();

                Console.WriteLine("new  password =>");
                password = Console.ReadLine();

                Console.WriteLine("~~~~~~~~~~Birth details~~~~~~~~~~  ");
                Console.WriteLine();
                Console.WriteLine("Birth day =>");
                day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Birth month =>");
                mon = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Birth year =>");
                yr = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                DateTime day2 = new DateTime(yr, mon, day);


                User newuser = new User(name, surname, mail, password, day2);
                db1.users.Add(newuser);
                Console.ForegroundColor = ConsoleColor.Red;




                string senderEmail = "mirtalibemirli498@gmail.com";
                string senderPassword = "aytndmgzqcukvmds";

                Console.Write("Enter your mail => ");
                string recipientEmail = Console.ReadLine();

                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;

                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.EnableSsl = true;

                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                    using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail))
                    {
                        mailMessage.Subject = "Registration";
                        /* Guid newguid = Guid.NewGuid();
                         string tst2 = newguid.ToString();
                        bu uzun idi deye isledmedim size ezyet olacaq onu yazmaq
                         */
                        Random random = new Random();
                        int msg = random.Next(0, 100);
                        mailMessage.Body = $"{msg}";



                        try
                        {
                            smtpClient.Send(mailMessage);
                            Console.Write("Enter a code you accepted from Admin => ");
                            int testcode = Convert.ToInt32(Console.ReadLine());
                            if (testcode == msg)
                                Console.WriteLine("You are registered sucsessfully.");
                            else
                            {
                                Console.WriteLine("You don't registered .");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Failed to send email. Error's message: {ex.Message}");
                        }
                    }
                }



                Thread.Sleep(2500);

                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Thread.Sleep(3500);
            }

        }
        #endregion


    }

}





/*
 * Notes
 * ******************************************************
 * proqramin esas namespaecesi globaldir
 * yaratdqmz namespaceni bildirerek isdifadede ede bilerik
 * pathi herdefe yazmalyq
 * her bir class i ayri yazmaq daha yaxsidir
 * clasdar eyni folderdedirse eyni namespacede saylr
 * partial method ancaq partial class daxxilinde olur
 * partial class class boyuk olduqda onu kicildmekcun isdifade edilir
 * methodlari bolmek ucun( public partial class name)
 * readonly sadefce obyekt yarananda deyer verile bilir
 * propertini init ile readonly edmek olar
 * yalniz class daxilinde isdenr
 * Const deyisen define ola bilmir
 * ve deyisen yaradanda deyer alir
 * amma readonly ise obyekt yaradanda verlr
 * yeni const butun obyektler ucun eyndir 
 * mm redonly ise baya ferqqlidir
 * static konstruktor sadece bir defe isdeye blir ve bu ilk muracietde oolur
 * run eddikde ilk defe obyekt yaradqa ve ya classa muraciet eddikde olur
 * public static implicit int() ; typecast operator overloading
 * 
 

try
{
    int a = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex ) when (ex.Message.Contains("string"))
{
    Console.WriteLine( ex.ToString() ); 
    Console.WriteLine( "AAAA"); 
}
catch (Exception ex ) when (ex.Message.Contains("S "))
{
    Console.WriteLine( ex.ToString() ); 
}
 */





















