using System;
namespace A{
class login{
public static void Main(){
Console.WriteLine("Enter user name");
             string euname=Console.ReadLine();
             Console.WriteLine("Enter password");
             string epassword=Console.ReadLine();
             string uname = "deepika";
             string password = "d";
             if(uname==euname && epassword == password)
             {
                 Console.WriteLine("Login successful");
             }
             else
             {
                 Console.WriteLine("You entered an invalid user name or password");
             }
}
}
}
