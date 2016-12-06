using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Fibonacci
    {
        public int prev = 0;//declaring public variables
        public int current;
        public int input = 0;//done declaring variables
        public int fib(int num1, int prev)
        {//for calculating the fibonacci numbers
            if (input == 0)
            {//for if it's the first time running the program or after it's done calculating
                Console.Out.WriteLine("Enter a number greater than 0");
                input = int.Parse(Console.ReadLine());
                prev = 0;
                num1 = 1;
            }
            if (input < 0)
            {
                System.Environment.Exit(1);
            }
            if (input == 0)
                current = 1;
            else
            {
                Console.Out.WriteLine(prev);
                input = input - 1;
                current = num1 + fib(num1+prev, prev=num1);
            }
            return current;
        }
        static void Main(string[] args)
        {

            Fibonacci myFib = new Fibonacci();
            myFib.fib(1, 0);

            
                

            Console.In.ReadLine();
        }        
    }
}
