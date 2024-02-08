using System;
namespace A{
	class temp{
	int a=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter a string");
            String str=Console.ReadLine();
            switch (str) {
                case "C": Console.WriteLine("to convert farenhiet to celsius");
                    int b = (a - 32)*5 / 9;
                    Console.WriteLine(b);
                    break;
                case "F":
                    Console.WriteLine("to convert celsius to farenhiet ");
                    int c = (9 / 5)*a + 32;
                    Console.WriteLine(c);
                    break;
                default: Console.WriteLine("You entered invalid data");
                    break;
            }
	}
}
