using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             CalculateClass cs = new CalculateClass(1,2,3,4,5,6,7,8,9);
            Console.WriteLine("Sum() is:" + cs.Sum());
        }
    }
}
