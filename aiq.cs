using System;
namespace A{
class aiq{
public static void Main(){
Console.WriteLine("Enter the concentration of the pollutants");
             double a=Convert.ToDouble(Console.ReadLine());
             if(a>=0 && a <= 50)
             {
                 Console.WriteLine("Good");
             }
             else if(a>50 && a <= 100)
             {
                 Console.WriteLine("Moderate");
             }
             else if(a>100 && a <= 150)
             {
                 Console.WriteLine("Unhealthy");
             }
             else if(a>150 && a <= 200)
             {
                 Console.WriteLine("Unhealthy for Strong People");
             }
             else if(a>200)
             {
                 Console.WriteLine("Hazardous");
             }
}
}
}
