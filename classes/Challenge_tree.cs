/*
These are very difficult.
*/
using System.Linq;

public class Challenge_three
{
    public void FizzBuzz(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");

            }
            else { Console.WriteLine(i); }

        }        // Todo: Implement fizzbuzz, if a number is divisible by 3: Fizz, if a number is divisible by 5: Buzz, if the number is divisible by both 3 and 5, FizzBuzz
        // https://www.geeksforgeeks.org/fizz-buzz-implementation/
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }

        return n * RecursiveFactorial(n - 1);
    }
    //reverse string
    public string ReverseString(string str)
    {
        // Todo: reverse the given string
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return string.Join("", charArray);

    }
}