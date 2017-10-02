using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\r\na = {0}\r\nb = {1}",a ,b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After:\r\na = {0}\r\nb = {1}", a, b);
        }
    }
}
