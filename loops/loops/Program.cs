using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, no;
            System.Console.WriteLine("enter a no");
            no = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= no; i++){
                fact = fact * i;
            }
            System.Console.WriteLine("factorial of given no" + fact);
        }
    }
}