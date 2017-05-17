using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{

    //A Palindrome number or numeral palindrome is a number that remains the same when its digits are reversed (e.g. 11,121, 1331,12321)
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, reverse = 0;
            Console.Write("\n\nInput any positive number : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n palindromic : Check a number is palindromic number or not :");
            Console.WriteLine("--------------------------------------------------------\n\n ");
            temp = num;
            while (num > 0)
            {

                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;

            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is  = {0}", reverse);

            Console.WriteLine("\n\n--------------------------------------------------------\n\n ");
            if (temp == reverse)
                Console.WriteLine("Number is a palindrome \n");                
            else
                Console.WriteLine("Number is not a palindrome \n");

            Console.WriteLine("--------------------------------------------------------\n\n ");
            Console.ReadLine();
        }
    }
}
