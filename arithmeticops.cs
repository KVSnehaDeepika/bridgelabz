using System;
namespace A{
class arithmeticops{
public static void Main(){
Console.WriteLine("Enter two numbers to perform operations");
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter add or sub or mul or div to perform operations");
            string choice=Console.ReadLine();
            switch(choice)
            {
                case "add" : Console.WriteLine("Sum:"+(a+b));
                    break;
                case "sub":
                    Console.WriteLine("Difference:" + (a - b));
                    break;
                case "mul":
                    Console.WriteLine("Product:" + (a * b));
                    break;
                case "div":
                    Console.WriteLine("Quotient:" + (a / b));
                    break;
                default:Console.WriteLine("You entered an invalid choice");
                    break;
            }
}
}
}
