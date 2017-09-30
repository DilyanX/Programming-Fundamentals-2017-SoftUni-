using System;


namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = a + b;

            Console.WriteLine("{0} + {1} = {2}",a , b ,c);
        }
    }
}
