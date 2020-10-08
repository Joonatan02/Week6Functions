using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser();
            Numbers();

        }
        public static void HelloUser()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public static void Numbers()
        {
            Console.WriteLine("Enter the first number");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the secoung number");
            int num2 = Int32.Parse(Console.ReadLine());

            int result = num + num2;
                Console.WriteLine($"Summary: {result}");

            
            
            


        }


    }

}
