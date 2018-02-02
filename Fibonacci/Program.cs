using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a fibonacc sequence's size:");
            string userInputString = Console.ReadLine();
            int sequenceSize = ValidateInput(userInputString);
            List<BigInteger> fibonacciSequence = new List<BigInteger>(FindFibonacci(sequenceSize));

            Console.Write("Fibonacc sequence to {0}th number: ",sequenceSize);
            foreach (BigInteger number in fibonacciSequence)
            {
                if (number == fibonacciSequence.Last())
                    Console.Write("{0};", number);
                else
                    Console.Write("{0}, ", number);
              
            }
            Console.ReadLine();
        }

        public static List<BigInteger> FindFibonacci(int n)
        {
            List<BigInteger> fibonacciSequence = new List<BigInteger>();
            fibonacciSequence.Add(0);
            fibonacciSequence.Add(1);

            if (n ==1)
            {
                fibonacciSequence.RemoveAt(1);
                return fibonacciSequence;
            }
            if (n == 2)
            {
                return fibonacciSequence;
            }

            for (int i = 0; i < n-2; i++)
            {
                fibonacciSequence.Add(BigInteger.Add(fibonacciSequence.Last(), fibonacciSequence[fibonacciSequence.Count-2]));
            }
            return fibonacciSequence;
        }

        private static int ValidateInput(string userInputString)
        {
            int numberOfNumbers;
            while ((!int.TryParse(userInputString, out numberOfNumbers)) || (numberOfNumbers <= 0))
            {
                Console.Write("Write correct value:");
                userInputString = Console.ReadLine();
            }
            return numberOfNumbers;
        }
    }
}
