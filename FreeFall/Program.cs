using System;

namespace FreeFall
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal g = -9.8m;
            Console.Write("Enter the height at which the object is dropped in meters: ");
            decimal height = decimal.Parse(  Console.ReadLine()  );
            decimal impactSpeed = (decimal)Math.Sqrt((double)(2 * g * (height * -1))); ;
            Console.WriteLine("The object will hit the ground at " + impactSpeed + " m/s");
        }
    }
}
