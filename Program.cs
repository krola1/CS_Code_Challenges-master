namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Challenge_one one = new Challenge_one();
        // Todo: Print out the numbers 1 - 10
        one.PrintNumbers();
        /* Todo: Print out each string that is passed to the array as an argument*/
        string[] array1 = [];
        one.PrintStrings(array1);
        /*
         Todo: Check if a number is positive, negative or zero.
        */
        one.CheckIfNumberIsPositiveOrNegative(0);

        Challenge_two two = new Challenge_two();
        //Prints fibbonachi
        two.Fibonacci(20);
        //guess the secret number
        two.GuessNumber();
        //checs if even or odd
        two.CheckIfNumberIsEvenOrOdd(Convert.ToDouble(Console.ReadLine()));

        Challenge_three three = new Challenge_three();
        // Fizzbuzz
        three.FizzBuzz(Convert.ToInt32(Console.ReadLine()));
        // Reverse a given string
        Console.WriteLine(three.ReverseString("lars"));


        // validate some methods
        void ValidateRecursiveFactorial()
        {
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        ValidateRecursiveFactorial();
    }
}
;