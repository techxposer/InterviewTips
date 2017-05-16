using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Prime Number : A number that is divisible only by itself and 1 (e.g. 2, 3, 5, 7, 11).
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int number, primeNumber;           

            Console.Write("\n\nInput any positive number : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n Recursion : Check a number is prime number or not :");
            Console.WriteLine("--------------------------------------------------------");

            primeNumber = IsPrime(number, number / 2);

            if (primeNumber == 1)
                Console.Write("\n\nThe number {0} is a prime number. \n\n", number);
                else
                Console.WriteLine("\n\nThe number {0} is not a prime number. \n\n", number);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n\n Non-Recursion : Check a number is prime number or not :");
            Console.WriteLine("--------------------------------------------------------");

            //Without Recursion
            int i, flag = 0;

            for (i = 2; i <= number / 2; ++i)
            {

                if (number % i == 0)
                {

                    flag = 1;
                    break;

                }

            }

            if (flag == 0)
                Console.Write("\n\nThe number {0} is a prime number. \n\n", number);
            else
                Console.WriteLine("\n\nThe number {0} is not a prime number. \n\n", number);

            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey();

        }

        //Using Recursion 
        static int IsPrime(int number, int i)
        {

            if (i == 1)
            {

                return 1;

            }
            else
            {

                if (number % i == 0)
                    return 0;
                else
                    return IsPrime(number, i - 1);//calling the function IsPrime itself recursively
            }

        }
    }
}
