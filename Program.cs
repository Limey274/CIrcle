using System;

namespace CIrcle
{
    class MathCircle
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            A = (Math.PI) * r * r;
            Console.WriteLine("The Area of circle = " + A);
            Console.WriteLine();

            double mpg;
            Console.WriteLine("What's your MPG? " );
            mpg = Convert.ToDouble(Console.ReadLine());
            while ( mpg <= 0 || mpg == double.NaN)
            {
                             
                    Console.WriteLine(" This is not a vaild input");
                    Console.WriteLine("What's your MPG? ");
                    mpg = Convert.ToDouble(Console.ReadLine());
              
                 
                
            }
            
            Console.WriteLine("You will use " + A / mpg + " gallons of gas to travel the radius of the circle");

        }
    }
}
