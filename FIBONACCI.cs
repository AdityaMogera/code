using System;
using System.Collections.Generic;
using System.Text;

namespace loops
{
    class Class1
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, no;
            System.Console.WriteLine("enter the no");
            no = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(n1 + " " + n2 + " ");
            for (i = 2; i < no; i++)
            {
                n3 = n2 + n1;
                System.Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
