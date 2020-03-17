using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test();
        }


        static void Test()
        {
            Console.WriteLine("This is a method");

            /*Variable and Data types*/
            string firstName = "Debbie";
            Console.WriteLine("My name is: " + firstName);

            int age = 99;
            long seconds = 1298031872903180;

            float price = 12.34f;
            decimal money = 123.23m;
          
            bool isThisCrazy = true;

            // if statements
            if(isThisCrazy)
            {
                Console.WriteLine("Yeah it is");

            }
            else
            {
                Console.WriteLine("No, it is not");

            }

            // loops
            for(int i=0; i < 10; i++){
                Console.WriteLine("Iteration: " + i);
            }


        }
    }
}
