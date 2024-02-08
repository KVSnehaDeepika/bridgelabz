namespace A { 
class grade
{
        public static void Main()
        {
         
	   Console.WriteLine("Enter student score");
            double a=Convert.ToDouble(Console.ReadLine());
            if(a>=90 && a < =100) {
                Console.WriteLine("Grade A");
            }
            else if(a>=80 && a <= 89)
            {
                Console.WriteLine("Grade B");
            }
            else if(a>=70 && a < =79)
            {
                Console.WriteLine("Grade C");
            }
            else if (a >= 60 && a <= 69)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
	}
	}
}
