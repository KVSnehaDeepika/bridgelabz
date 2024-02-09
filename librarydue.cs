using System;
namespace A{
class librarydue{
static void Main(){
Console.WriteLine("Enter the days");
             int overduedays=Convert.ToInt32(Console.ReadLine());
             double fine=1;
             if ((37+overduedays) > 37)
             {
                 fine= overduedays*0.5;
             }
             Console.WriteLine(fine);
}
}
}
