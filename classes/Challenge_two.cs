public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 69; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine());
            if (guess == secret)
            {
                Console.WriteLine("riktig");
                break;
            }
            else
            {
                Console.WriteLine("FEEEEIL");

            }
            // Todo: Implement the correct conditionals inside the while loop.

        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        // Console.WriteLine($"{a} + {b} + ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;

        }
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.

    }

    public void CheckIfNumberIsEvenOrOdd(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        Console.WriteLine("");
    }
}