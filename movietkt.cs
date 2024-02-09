using System;
namespace A{
	class movietkt{
		public static void Main(string[] args){
			Console.WriteLine("Enter the movie time");
            		string time = Console.ReadLine();
            		Console.WriteLine("Enter age of a person");
            		int age=Convert.ToInt32(Console.ReadLine());
            		int price = 400;
            		Console.WriteLine("Enter discount percent");
            		int discount=Convert.ToInt32( Console.ReadLine());
            		if (time == "2:45PM")
            		{
                if (age < 12)
                {
                    int a = price - 100;
                    Console.WriteLine("Rs:" + (a*discount)/100);
                }
                else if (age >= 12 && age <= 64)
                {
                    Console.WriteLine("Rs:" + (price*discount)/100);
                }
                else
                {
                    int b = price - 50;
                    Console.WriteLine("Rs:" + (b*discount)/100);
                }
            }
            else
            {
                if (age < 12)
                {
                    Console.WriteLine("Rs:"+(price-100));
                }
                else if(age>=12 && age <= 64)
                {
                    Console.WriteLine("Rs:"+price);
                }
                else { 
                    Console.WriteLine("Rs:"+(price-50));
                }
            }
		}
	}
}
